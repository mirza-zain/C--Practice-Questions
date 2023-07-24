namespace lab_11B
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.calculatebtn = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.discountAmtxt = new System.Windows.Forms.TextBox();
            this.totaltxt = new System.Windows.Forms.TextBox();
            this.discounttxt = new System.Windows.Forms.TextBox();
            this.subtotaltxt = new System.Windows.Forms.TextBox();
            this.ptotaltxt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(389, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dear Customer You Have To Pay";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(390, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sub Total";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(390, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Discount (%)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(390, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Discount Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(390, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(389, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(304, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Billing System Calculator";
            // 
            // calculatebtn
            // 
            this.calculatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatebtn.Location = new System.Drawing.Point(407, 253);
            this.calculatebtn.Name = "calculatebtn";
            this.calculatebtn.Size = new System.Drawing.Size(98, 34);
            this.calculatebtn.TabIndex = 6;
            this.calculatebtn.Text = "Calculate";
            this.calculatebtn.UseVisualStyleBackColor = true;
            this.calculatebtn.Click += new System.EventHandler(this.calculatebtn_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbtn.Location = new System.Drawing.Point(610, 260);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(98, 34);
            this.exitbtn.TabIndex = 7;
            this.exitbtn.Text = "Exit";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // discountAmtxt
            // 
            this.discountAmtxt.Location = new System.Drawing.Point(608, 166);
            this.discountAmtxt.Name = "discountAmtxt";
            this.discountAmtxt.Size = new System.Drawing.Size(100, 20);
            this.discountAmtxt.TabIndex = 8;
            this.discountAmtxt.TextChanged += new System.EventHandler(this.discountAmtxt_TextChanged);
            // 
            // totaltxt
            // 
            this.totaltxt.Location = new System.Drawing.Point(608, 213);
            this.totaltxt.Name = "totaltxt";
            this.totaltxt.Size = new System.Drawing.Size(100, 20);
            this.totaltxt.TabIndex = 9;
            this.totaltxt.TextChanged += new System.EventHandler(this.totaltxt_TextChanged);
            // 
            // discounttxt
            // 
            this.discounttxt.Location = new System.Drawing.Point(608, 117);
            this.discounttxt.Name = "discounttxt";
            this.discounttxt.Size = new System.Drawing.Size(100, 20);
            this.discounttxt.TabIndex = 10;
            this.discounttxt.TextChanged += new System.EventHandler(this.discounttxt_TextChanged);
            // 
            // subtotaltxt
            // 
            this.subtotaltxt.Location = new System.Drawing.Point(608, 73);
            this.subtotaltxt.Name = "subtotaltxt";
            this.subtotaltxt.Size = new System.Drawing.Size(100, 20);
            this.subtotaltxt.TabIndex = 11;
            this.subtotaltxt.TextChanged += new System.EventHandler(this.subtotaltxt_TextChanged);
            // 
            // ptotaltxt
            // 
            this.ptotaltxt.Location = new System.Drawing.Point(694, 305);
            this.ptotaltxt.Name = "ptotaltxt";
            this.ptotaltxt.Size = new System.Drawing.Size(100, 20);
            this.ptotaltxt.TabIndex = 12;
            this.ptotaltxt.TextChanged += new System.EventHandler(this.ptotaltxt_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::lab_11B.Properties.Resources.Screenshot_2023_06_09_001826;
            this.pictureBox1.Location = new System.Drawing.Point(-122, -56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(505, 432);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ptotaltxt);
            this.Controls.Add(this.subtotaltxt);
            this.Controls.Add(this.discounttxt);
            this.Controls.Add(this.totaltxt);
            this.Controls.Add(this.discountAmtxt);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.calculatebtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button calculatebtn;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.TextBox discountAmtxt;
        private System.Windows.Forms.TextBox totaltxt;
        private System.Windows.Forms.TextBox discounttxt;
        private System.Windows.Forms.TextBox subtotaltxt;
        private System.Windows.Forms.TextBox ptotaltxt;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

