namespace RockPaperScissor
{
    partial class RockPaperScissor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RockPaperScissor));
            this.btnRock = new System.Windows.Forms.Button();
            this.btnScissor = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.pictureBoxHuman = new System.Windows.Forms.PictureBox();
            this.pictureBoxCom = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblScoreHuman = new System.Windows.Forms.Label();
            this.LblScoreCom = new System.Windows.Forms.Label();
            this.lblWin = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHuman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCom)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRock
            // 
            this.btnRock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRock.Location = new System.Drawing.Point(22, 77);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(138, 53);
            this.btnRock.TabIndex = 0;
            this.btnRock.Text = "Rock";
            this.btnRock.UseVisualStyleBackColor = true;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // btnScissor
            // 
            this.btnScissor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnScissor.Location = new System.Drawing.Point(461, 77);
            this.btnScissor.Name = "btnScissor";
            this.btnScissor.Size = new System.Drawing.Size(128, 53);
            this.btnScissor.TabIndex = 1;
            this.btnScissor.Text = "Scissor";
            this.btnScissor.UseVisualStyleBackColor = true;
            this.btnScissor.Click += new System.EventHandler(this.btnScissor_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPaper.Location = new System.Drawing.Point(250, 77);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(129, 53);
            this.btnPaper.TabIndex = 2;
            this.btnPaper.Text = "Paper";
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // pictureBoxHuman
            // 
            this.pictureBoxHuman.Image = global::RockPaperScissor.Properties.Resources.scissor;
            this.pictureBoxHuman.Location = new System.Drawing.Point(12, 157);
            this.pictureBoxHuman.Name = "pictureBoxHuman";
            this.pictureBoxHuman.Size = new System.Drawing.Size(174, 138);
            this.pictureBoxHuman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHuman.TabIndex = 3;
            this.pictureBoxHuman.TabStop = false;
            // 
            // pictureBoxCom
            // 
            this.pictureBoxCom.Image = global::RockPaperScissor.Properties.Resources.paper;
            this.pictureBoxCom.Location = new System.Drawing.Point(417, 157);
            this.pictureBoxCom.Name = "pictureBoxCom";
            this.pictureBoxCom.Size = new System.Drawing.Size(172, 138);
            this.pictureBoxCom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCom.TabIndex = 4;
            this.pictureBoxCom.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(234, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 91);
            this.label1.TabIndex = 5;
            this.label1.Text = "VS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(20, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Human";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(439, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Computer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(17, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Score";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(440, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Score";
            // 
            // lblScoreHuman
            // 
            this.lblScoreHuman.AutoSize = true;
            this.lblScoreHuman.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblScoreHuman.Location = new System.Drawing.Point(96, 324);
            this.lblScoreHuman.Name = "lblScoreHuman";
            this.lblScoreHuman.Size = new System.Drawing.Size(26, 29);
            this.lblScoreHuman.TabIndex = 10;
            this.lblScoreHuman.Text = "0";
            // 
            // LblScoreCom
            // 
            this.LblScoreCom.AutoSize = true;
            this.LblScoreCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblScoreCom.Location = new System.Drawing.Point(523, 324);
            this.LblScoreCom.Name = "LblScoreCom";
            this.LblScoreCom.Size = new System.Drawing.Size(26, 29);
            this.LblScoreCom.TabIndex = 11;
            this.LblScoreCom.Text = "0";
            // 
            // lblWin
            // 
            this.lblWin.AutoSize = true;
            this.lblWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWin.Location = new System.Drawing.Point(244, 324);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(135, 29);
            this.lblWin.TabIndex = 12;
            this.lblWin.Text = "Who wins ?";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReset.Location = new System.Drawing.Point(249, 366);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(129, 36);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // RockPaperScissor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 450);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblWin);
            this.Controls.Add(this.LblScoreCom);
            this.Controls.Add(this.lblScoreHuman);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxCom);
            this.Controls.Add(this.pictureBoxHuman);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnScissor);
            this.Controls.Add(this.btnRock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RockPaperScissor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RockPaperScissor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHuman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnScissor;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.PictureBox pictureBoxHuman;
        private System.Windows.Forms.PictureBox pictureBoxCom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblScoreHuman;
        private System.Windows.Forms.Label LblScoreCom;
        private System.Windows.Forms.Label lblWin;
        private System.Windows.Forms.Button btnReset;
    }
}

