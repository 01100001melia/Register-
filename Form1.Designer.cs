namespace Register
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
            lblUsername = new Label();
            lblPassword = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnRegister = new Button();
            btn_close = new Button();
            btn_max = new Button();
            btn_min = new Button();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe Script", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(94, 119);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(111, 30);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe Script", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(98, 169);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(107, 30);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.PaleVioletRed;
            txtUsername.Location = new Point(224, 126);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(129, 23);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.Pink;
            txtPassword.Location = new Point(224, 176);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '$';
            txtPassword.Size = new Size(129, 23);
            txtPassword.TabIndex = 3;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(224, 224, 224);
            btnRegister.Font = new Font("NSimSun", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(188, 264);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(75, 23);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btn_close
            // 
            btn_close.BackColor = Color.FromArgb(224, 224, 224);
            btn_close.ForeColor = Color.Red;
            btn_close.Location = new Point(429, 0);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(29, 23);
            btn_close.TabIndex = 5;
            btn_close.Text = "X";
            btn_close.UseVisualStyleBackColor = false;
            btn_close.Click += btn_close_Click;
            // 
            // btn_max
            // 
            btn_max.BackColor = Color.FromArgb(224, 224, 224);
            btn_max.ForeColor = Color.Black;
            btn_max.Location = new Point(394, 0);
            btn_max.Name = "btn_max";
            btn_max.Size = new Size(29, 23);
            btn_max.TabIndex = 6;
            btn_max.Text = "[]";
            btn_max.UseVisualStyleBackColor = false;
            btn_max.Click += btn_max_Click;
            // 
            // btn_min
            // 
            btn_min.BackColor = Color.FromArgb(224, 224, 224);
            btn_min.ForeColor = Color.Black;
            btn_min.Location = new Point(359, 0);
            btn_min.Name = "btn_min";
            btn_min.Size = new Size(29, 23);
            btn_min.TabIndex = 7;
            btn_min.Text = "-";
            btn_min.UseVisualStyleBackColor = false;
            btn_min.Click += btn_min_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(459, 364);
            ControlBox = false;
            Controls.Add(btn_min);
            Controls.Add(btn_max);
            Controls.Add(btn_close);
            Controls.Add(btnRegister);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnRegister;
        private Button btn_close;
        private Button btn_max;
        private Button btn_min;
    }
}
