namespace Calculator
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
            this.Caculatorlbl = new System.Windows.Forms.Label();
            this.Number1lbl = new System.Windows.Forms.Label();
            this.Number2lbl = new System.Windows.Forms.Label();
            this.Message1lbl = new System.Windows.Forms.TextBox();
            this.additionbtn = new System.Windows.Forms.Button();
            this.subtractionbtn = new System.Windows.Forms.Button();
            this.multiplicationbtn = new System.Windows.Forms.Button();
            this.Message2txt = new System.Windows.Forms.TextBox();
            this.Resulttxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Dividebtn = new System.Windows.Forms.Button();
            this.Reminderbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Caculatorlbl
            // 
            this.Caculatorlbl.AutoSize = true;
            this.Caculatorlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Caculatorlbl.Location = new System.Drawing.Point(289, 20);
            this.Caculatorlbl.Name = "Caculatorlbl";
            this.Caculatorlbl.Size = new System.Drawing.Size(213, 24);
            this.Caculatorlbl.TabIndex = 0;
            this.Caculatorlbl.Text = "Calculator Application";
            this.Caculatorlbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Number1lbl
            // 
            this.Number1lbl.AutoSize = true;
            this.Number1lbl.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number1lbl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Number1lbl.Location = new System.Drawing.Point(70, 83);
            this.Number1lbl.Name = "Number1lbl";
            this.Number1lbl.Size = new System.Drawing.Size(76, 19);
            this.Number1lbl.TabIndex = 1;
            this.Number1lbl.Text = "Number 1";
            // 
            // Number2lbl
            // 
            this.Number2lbl.AutoSize = true;
            this.Number2lbl.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number2lbl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Number2lbl.Location = new System.Drawing.Point(454, 83);
            this.Number2lbl.Name = "Number2lbl";
            this.Number2lbl.Size = new System.Drawing.Size(76, 19);
            this.Number2lbl.TabIndex = 2;
            this.Number2lbl.Text = "Number 2";
            // 
            // Message1lbl
            // 
            this.Message1lbl.Location = new System.Drawing.Point(194, 82);
            this.Message1lbl.Name = "Message1lbl";
            this.Message1lbl.Size = new System.Drawing.Size(114, 20);
            this.Message1lbl.TabIndex = 3;
            // 
            // additionbtn
            // 
            this.additionbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.additionbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additionbtn.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.additionbtn.Location = new System.Drawing.Point(74, 200);
            this.additionbtn.Name = "additionbtn";
            this.additionbtn.Size = new System.Drawing.Size(106, 23);
            this.additionbtn.TabIndex = 4;
            this.additionbtn.Text = "Addition";
            this.additionbtn.UseVisualStyleBackColor = true;
            this.additionbtn.Click += new System.EventHandler(this.additionbtn_Click);
            // 
            // subtractionbtn
            // 
            this.subtractionbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.subtractionbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtractionbtn.Location = new System.Drawing.Point(202, 200);
            this.subtractionbtn.Name = "subtractionbtn";
            this.subtractionbtn.Size = new System.Drawing.Size(106, 23);
            this.subtractionbtn.TabIndex = 5;
            this.subtractionbtn.Text = "Subtraction";
            this.subtractionbtn.UseVisualStyleBackColor = true;
            this.subtractionbtn.Click += new System.EventHandler(this.subtractionbtn_Click);
            // 
            // multiplicationbtn
            // 
            this.multiplicationbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.multiplicationbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplicationbtn.Location = new System.Drawing.Point(458, 200);
            this.multiplicationbtn.Name = "multiplicationbtn";
            this.multiplicationbtn.Size = new System.Drawing.Size(106, 23);
            this.multiplicationbtn.TabIndex = 6;
            this.multiplicationbtn.Text = "Multiplication";
            this.multiplicationbtn.UseVisualStyleBackColor = true;
            this.multiplicationbtn.Click += new System.EventHandler(this.multiplicationbtn_Click);
            // 
            // Message2txt
            // 
            this.Message2txt.Location = new System.Drawing.Point(580, 82);
            this.Message2txt.Name = "Message2txt";
            this.Message2txt.Size = new System.Drawing.Size(114, 20);
            this.Message2txt.TabIndex = 7;
            // 
            // Resulttxt
            // 
            this.Resulttxt.Location = new System.Drawing.Point(368, 150);
            this.Resulttxt.Name = "Resulttxt";
            this.Resulttxt.Size = new System.Drawing.Size(114, 20);
            this.Resulttxt.TabIndex = 8;
            this.Resulttxt.TextChanged += new System.EventHandler(this.Resulttxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(269, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Result";
            // 
            // Dividebtn
            // 
            this.Dividebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dividebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dividebtn.Location = new System.Drawing.Point(588, 200);
            this.Dividebtn.Name = "Dividebtn";
            this.Dividebtn.Size = new System.Drawing.Size(106, 23);
            this.Dividebtn.TabIndex = 10;
            this.Dividebtn.Text = "Divide";
            this.Dividebtn.UseVisualStyleBackColor = true;
            this.Dividebtn.Click += new System.EventHandler(this.Dividebtn_Click);
            // 
            // Reminderbtn
            // 
            this.Reminderbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reminderbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reminderbtn.Location = new System.Drawing.Point(325, 200);
            this.Reminderbtn.Name = "Reminderbtn";
            this.Reminderbtn.Size = new System.Drawing.Size(106, 23);
            this.Reminderbtn.TabIndex = 11;
            this.Reminderbtn.Text = "Reminder ";
            this.Reminderbtn.UseVisualStyleBackColor = true;
            this.Reminderbtn.Click += new System.EventHandler(this.Reminderbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Reminderbtn);
            this.Controls.Add(this.Dividebtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Resulttxt);
            this.Controls.Add(this.Message2txt);
            this.Controls.Add(this.multiplicationbtn);
            this.Controls.Add(this.subtractionbtn);
            this.Controls.Add(this.additionbtn);
            this.Controls.Add(this.Message1lbl);
            this.Controls.Add(this.Number2lbl);
            this.Controls.Add(this.Number1lbl);
            this.Controls.Add(this.Caculatorlbl);
            this.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Caculatorlbl;
        private System.Windows.Forms.Label Number1lbl;
        private System.Windows.Forms.Label Number2lbl;
        private System.Windows.Forms.TextBox Message1lbl;
        private System.Windows.Forms.Button additionbtn;
        private System.Windows.Forms.Button subtractionbtn;
        private System.Windows.Forms.Button multiplicationbtn;
        private System.Windows.Forms.TextBox Message2txt;
        private System.Windows.Forms.TextBox Resulttxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Dividebtn;
        private System.Windows.Forms.Button Reminderbtn;
    }
}

