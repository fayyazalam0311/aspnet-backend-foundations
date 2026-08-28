namespace BankAccountApp
{
    public partial class Form1 : Form
    {
        List<BankAccount> BankAccounts = new List<BankAccount>();
        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AccountGrid.SelectedRows.Count == 1)
            {
                BankAccount selectedBankAccount = AccountGrid.SelectedRows[0].DataBoundItem as BankAccount;

                string message = selectedBankAccount.Deposit(AccountAmount.Value);
                RefreshGrid();
                AccountAmount.Value = 0;
                MessageBox.Show(message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (AccountGrid.SelectedRows.Count == 1)
            {
                BankAccount selectedBankAccount = AccountGrid.SelectedRows[0].DataBoundItem as BankAccount;

                string message = selectedBankAccount.Withdraw(AccountAmount.Value);
                RefreshGrid();
                AccountAmount.Value = 0;
                MessageBox.Show(message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CreateAccount_Click(object sender, EventArgs e)
        {
            BankAccount bankAccount = new BankAccount(Accounttxt.Text);
            BankAccounts.Add(bankAccount);

            RefreshGrid();
        }

        private void CreateAccount_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Accounttxt.Text))
                return;

            BankAccount bankAccount = new BankAccount(Accounttxt.Text);
            BankAccounts.Add(bankAccount);

            RefreshGrid();
            Accounttxt.Text = string.Empty;

        }

        private void RefreshGrid()
        {
            AccountGrid.DataSource = null;
            AccountGrid.DataSource = BankAccounts;
        }

        private void AccountAmount_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
