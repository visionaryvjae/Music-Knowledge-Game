
namespace Group1_Project1_Milestone1
{
    partial class FrmGameSelect
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
            this.btnGuessGenre = new System.Windows.Forms.Button();
            this.BtnGuessArtist = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGuessGenre
            // 
            this.btnGuessGenre.BackColor = System.Drawing.Color.Red;
            this.btnGuessGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuessGenre.Location = new System.Drawing.Point(12, 74);
            this.btnGuessGenre.Name = "btnGuessGenre";
            this.btnGuessGenre.Size = new System.Drawing.Size(349, 65);
            this.btnGuessGenre.TabIndex = 0;
            this.btnGuessGenre.Text = "Guess the genre";
            this.btnGuessGenre.UseVisualStyleBackColor = false;
            this.btnGuessGenre.Click += new System.EventHandler(this.btnGuessGenre_Click);
            // 
            // BtnGuessArtist
            // 
            this.BtnGuessArtist.BackColor = System.Drawing.Color.LawnGreen;
            this.BtnGuessArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuessArtist.Location = new System.Drawing.Point(12, 145);
            this.BtnGuessArtist.Name = "BtnGuessArtist";
            this.BtnGuessArtist.Size = new System.Drawing.Size(349, 65);
            this.BtnGuessArtist.TabIndex = 1;
            this.BtnGuessArtist.Text = "Guess the Artist";
            this.BtnGuessArtist.UseVisualStyleBackColor = false;
            this.BtnGuessArtist.Click += new System.EventHandler(this.BtnGuessArtist_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select a Game Mode";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(348, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmGameSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(373, 250);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnGuessArtist);
            this.Controls.Add(this.btnGuessGenre);
            this.Name = "FrmGameSelect";
            this.Text = "Select a Game";
            this.Load += new System.EventHandler(this.FrmGameSelect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuessGenre;
        private System.Windows.Forms.Button BtnGuessArtist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}