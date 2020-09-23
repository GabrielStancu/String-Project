namespace String_Project
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btReverse = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btPigLatin = new System.Windows.Forms.Button();
            this.btVowels = new System.Windows.Forms.Button();
            this.btPalindrom = new System.Windows.Forms.Button();
            this.btWords = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(656, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insert your text in the textbox below:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtInput.Location = new System.Drawing.Point(30, 68);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(651, 34);
            this.txtInput.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(26, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(655, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Now choose one of the following options:\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btReverse
            // 
            this.btReverse.BackColor = System.Drawing.Color.Red;
            this.btReverse.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btReverse.Location = new System.Drawing.Point(30, 168);
            this.btReverse.Name = "btReverse";
            this.btReverse.Size = new System.Drawing.Size(120, 47);
            this.btReverse.TabIndex = 3;
            this.btReverse.Text = "Reverse String";
            this.btReverse.UseVisualStyleBackColor = false;
            this.btReverse.Click += new System.EventHandler(this.btReverse_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(26, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(655, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Result:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtOutput
            // 
            this.txtOutput.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtOutput.Location = new System.Drawing.Point(30, 258);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(651, 34);
            this.txtOutput.TabIndex = 6;
            // 
            // btPigLatin
            // 
            this.btPigLatin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btPigLatin.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btPigLatin.Location = new System.Drawing.Point(161, 168);
            this.btPigLatin.Name = "btPigLatin";
            this.btPigLatin.Size = new System.Drawing.Size(120, 47);
            this.btPigLatin.TabIndex = 7;
            this.btPigLatin.Text = "Pig Latin";
            this.btPigLatin.UseVisualStyleBackColor = false;
            this.btPigLatin.Click += new System.EventHandler(this.btPigLatin_Click);
            // 
            // btVowels
            // 
            this.btVowels.BackColor = System.Drawing.Color.Yellow;
            this.btVowels.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btVowels.Location = new System.Drawing.Point(293, 168);
            this.btVowels.Name = "btVowels";
            this.btVowels.Size = new System.Drawing.Size(120, 47);
            this.btVowels.TabIndex = 8;
            this.btVowels.Text = "Vowels";
            this.btVowels.UseVisualStyleBackColor = false;
            this.btVowels.Click += new System.EventHandler(this.btVowels_Click);
            // 
            // btPalindrom
            // 
            this.btPalindrom.BackColor = System.Drawing.Color.Lime;
            this.btPalindrom.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btPalindrom.Location = new System.Drawing.Point(426, 168);
            this.btPalindrom.Name = "btPalindrom";
            this.btPalindrom.Size = new System.Drawing.Size(120, 47);
            this.btPalindrom.TabIndex = 9;
            this.btPalindrom.Text = "Palindrome";
            this.btPalindrom.UseVisualStyleBackColor = false;
            this.btPalindrom.Click += new System.EventHandler(this.btPalindrom_Click);
            // 
            // btWords
            // 
            this.btWords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btWords.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btWords.Location = new System.Drawing.Point(561, 168);
            this.btWords.Name = "btWords";
            this.btWords.Size = new System.Drawing.Size(120, 47);
            this.btWords.TabIndex = 10;
            this.btWords.Text = "Words Counter";
            this.btWords.UseVisualStyleBackColor = false;
            this.btWords.Click += new System.EventHandler(this.btWords_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(706, 304);
            this.Controls.Add(this.btWords);
            this.Controls.Add(this.btPalindrom);
            this.Controls.Add(this.btVowels);
            this.Controls.Add(this.btPigLatin);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btReverse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "String Player";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btReverse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btPigLatin;
        private System.Windows.Forms.Button btVowels;
        private System.Windows.Forms.Button btPalindrom;
        private System.Windows.Forms.Button btWords;
    }
}

