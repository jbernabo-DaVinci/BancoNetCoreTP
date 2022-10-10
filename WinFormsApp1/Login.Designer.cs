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
            this.loginUserBox = new System.Windows.Forms.TextBox();
            this.loginPassBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.toSignupButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
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
            // loginUserBox
            // 
            this.loginUserBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(24)))));
            this.loginUserBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginUserBox.ForeColor = System.Drawing.Color.Black;
            this.loginUserBox.Location = new System.Drawing.Point(332, 134);
            this.loginUserBox.Name = "loginUserBox";
            this.loginUserBox.Size = new System.Drawing.Size(134, 16);
            this.loginUserBox.TabIndex = 3;
            // 
            // loginPassBox
            // 
            this.loginPassBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(24)))));
            this.loginPassBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginPassBox.Location = new System.Drawing.Point(332, 176);
            this.loginPassBox.Name = "loginPassBox";
            this.loginPassBox.Size = new System.Drawing.Size(134, 16);
            this.loginPassBox.TabIndex = 4;
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
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WinFormsApp1.Properties.Resources.usuario;
            this.pictureBox1.Location = new System.Drawing.Point(284, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
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
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(332, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 2);
            this.label1.TabIndex = 10;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toSignupButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.loginPassBox);
            this.Controls.Add(this.loginUserBox);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label3;
        private TextBox loginUserBox;
        private TextBox loginPassBox;
        private Button loginButton;
        private Button toSignupButton;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label7;
        private Label label1;
    }
}