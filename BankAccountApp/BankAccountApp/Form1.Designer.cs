namespace BankAccountApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            Accounttxt = new TextBox();
            AccountAmount = new NumericUpDown();
            AccountGrid = new DataGridView();
            Deposit = new Button();
            button2 = new Button();
            CreateAccount = new Button();
            ((System.ComponentModel.ISupportInitialize)AccountAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AccountGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(43, 50);
            label1.Name = "label1";
            label1.Size = new Size(222, 38);
            label1.TabIndex = 0;
            label1.Text = "Account Owner: ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(43, 401);
            label2.Name = "label2";
            label2.Size = new Size(231, 38);
            label2.TabIndex = 1;
            label2.Text = "Account Amount:";
            label2.Click += label2_Click;
            // 
            // Accounttxt
            // 
            Accounttxt.Location = new Point(271, 58);
            Accounttxt.Name = "Accounttxt";
            Accounttxt.Size = new Size(239, 31);
            Accounttxt.TabIndex = 2;
            // 
            // AccountAmount
            // 
            AccountAmount.Location = new Point(280, 408);
            AccountAmount.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            AccountAmount.Name = "AccountAmount";
            AccountAmount.Size = new Size(230, 31);
            AccountAmount.TabIndex = 3;
            AccountAmount.ValueChanged += AccountAmount_ValueChanged;
            // 
            // AccountGrid
            // 
            AccountGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AccountGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AccountGrid.Location = new Point(542, 50);
            AccountGrid.Name = "AccountGrid";
            AccountGrid.RowHeadersWidth = 62;
            AccountGrid.Size = new Size(436, 334);
            AccountGrid.TabIndex = 4;
            // 
            // Deposit
            // 
            Deposit.Location = new Point(542, 409);
            Deposit.Name = "Deposit";
            Deposit.Size = new Size(213, 31);
            Deposit.TabIndex = 5;
            Deposit.Text = "Deposit ";
            Deposit.UseVisualStyleBackColor = true;
            Deposit.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(778, 409);
            button2.Name = "button2";
            button2.Size = new Size(200, 31);
            button2.TabIndex = 6;
            button2.Text = "Withdraw";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // CreateAccount
            // 
            CreateAccount.Location = new Point(271, 120);
            CreateAccount.Name = "CreateAccount";
            CreateAccount.Size = new Size(239, 37);
            CreateAccount.TabIndex = 7;
            CreateAccount.Text = "Create Account";
            CreateAccount.UseVisualStyleBackColor = true;
            CreateAccount.Click += CreateAccount_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 498);
            Controls.Add(CreateAccount);
            Controls.Add(button2);
            Controls.Add(Deposit);
            Controls.Add(AccountGrid);
            Controls.Add(AccountAmount);
            Controls.Add(Accounttxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)AccountAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)AccountGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox Accounttxt;
        private NumericUpDown AccountAmount;
        private DataGridView AccountGrid;
        private Button Deposit;
        private Button button2;
        private Button CreateAccount;
    }
}
