namespace Group1_Project1_Milestone1
{
    partial class Home
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGotoLogin = new System.Windows.Forms.Button();
            this.btnGotoRegister = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Group1_Project1_Milestone1.Properties.Resources.homepage;
            this.pictureBox1.Location = new System.Drawing.Point(-70, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(877, 469);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnGotoLogin
            // 
            this.btnGotoLogin.Location = new System.Drawing.Point(139, 333);
            this.btnGotoLogin.Name = "btnGotoLogin";
            this.btnGotoLogin.Size = new System.Drawing.Size(200, 38);
            this.btnGotoLogin.TabIndex = 1;
            this.btnGotoLogin.Text = "Login?";
            this.btnGotoLogin.UseVisualStyleBackColor = true;
            this.btnGotoLogin.Click += new System.EventHandler(this.btnGotoLogin_Click);
            // 
            // btnGotoRegister
            // 
            this.btnGotoRegister.Location = new System.Drawing.Point(460, 333);
            this.btnGotoRegister.Name = "btnGotoRegister";
            this.btnGotoRegister.Size = new System.Drawing.Size(200, 38);
            this.btnGotoRegister.TabIndex = 2;
            this.btnGotoRegister.Text = "Register?";
            this.btnGotoRegister.UseVisualStyleBackColor = true;
            this.btnGotoRegister.Click += new System.EventHandler(this.btnGotoRegister_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(139, 409);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(521, 30);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 463);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGotoRegister);
            this.Controls.Add(this.btnGotoLogin);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Home";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGotoLogin;
        private System.Windows.Forms.Button btnGotoRegister;
        private System.Windows.Forms.Button btnExit;
    }
}