namespace latinTranslatorGI
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
            this.autemBtn = new System.Windows.Forms.Button();
            this.descenditBtn = new System.Windows.Forms.Button();
            this.mediumBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // autemBtn
            // 
            this.autemBtn.Location = new System.Drawing.Point(75, 204);
            this.autemBtn.Name = "autemBtn";
            this.autemBtn.Size = new System.Drawing.Size(75, 23);
            this.autemBtn.TabIndex = 0;
            this.autemBtn.Text = "autem";
            this.autemBtn.UseVisualStyleBackColor = true;
            this.autemBtn.Click += new System.EventHandler(this.autemBtn_Click);
            // 
            // descenditBtn
            // 
            this.descenditBtn.Location = new System.Drawing.Point(356, 204);
            this.descenditBtn.Name = "descenditBtn";
            this.descenditBtn.Size = new System.Drawing.Size(75, 23);
            this.descenditBtn.TabIndex = 1;
            this.descenditBtn.Text = "descendit";
            this.descenditBtn.UseVisualStyleBackColor = true;
            this.descenditBtn.Click += new System.EventHandler(this.descenditBtn_Click);
            // 
            // mediumBtn
            // 
            this.mediumBtn.Location = new System.Drawing.Point(642, 204);
            this.mediumBtn.Name = "mediumBtn";
            this.mediumBtn.Size = new System.Drawing.Size(75, 23);
            this.mediumBtn.TabIndex = 2;
            this.mediumBtn.Text = "medium";
            this.mediumBtn.UseVisualStyleBackColor = true;
            this.mediumBtn.Click += new System.EventHandler(this.mediumBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Click Latin Word for Translation";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mediumBtn);
            this.Controls.Add(this.descenditBtn);
            this.Controls.Add(this.autemBtn);
            this.Name = "Form1";
            this.Text = "Latin Translator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button autemBtn;
        private System.Windows.Forms.Button descenditBtn;
        private System.Windows.Forms.Button mediumBtn;
        private System.Windows.Forms.Label label1;
    }
}

