using System;

namespace Register
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_max_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            ReturnTextBoxColors();

            if (FieldsEmpty())
            {
                MessageBox.Show("Please fill username and password.");
                HighlightEmptyField();
                return;
            }
            else if (IsOnlyUsernameFilled()) // Fill username and leave password.
            {
                MessageBox.Show("Please fill password.");
                HighlightPasswordField();
                return;
            }

            else if (IsOnlyPasswordFilled()) // Fill password and leave username.
            {
                MessageBox.Show("Please fill username.");
                HighlightUsernameField();
                return;
            }

            else if (IsPasswordInvalid()) // Ex: IT in Username and Management in Password.
            {
                MessageBox.Show("Password must be numbers only.");
                HighlightPasswordField();
                return;
            }
            else if (IsRegisterInvalid()) // Ex: IT , Password 2001
            {
                MessageBox.Show("Username and password incorrect.");
                return;
            }
        }

        private void ReturnTextBoxColors()
        {
            txtUsername.BackColor = Color.White;
            txtPassword.BackColor = Color.White;
        }

        private bool FieldsEmpty()
        {
            return string.IsNullOrWhiteSpace(txtUsername.Text) &&
                   string.IsNullOrWhiteSpace(txtPassword.Text);
        }

        private void HighlightEmptyField()
        {
            txtUsername.BackColor = Color.DarkRed;
            txtPassword.BackColor = Color.DarkRed;
        }

        private bool IsOnlyUsernameFilled()
        {
            bool isUsernameFilled = txtUsername.Text != "";
            bool isPasswordEmpty = txtPassword.Text == "";
            return isUsernameFilled && isPasswordEmpty;
        }

        private void HighlightPasswordField()
        {
            txtPassword.BackColor = Color.DarkRed;
        }

        private bool IsOnlyPasswordFilled()
        {
            bool isUsernameEmpty = txtUsername.Text == "";
            bool isPasswordFilled = txtPassword.Text != "";
            return isUsernameEmpty && isPasswordFilled;
        }

        private void HighlightUsernameField()
        {
            txtUsername.BackColor = Color.PaleVioletRed;
            txtPassword.BackColor = Color.White;
        }

        private bool IsPasswordInvalid()
        {
            bool isUsernameFilled = txtUsername.Text != "";
            bool isPasswordNotNumbers = !txtPassword.Text.All(char.IsDigit);
            return isUsernameFilled && isPasswordNotNumbers;
        }

        private bool IsRegisterInvalid()
        {
            bool isUsernameWrong = txtUsername.Text != "IT";
            bool isPasswordWrong = txtPassword.Text != "123";
            return isUsernameWrong || isPasswordWrong;
        }
    }
}