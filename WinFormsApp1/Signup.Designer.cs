namespace WinFormsApp1
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.signupUserBox = new System.Windows.Forms.TextBox();
            this.signupPassBox = new System.Windows.Forms.TextBox();
            this.signupButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.toLoginButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(262, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(242, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Contraseña";
            // 
            // signupUserBox
            // 
            this.signupUserBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(24)))));
            this.signupUserBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.signupUserBox.ForeColor = System.Drawing.Color.White;
            this.signupUserBox.Location = new System.Drawing.Point(332, 168);
            this.signupUserBox.Name = "signupUserBox";
            this.signupUserBox.Size = new System.Drawing.Size(134, 16);
            this.signupUserBox.TabIndex = 1;
            this.signupUserBox.TextChanged += new System.EventHandler(this.signupUserBox_TextChanged);
            // 
            // signupPassBox
            // 
            this.signupPassBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(24)))));
            this.signupPassBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.signupPassBox.ForeColor = System.Drawing.Color.White;
            this.signupPassBox.Location = new System.Drawing.Point(332, 200);
            this.signupPassBox.Name = "signupPassBox";
            this.signupPassBox.PasswordChar = '*';
            this.signupPassBox.PlaceholderText = "12345678";
            this.signupPassBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.signupPassBox.Size = new System.Drawing.Size(134, 16);
            this.signupPassBox.TabIndex = 2;
            this.signupPassBox.TextChanged += new System.EventHandler(this.signupPassBox_TextChanged);
            // 
            // signupButton
            // 
            this.signupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(24)))));
            this.signupButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signupButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.signupButton.FlatAppearance.BorderSize = 2;
            this.signupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signupButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.signupButton.ForeColor = System.Drawing.Color.White;
            this.signupButton.Location = new System.Drawing.Point(332, 328);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(134, 27);
            this.signupButton.TabIndex = 4;
            this.signupButton.Text = "Sign Up";
            this.signupButton.UseVisualStyleBackColor = false;
            this.signupButton.Click += new System.EventHandler(this.signupButton_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(318, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "BIENVENIDO";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // toLoginButton
            // 
            this.toLoginButton.BackColor = System.Drawing.Color.Transparent;
            this.toLoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toLoginButton.FlatAppearance.BorderSize = 0;
            this.toLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toLoginButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toLoginButton.ForeColor = System.Drawing.Color.White;
            this.toLoginButton.Location = new System.Drawing.Point(275, 391);
            this.toLoginButton.Name = "toLoginButton";
            this.toLoginButton.Size = new System.Drawing.Size(249, 32);
            this.toLoginButton.TabIndex = 5;
            this.toLoginButton.Text = "Ya tengo un usuario";
            this.toLoginButton.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(332, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 2);
            this.label5.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(332, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 2);
            this.label7.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(24)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(332, 135);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 16);
            this.textBox1.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(333, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 2);
            this.label8.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(280, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 15);
            this.label9.TabIndex = 11;
            this.label9.Text = "DNI";
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.toLoginButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.signupButton);
            this.Controls.Add(this.signupPassBox);
            this.Controls.Add(this.signupUserBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Signup";
            this.Text = "Signup";
            this.Load += new System.EventHandler(this.Signup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox signupUserBox;
        private TextBox signupPassBox;
        private Button signupButton;
        private Label label3;
        private Button toLoginButton;
        private Label label5;
        private Label label7;
        private TextBox textBox1;
        private Label label8;
        private Label label9;
    }
}