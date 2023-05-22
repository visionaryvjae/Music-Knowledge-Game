
namespace Group1_Project1_Milestone1
{
    partial class FrmGameGenre
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnGenreQuit = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnGenreAnswer = new System.Windows.Forms.Button();
            this.rbOption4 = new System.Windows.Forms.RadioButton();
            this.rbOption3 = new System.Windows.Forms.RadioButton();
            this.rbOption2 = new System.Windows.Forms.RadioButton();
            this.rbOption1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPlayername = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblQuestion);
            this.panel1.Location = new System.Drawing.Point(16, 113);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 92);
            this.panel1.TabIndex = 0;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(4, 32);
            this.lblQuestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(506, 24);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Placeholder for question. Panel changes colour on answer ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnStart);
            this.panel2.Controls.Add(this.btnGenreQuit);
            this.panel2.Controls.Add(this.lblTimer);
            this.panel2.Controls.Add(this.lblScore);
            this.panel2.Controls.Add(this.btnGenreAnswer);
            this.panel2.Controls.Add(this.rbOption4);
            this.panel2.Controls.Add(this.rbOption3);
            this.panel2.Controls.Add(this.rbOption2);
            this.panel2.Controls.Add(this.rbOption1);
            this.panel2.Location = new System.Drawing.Point(16, 245);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(549, 294);
            this.panel2.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(259, 251);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(117, 28);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnGenreQuit
            // 
            this.btnGenreQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenreQuit.Location = new System.Drawing.Point(133, 251);
            this.btnGenreQuit.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenreQuit.Name = "btnGenreQuit";
            this.btnGenreQuit.Size = new System.Drawing.Size(117, 28);
            this.btnGenreQuit.TabIndex = 8;
            this.btnGenreQuit.Text = "Quit";
            this.btnGenreQuit.UseVisualStyleBackColor = true;
            this.btnGenreQuit.Click += new System.EventHandler(this.btnGenreQuit_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(17, 191);
            this.lblTimer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(158, 34);
            this.lblTimer.TabIndex = 6;
            this.lblTimer.Text = "Timer: 60";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(384, 247);
            this.lblScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(107, 29);
            this.lblScore.TabIndex = 5;
            this.lblScore.Text = "Score: ";
            // 
            // btnGenreAnswer
            // 
            this.btnGenreAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenreAnswer.Location = new System.Drawing.Point(8, 251);
            this.btnGenreAnswer.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenreAnswer.Name = "btnGenreAnswer";
            this.btnGenreAnswer.Size = new System.Drawing.Size(117, 28);
            this.btnGenreAnswer.TabIndex = 4;
            this.btnGenreAnswer.Text = "Submit";
            this.btnGenreAnswer.UseVisualStyleBackColor = true;
            this.btnGenreAnswer.Visible = false;
            this.btnGenreAnswer.Click += new System.EventHandler(this.btnGenreAnswer_Click);
            // 
            // rbOption4
            // 
            this.rbOption4.AutoSize = true;
            this.rbOption4.BackColor = System.Drawing.Color.Transparent;
            this.rbOption4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOption4.Location = new System.Drawing.Point(21, 114);
            this.rbOption4.Margin = new System.Windows.Forms.Padding(4);
            this.rbOption4.Name = "rbOption4";
            this.rbOption4.Size = new System.Drawing.Size(106, 30);
            this.rbOption4.TabIndex = 3;
            this.rbOption4.TabStop = true;
            this.rbOption4.Text = "Option";
            this.rbOption4.UseVisualStyleBackColor = false;
            this.rbOption4.CheckedChanged += new System.EventHandler(this.rbOption4_CheckedChanged);
            // 
            // rbOption3
            // 
            this.rbOption3.AutoSize = true;
            this.rbOption3.BackColor = System.Drawing.Color.Transparent;
            this.rbOption3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOption3.Location = new System.Drawing.Point(21, 78);
            this.rbOption3.Margin = new System.Windows.Forms.Padding(4);
            this.rbOption3.Name = "rbOption3";
            this.rbOption3.Size = new System.Drawing.Size(106, 30);
            this.rbOption3.TabIndex = 2;
            this.rbOption3.TabStop = true;
            this.rbOption3.Text = "Option";
            this.rbOption3.UseVisualStyleBackColor = false;
            this.rbOption3.CheckedChanged += new System.EventHandler(this.rbOption3_CheckedChanged);
            // 
            // rbOption2
            // 
            this.rbOption2.AutoSize = true;
            this.rbOption2.BackColor = System.Drawing.Color.Transparent;
            this.rbOption2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOption2.Location = new System.Drawing.Point(21, 41);
            this.rbOption2.Margin = new System.Windows.Forms.Padding(4);
            this.rbOption2.Name = "rbOption2";
            this.rbOption2.Size = new System.Drawing.Size(106, 30);
            this.rbOption2.TabIndex = 1;
            this.rbOption2.TabStop = true;
            this.rbOption2.Text = "Option";
            this.rbOption2.UseVisualStyleBackColor = false;
            this.rbOption2.CheckedChanged += new System.EventHandler(this.rbOption2_CheckedChanged);
            // 
            // rbOption1
            // 
            this.rbOption1.AutoSize = true;
            this.rbOption1.BackColor = System.Drawing.Color.Transparent;
            this.rbOption1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOption1.Location = new System.Drawing.Point(21, 4);
            this.rbOption1.Margin = new System.Windows.Forms.Padding(4);
            this.rbOption1.Name = "rbOption1";
            this.rbOption1.Size = new System.Drawing.Size(106, 30);
            this.rbOption1.TabIndex = 0;
            this.rbOption1.TabStop = true;
            this.rbOption1.Text = "Option";
            this.rbOption1.UseVisualStyleBackColor = false;
            this.rbOption1.CheckedChanged += new System.EventHandler(this.rbOption1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(141, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Guess The Genre";
            // 
            // lblPlayername
            // 
            this.lblPlayername.AutoSize = true;
            this.lblPlayername.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayername.ForeColor = System.Drawing.Color.White;
            this.lblPlayername.Location = new System.Drawing.Point(171, 68);
            this.lblPlayername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayername.Name = "lblPlayername";
            this.lblPlayername.Size = new System.Drawing.Size(244, 29);
            this.lblPlayername.TabIndex = 3;
            this.lblPlayername.Text = "Player Name Space";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // FrmGameGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(583, 554);
            this.Controls.Add(this.lblPlayername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmGameGenre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Genre Game";
            this.Load += new System.EventHandler(this.FrmGameGenre_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnGenreAnswer;
        private System.Windows.Forms.RadioButton rbOption4;
        private System.Windows.Forms.RadioButton rbOption3;
        private System.Windows.Forms.RadioButton rbOption2;
        private System.Windows.Forms.RadioButton rbOption1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPlayername;
        private System.Windows.Forms.Button btnGenreQuit;
        private System.Windows.Forms.Button btnStart;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}