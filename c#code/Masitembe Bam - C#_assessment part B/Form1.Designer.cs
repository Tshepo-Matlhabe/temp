namespace ConcatinateApp
{
    partial class Form1
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
            this.cB1stWord = new System.Windows.Forms.ComboBox();
            this.cB2ndWord = new System.Windows.Forms.ComboBox();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.rBremoveCB2 = new System.Windows.Forms.RadioButton();
            this.btnAddWord = new System.Windows.Forms.Button();
            this.rBremoveCB1 = new System.Windows.Forms.RadioButton();
            this.lblOR = new System.Windows.Forms.Label();
            this.lblSelectAword = new System.Windows.Forms.Label();
            this.btnConcatenate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEword = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblConcatenated_word = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cB1stWord
            // 
            this.cB1stWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB1stWord.FormattingEnabled = true;
            this.cB1stWord.Location = new System.Drawing.Point(6, 225);
            this.cB1stWord.Name = "cB1stWord";
            this.cB1stWord.Size = new System.Drawing.Size(224, 28);
            this.cB1stWord.TabIndex = 4;
            // 
            // cB2ndWord
            // 
            this.cB2ndWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB2ndWord.FormattingEnabled = true;
            this.cB2ndWord.Location = new System.Drawing.Point(327, 225);
            this.cB2ndWord.Name = "cB2ndWord";
            this.cB2ndWord.Size = new System.Drawing.Size(224, 28);
            this.cB2ndWord.TabIndex = 3;
            // 
            // txtWord
            // 
            this.txtWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWord.Location = new System.Drawing.Point(145, 41);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(258, 27);
            this.txtWord.TabIndex = 2;
            // 
            // rBremoveCB2
            // 
            this.rBremoveCB2.AutoSize = true;
            this.rBremoveCB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBremoveCB2.Location = new System.Drawing.Point(393, 259);
            this.rBremoveCB2.Name = "rBremoveCB2";
            this.rBremoveCB2.Size = new System.Drawing.Size(91, 24);
            this.rBremoveCB2.TabIndex = 5;
            this.rBremoveCB2.TabStop = true;
            this.rBremoveCB2.Text = "Remove";
            this.rBremoveCB2.UseVisualStyleBackColor = true;
            this.rBremoveCB2.CheckedChanged += new System.EventHandler(this.rBremoveCB2_CheckedChanged);
            // 
            // btnAddWord
            // 
            this.btnAddWord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddWord.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddWord.ForeColor = System.Drawing.SystemColors.Info;
            this.btnAddWord.Location = new System.Drawing.Point(217, 98);
            this.btnAddWord.Name = "btnAddWord";
            this.btnAddWord.Size = new System.Drawing.Size(110, 33);
            this.btnAddWord.TabIndex = 1;
            this.btnAddWord.Text = "Add word";
            this.btnAddWord.UseVisualStyleBackColor = true;
            this.btnAddWord.Click += new System.EventHandler(this.btnAddWord_Click);
            // 
            // rBremoveCB1
            // 
            this.rBremoveCB1.AutoSize = true;
            this.rBremoveCB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBremoveCB1.Location = new System.Drawing.Point(43, 259);
            this.rBremoveCB1.Name = "rBremoveCB1";
            this.rBremoveCB1.Size = new System.Drawing.Size(91, 24);
            this.rBremoveCB1.TabIndex = 6;
            this.rBremoveCB1.TabStop = true;
            this.rBremoveCB1.Text = "Remove";
            this.rBremoveCB1.UseVisualStyleBackColor = true;
            this.rBremoveCB1.CheckedChanged += new System.EventHandler(this.rBremoveCB1_CheckedChanged);
            // 
            // lblOR
            // 
            this.lblOR.AutoSize = true;
            this.lblOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOR.Location = new System.Drawing.Point(258, 163);
            this.lblOR.Name = "lblOR";
            this.lblOR.Size = new System.Drawing.Size(34, 20);
            this.lblOR.TabIndex = 9;
            this.lblOR.Text = "OR";
            // 
            // lblSelectAword
            // 
            this.lblSelectAword.AutoSize = true;
            this.lblSelectAword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectAword.Location = new System.Drawing.Point(350, 193);
            this.lblSelectAword.Name = "lblSelectAword";
            this.lblSelectAword.Size = new System.Drawing.Size(168, 20);
            this.lblSelectAword.TabIndex = 8;
            this.lblSelectAword.Text = "Select another word :";
            // 
            // btnConcatenate
            // 
            this.btnConcatenate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConcatenate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConcatenate.Location = new System.Drawing.Point(170, 295);
            this.btnConcatenate.Name = "btnConcatenate";
            this.btnConcatenate.Size = new System.Drawing.Size(242, 33);
            this.btnConcatenate.TabIndex = 0;
            this.btnConcatenate.Text = "Concatenate";
            this.btnConcatenate.UseVisualStyleBackColor = true;
            this.btnConcatenate.Click += new System.EventHandler(this.btnConcatenate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Select a word :";
            // 
            // lblEword
            // 
            this.lblEword.AutoSize = true;
            this.lblEword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEword.Location = new System.Drawing.Point(213, 18);
            this.lblEword.Name = "lblEword";
            this.lblEword.Size = new System.Drawing.Size(114, 20);
            this.lblEword.TabIndex = 7;
            this.lblEword.Text = "Enter a word :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.lblEword);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnConcatenate);
            this.groupBox1.Controls.Add(this.lblSelectAword);
            this.groupBox1.Controls.Add(this.lblOR);
            this.groupBox1.Controls.Add(this.rBremoveCB1);
            this.groupBox1.Controls.Add(this.btnAddWord);
            this.groupBox1.Controls.Add(this.rBremoveCB2);
            this.groupBox1.Controls.Add(this.txtWord);
            this.groupBox1.Controls.Add(this.cB2ndWord);
            this.groupBox1.Controls.Add(this.cB1stWord);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(586, 393);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblConcatenated_word
            // 
            this.lblConcatenated_word.AutoSize = true;
            this.lblConcatenated_word.BackColor = System.Drawing.Color.White;
            this.lblConcatenated_word.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(5)));
            this.lblConcatenated_word.Location = new System.Drawing.Point(237, 15);
            this.lblConcatenated_word.MaximumSize = new System.Drawing.Size(200, 200);
            this.lblConcatenated_word.Name = "lblConcatenated_word";
            this.lblConcatenated_word.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblConcatenated_word.Size = new System.Drawing.Size(59, 20);
            this.lblConcatenated_word.TabIndex = 11;
            this.lblConcatenated_word.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblConcatenated_word);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(6, 334);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 53);
            this.panel1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(620, 430);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Words";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cB1stWord;
        private System.Windows.Forms.ComboBox cB2ndWord;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.RadioButton rBremoveCB2;
        private System.Windows.Forms.Button btnAddWord;
        private System.Windows.Forms.RadioButton rBremoveCB1;
        private System.Windows.Forms.Label lblOR;
        private System.Windows.Forms.Label lblSelectAword;
        private System.Windows.Forms.Button btnConcatenate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblEword;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblConcatenated_word;
        private System.Windows.Forms.Panel panel1;
    }
}

