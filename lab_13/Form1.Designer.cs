namespace lab_13
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
            this.namelab = new System.Windows.Forms.Label();
            this.reglab = new System.Windows.Forms.Label();
            this.emaillab = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.regtxt = new System.Windows.Forms.TextBox();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.updatebtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.selectbtn = new System.Windows.Forms.Button();
            this.idlab = new System.Windows.Forms.Label();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // namelab
            // 
            this.namelab.AutoSize = true;
            this.namelab.Location = new System.Drawing.Point(37, 40);
            this.namelab.Name = "namelab";
            this.namelab.Size = new System.Drawing.Size(35, 13);
            this.namelab.TabIndex = 0;
            this.namelab.Text = "Name";
            // 
            // reglab
            // 
            this.reglab.AutoSize = true;
            this.reglab.Location = new System.Drawing.Point(37, 80);
            this.reglab.Name = "reglab";
            this.reglab.Size = new System.Drawing.Size(77, 13);
            this.reglab.TabIndex = 1;
            this.reglab.Text = "Registration ID";
            // 
            // emaillab
            // 
            this.emaillab.AutoSize = true;
            this.emaillab.Location = new System.Drawing.Point(37, 123);
            this.emaillab.Name = "emaillab";
            this.emaillab.Size = new System.Drawing.Size(32, 13);
            this.emaillab.TabIndex = 2;
            this.emaillab.Text = "Email";
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(135, 37);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(100, 20);
            this.nametxt.TabIndex = 3;
            // 
            // regtxt
            // 
            this.regtxt.Location = new System.Drawing.Point(135, 77);
            this.regtxt.Name = "regtxt";
            this.regtxt.Size = new System.Drawing.Size(100, 20);
            this.regtxt.TabIndex = 4;
            // 
            // emailtxt
            // 
            this.emailtxt.Location = new System.Drawing.Point(135, 120);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(100, 20);
            this.emailtxt.TabIndex = 5;
            // 
            // updatebtn
            // 
            this.updatebtn.Location = new System.Drawing.Point(40, 209);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(75, 23);
            this.updatebtn.TabIndex = 6;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(135, 209);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(75, 23);
            this.addbtn.TabIndex = 7;
            this.addbtn.Text = "Add";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Location = new System.Drawing.Point(233, 208);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(75, 23);
            this.deletebtn.TabIndex = 8;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // selectbtn
            // 
            this.selectbtn.Location = new System.Drawing.Point(331, 209);
            this.selectbtn.Name = "selectbtn";
            this.selectbtn.Size = new System.Drawing.Size(75, 23);
            this.selectbtn.TabIndex = 9;
            this.selectbtn.Text = "Select";
            this.selectbtn.UseVisualStyleBackColor = true;
            this.selectbtn.Click += new System.EventHandler(this.selectbtn_Click);
            // 
            // idlab
            // 
            this.idlab.AutoSize = true;
            this.idlab.Location = new System.Drawing.Point(40, 160);
            this.idlab.Name = "idlab";
            this.idlab.Size = new System.Drawing.Size(18, 13);
            this.idlab.TabIndex = 10;
            this.idlab.Text = "ID";
            // 
            // idtxt
            // 
            this.idtxt.Location = new System.Drawing.Point(135, 160);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(100, 20);
            this.idtxt.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.idlab);
            this.Controls.Add(this.selectbtn);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.emailtxt);
            this.Controls.Add(this.regtxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.emaillab);
            this.Controls.Add(this.reglab);
            this.Controls.Add(this.namelab);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label namelab;
        private System.Windows.Forms.Label reglab;
        private System.Windows.Forms.Label emaillab;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox regtxt;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button selectbtn;
        private System.Windows.Forms.Label idlab;
        private System.Windows.Forms.TextBox idtxt;
    }
}

