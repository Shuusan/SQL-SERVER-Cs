namespace SQL_KD
{
    partial class frmSQL_KD1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbWallet = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dgvFriendInformation = new System.Windows.Forms.DataGridView();
            this.unique_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wallet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.dgvLoaner = new System.Windows.Forms.DataGridView();
            this.loanerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFriendInformation)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaner)).BeginInit();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(3, 3);
            this.tbName.MaxLength = 30;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(470, 22);
            this.tbName.TabIndex = 0;
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Location = new System.Drawing.Point(3, 31);
            this.tbPhoneNumber.MaxLength = 14;
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(470, 22);
            this.tbPhoneNumber.TabIndex = 1;
            // 
            // tbWallet
            // 
            this.tbWallet.Location = new System.Drawing.Point(3, 59);
            this.tbWallet.MaxLength = 20;
            this.tbWallet.Name = "tbWallet";
            this.tbWallet.Size = new System.Drawing.Size(470, 22);
            this.tbWallet.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(3, 87);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(237, 23);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.tbName);
            this.flowLayoutPanel1.Controls.Add(this.tbPhoneNumber);
            this.flowLayoutPanel1.Controls.Add(this.tbWallet);
            this.flowLayoutPanel1.Controls.Add(this.btnSubmit);
            this.flowLayoutPanel1.Controls.Add(this.btnDeleteAll);
            this.flowLayoutPanel1.Controls.Add(this.dgvLoaner);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(480, 445);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // dgvFriendInformation
            // 
            this.dgvFriendInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFriendInformation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.unique_id,
            this.name,
            this.phone_number,
            this.wallet});
            this.dgvFriendInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFriendInformation.Location = new System.Drawing.Point(0, 0);
            this.dgvFriendInformation.Name = "dgvFriendInformation";
            this.dgvFriendInformation.RowHeadersWidth = 51;
            this.dgvFriendInformation.RowTemplate.Height = 24;
            this.dgvFriendInformation.Size = new System.Drawing.Size(675, 442);
            this.dgvFriendInformation.TabIndex = 5;
            this.dgvFriendInformation.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFriendInformation_CellDoubleClick);
            // 
            // unique_id
            // 
            this.unique_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.unique_id.DataPropertyName = "unique_id";
            this.unique_id.HeaderText = "unique_id";
            this.unique_id.MinimumWidth = 6;
            this.unique_id.Name = "unique_id";
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            // 
            // phone_number
            // 
            this.phone_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.phone_number.DataPropertyName = "phone_number";
            this.phone_number.HeaderText = "phone_number";
            this.phone_number.MinimumWidth = 6;
            this.phone_number.Name = "phone_number";
            // 
            // wallet
            // 
            this.wallet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.wallet.DataPropertyName = "wallet";
            this.wallet.HeaderText = "wallet";
            this.wallet.MinimumWidth = 6;
            this.wallet.Name = "wallet";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvFriendInformation);
            this.panel1.Location = new System.Drawing.Point(498, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 442);
            this.panel1.TabIndex = 6;
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Location = new System.Drawing.Point(246, 87);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(227, 23);
            this.btnDeleteAll.TabIndex = 4;
            this.btnDeleteAll.Text = "DELETE ALL";
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // dgvLoaner
            // 
            this.dgvLoaner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaner.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.loanerName,
            this.loan});
            this.dgvLoaner.Location = new System.Drawing.Point(3, 116);
            this.dgvLoaner.Name = "dgvLoaner";
            this.dgvLoaner.RowHeadersWidth = 51;
            this.dgvLoaner.RowTemplate.Height = 24;
            this.dgvLoaner.Size = new System.Drawing.Size(470, 326);
            this.dgvLoaner.TabIndex = 6;
            this.dgvLoaner.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaner_CellDoubleClick);
            // 
            // loanerName
            // 
            this.loanerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.loanerName.DataPropertyName = "name";
            this.loanerName.HeaderText = "name";
            this.loanerName.MinimumWidth = 6;
            this.loanerName.Name = "loanerName";
            // 
            // loan
            // 
            this.loan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.loan.DataPropertyName = "loan";
            this.loan.HeaderText = "loan";
            this.loan.MinimumWidth = 6;
            this.loan.Name = "loan";
            // 
            // frmSQL_KD1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 466);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "frmSQL_KD1";
            this.Text = "SQL_KD";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFriendInformation)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.TextBox tbWallet;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvFriendInformation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn unique_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn wallet;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.DataGridView dgvLoaner;
        private System.Windows.Forms.DataGridViewTextBoxColumn loanerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn loan;
    }
}

