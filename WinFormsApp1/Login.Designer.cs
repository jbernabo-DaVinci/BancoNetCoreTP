namespace WinFormsApp1
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label3 = new System.Windows.Forms.Label();
            this.loginPassBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.toSignupButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.showEye = new System.Windows.Forms.PictureBox();
            this.hideEye = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.loginDNIBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showEye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hideEye)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(318, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "BIENVENIDO";
            // 
            // loginPassBox
            // 
            this.loginPassBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(24)))));
            this.loginPassBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginPassBox.Location = new System.Drawing.Point(332, 176);
            this.loginPassBox.Name = "loginPassBox";
            this.loginPassBox.Size = new System.Drawing.Size(134, 16);
            this.loginPassBox.TabIndex = 4;
            this.loginPassBox.UseSystemPasswordChar = true;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Transparent;
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.loginButton.FlatAppearance.BorderSize = 2;
            this.loginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.loginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(332, 260);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(134, 27);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Log In";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // toSignupButton
            // 
            this.toSignupButton.BackColor = System.Drawing.Color.Transparent;
            this.toSignupButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toSignupButton.FlatAppearance.BorderSize = 0;
            this.toSignupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toSignupButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toSignupButton.ForeColor = System.Drawing.Color.White;
            this.toSignupButton.Location = new System.Drawing.Point(272, 363);
            this.toSignupButton.Name = "toSignupButton";
            this.toSignupButton.Size = new System.Drawing.Size(240, 36);
            this.toSignupButton.TabIndex = 6;
            this.toSignupButton.Text = "Crear un nuevo usuario";
            this.toSignupButton.UseVisualStyleBackColor = false;
            this.toSignupButton.Click += new System.EventHandler(this.goToSignUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::WinFormsApp1.Properties.Resources.user_add;
            this.pictureBox2.Location = new System.Drawing.Point(386, 332);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.goToSignUp);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::WinFormsApp1.Properties.Resources.llave;
            this.pictureBox3.Location = new System.Drawing.Point(284, 169);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(332, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 2);
            this.label7.TabIndex = 9;
            // 
            // showEye
            // 
            this.showEye.BackColor = System.Drawing.Color.Transparent;
            this.showEye.Image = global::WinFormsApp1.Properties.Resources.ojo__1_;
            this.showEye.Location = new System.Drawing.Point(472, 174);
            this.showEye.Name = "showEye";
            this.showEye.Size = new System.Drawing.Size(20, 20);
            this.showEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.showEye.TabIndex = 11;
            this.showEye.TabStop = false;
            this.showEye.Click += new System.EventHandler(this.showEye_Click);
            // 
            // hideEye
            // 
            this.hideEye.BackColor = System.Drawing.Color.Transparent;
            this.hideEye.Image = global::WinFormsApp1.Properties.Resources.ojos_cruzados;
            this.hideEye.Location = new System.Drawing.Point(472, 174);
            this.hideEye.Name = "hideEye";
            this.hideEye.Size = new System.Drawing.Size(20, 20);
            this.hideEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hideEye.TabIndex = 12;
            this.hideEye.TabStop = false;
            this.hideEye.Click += new System.EventHandler(this.hideEye_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(280, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "DNI";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(333, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 2);
            this.label8.TabIndex = 14;
            // 
            // loginDNIBox
            // 
            this.loginDNIBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(24)))));
            this.loginDNIBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginDNIBox.ForeColor = System.Drawing.Color.White;
            this.loginDNIBox.Location = new System.Drawing.Point(332, 128);
            this.loginDNIBox.Name = "loginDNIBox";
            this.loginDNIBox.Size = new System.Drawing.Size(134, 16);
            this.loginDNIBox.TabIndex = 13;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.loginDNIBox);
            this.Controls.Add(this.hideEye);
            this.Controls.Add(this.showEye);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.toSignupButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.loginPassBox);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showEye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hideEye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label3;
        private TextBox loginPassBox;
        private Button loginButton;
        private Button toSignupButton;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label7;
        private PictureBox showEye;
        private PictureBox hideEye;
        private Label label9;
        private Label label8;
        private TextBox loginDNIBox;
    }
}