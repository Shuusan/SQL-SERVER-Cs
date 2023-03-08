using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RandomDataGenerator;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Randomizers;

namespace SQL_KD
{
    public partial class frmSQL_KD1 : Form
    {

        private const string connectionString = "Data Source=JOSHUALVIANDO\\SQLEXPRESS;" +
            "Integrated Security=True;" +
            "Connect Timeout=30;" +
            "Encrypt=False;" +
            "TrustServerCertificate=False;" +
            "ApplicationIntent=ReadWrite;" +
            "MultiSubnetFailover=False";

        private const string tableName = "test.dbo.friend_information";
        private const string tableLoaner = "test.dbo.friend_loan";

        private SqlServiceBasic sqlServiceBasic = new SqlServiceBasic(connectionString);


        public frmSQL_KD1()
        {
            InitializeComponent();
            initializedObject();

        }

        private void initializedObject()
        {
            initialziedGridView();
            initialziedGridViewLoaner();
        }


        private void initialziedGridView()
        {
            string sql = "Select * from " + tableName;
            dgvFriendInformation.DataSource = sqlServiceBasic.getAllTableData(sql).Tables[0];
        }

        private void initialziedGridViewLoaner()
        {
            string sql = "Select * from " + tableLoaner;
            dgvLoaner.DataSource = sqlServiceBasic.getAllTableData(sql).Tables[0];
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string sqlInsert = "insert into " + tableName + " (unique_id,name,phone_number,wallet)";
            string sqlValue = String.Format("values (NEWID(),'{0}','{1}','{2}');",tbName.Text, tbPhoneNumber.Text, tbWallet.Text);
            string sql = sqlInsert + sqlValue;
            if (!sqlServiceBasic.executeSql(sql))
            {
                MessageBox.Show("sql command failed!");
            }
        }


        private void doTransactionsThree(SqlConnection connection, string sql)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Inserting Data Successfully");
                connection.Close();
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
            initialziedGridView();
        }

        private void dgvFriendInformation_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
       
                if (e.ColumnIndex != -1)
                {
                    string sql = String.Format("delete from test.dbo.friend_information where name = '{0}';",
                        dgvFriendInformation.Rows[e.RowIndex].Cells[3].Value.ToString());
                    if (!sqlServiceBasic.executeSql(sql))
                    {
                        MessageBox.Show("sql command failed!");
                    }
                }
                else
                {
                    
                    string name = generateName(true);
                    string number = generateNumber(12);
                    string money = generateMoney(7);

                    tbName.Text = name;
                    tbPhoneNumber.Text = number;
                    tbWallet.Text = money;

                    string sqlInsert = "insert into " + tableName + " (unique_id,name,phone_number,wallet)";
                    string sqlValue = String.Format("values (NEWID(),'{0}','{1}','{2}');", name, number, money);
                    string sql = sqlInsert + sqlValue;

                    if (!sqlServiceBasic.executeSql(sql))
                    {
                        MessageBox.Show("sql command failed!");
                    }
                }
            


            initialziedGridView();

        }




        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string sql = "delete from " + tableName;

            doTransactionsThree(connection, sql);

            initialziedGridView();
        }

        private void dgvLoaner_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1)
            {
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(String.Format("delete from "+ tableLoaner + " where name = '{0}';",
                    dgvLoaner.Rows[e.RowIndex].Cells[0].Value.ToString()), connection);

                connection.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Deleteing Data Successfully");
            }
            else
            {
                // Generate a random first name
                var randomizerFirstName = RandomizerFactory.GetRandomizer(new FieldOptionsFirstName());
                string firstName = randomizerFirstName.Generate() + " " + randomizerFirstName.Generate();
                string money = generateMoney(7);

                tbName.Text = firstName;
                tbWallet.Text = money;

                string sqlInsert = "insert into " + tableLoaner + " (name,loan)";
                string sqlValue = String.Format("values ('{0}','{1}');", firstName, money);

                SqlConnection connection = new SqlConnection(connectionString);
                string sql = sqlInsert + sqlValue;

                SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
                doTransactionsThree(connection, sql);
            }

            initialziedGridViewLoaner();
        }


        private string generateName(bool isMiddleNameExist = false)
        {
            var randomizerFirstName = RandomizerFactory.GetRandomizer(new FieldOptionsFirstName());

            string name = randomizerFirstName.Generate() + " " + randomizerFirstName.Generate();
            if (isMiddleNameExist)
            {
                name = name + " " + randomizerFirstName.Generate();
            }

            return name;
        }
        private string generateNumber(int lenght)
        {
            string number = "08";
            var randomizerTextRegex = RandomizerFactory.GetRandomizer(new FieldOptionsTextRegex { P0attern = @"^[0-9]" });

            while (number.Length < lenght)
            {
                number = number + randomizerTextRegex.Generate();
            }

            return number;
        }

        private string generateMoney(int digitCount)
        {
            string number = "";
            var randomizerTextRegex = RandomizerFactory.GetRandomizer(new FieldOptionsTextRegex { Pattern = @"^[0-9]" });

            while (number.Length < digitCount)
            {
                number = number + randomizerTextRegex.Generate();
            }

            return number;
        }

    }

}
