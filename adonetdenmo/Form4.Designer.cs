namespace adonetdenmo
{
    partial class Form4
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
            this.btnupdate = new System.Windows.Forms.Button();
            this.cbbdeptno = new System.Windows.Forms.ComboBox();
            this.txtcommission = new System.Windows.Forms.TextBox();
            this.txtsal = new System.Windows.Forms.TextBox();
            this.dpthiredate = new System.Windows.Forms.DateTimePicker();
            this.txtmgr = new System.Windows.Forms.TextBox();
            this.txtjob = new System.Windows.Forms.TextBox();
            this.txtename = new System.Windows.Forms.TextBox();
            this.txtempno = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(363, 390);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 33;
            this.btnupdate.Text = "update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // cbbdeptno
            // 
            this.cbbdeptno.FormattingEnabled = true;
            this.cbbdeptno.Location = new System.Drawing.Point(425, 321);
            this.cbbdeptno.Name = "cbbdeptno";
            this.cbbdeptno.Size = new System.Drawing.Size(121, 21);
            this.cbbdeptno.TabIndex = 32;
            // 
            // txtcommission
            // 
            this.txtcommission.Location = new System.Drawing.Point(425, 282);
            this.txtcommission.Name = "txtcommission";
            this.txtcommission.Size = new System.Drawing.Size(100, 20);
            this.txtcommission.TabIndex = 31;
            // 
            // txtsal
            // 
            this.txtsal.Location = new System.Drawing.Point(425, 246);
            this.txtsal.Name = "txtsal";
            this.txtsal.Size = new System.Drawing.Size(100, 20);
            this.txtsal.TabIndex = 30;
            // 
            // dpthiredate
            // 
            this.dpthiredate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpthiredate.Location = new System.Drawing.Point(425, 208);
            this.dpthiredate.Name = "dpthiredate";
            this.dpthiredate.Size = new System.Drawing.Size(121, 20);
            this.dpthiredate.TabIndex = 29;
            // 
            // txtmgr
            // 
            this.txtmgr.Location = new System.Drawing.Point(425, 162);
            this.txtmgr.Name = "txtmgr";
            this.txtmgr.Size = new System.Drawing.Size(100, 20);
            this.txtmgr.TabIndex = 28;
            // 
            // txtjob
            // 
            this.txtjob.Location = new System.Drawing.Point(425, 121);
            this.txtjob.Name = "txtjob";
            this.txtjob.Size = new System.Drawing.Size(100, 20);
            this.txtjob.TabIndex = 27;
            // 
            // txtename
            // 
            this.txtename.Location = new System.Drawing.Point(425, 77);
            this.txtename.Name = "txtename";
            this.txtename.Size = new System.Drawing.Size(100, 20);
            this.txtename.TabIndex = 26;
            // 
            // txtempno
            // 
            this.txtempno.Location = new System.Drawing.Point(425, 38);
            this.txtempno.Name = "txtempno";
            this.txtempno.Size = new System.Drawing.Size(100, 20);
            this.txtempno.TabIndex = 25;
            this.txtempno.Leave += new System.EventHandler(this.txtempno_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(257, 321);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "deptno";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(257, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "commission";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(257, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "salary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(254, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Hiredate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "mgr";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "job";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "ename";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "empno";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.cbbdeptno);
            this.Controls.Add(this.txtcommission);
            this.Controls.Add(this.txtsal);
            this.Controls.Add(this.dpthiredate);
            this.Controls.Add(this.txtmgr);
            this.Controls.Add(this.txtjob);
            this.Controls.Add(this.txtename);
            this.Controls.Add(this.txtempno);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.ComboBox cbbdeptno;
        private System.Windows.Forms.TextBox txtcommission;
        private System.Windows.Forms.TextBox txtsal;
        private System.Windows.Forms.DateTimePicker dpthiredate;
        private System.Windows.Forms.TextBox txtmgr;
        private System.Windows.Forms.TextBox txtjob;
        private System.Windows.Forms.TextBox txtename;
        private System.Windows.Forms.TextBox txtempno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}