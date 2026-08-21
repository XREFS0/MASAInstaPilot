namespace MASAInstaPilot
{
	// Token: 0x0200000E RID: 14
	public partial class HelpForm : global::System.Windows.Forms.Form
	{
		// Token: 0x06000057 RID: 87 RVA: 0x00007964 File Offset: 0x00005B64
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x0000799C File Offset: 0x00005B9C
		private void InitializeComponent()
		{
			this.label1 = new global::System.Windows.Forms.Label();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.textBox2 = new global::System.Windows.Forms.TextBox();
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.label2 = new global::System.Windows.Forms.Label();
			this.textBox3 = new global::System.Windows.Forms.TextBox();
			this.panel3 = new global::System.Windows.Forms.Panel();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Calibri", 11f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.Location = new global::System.Drawing.Point(67, 19);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(150, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Email  :";
			this.panel1.BackColor = global::System.Drawing.Color.FromArgb(35, 35, 42);
			this.panel1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Location = new global::System.Drawing.Point(67, 40);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(330, 2);
			this.panel1.TabIndex = 1;
			this.textBox1.BackColor = global::System.Drawing.Color.FromArgb(45, 45, 55);
			this.textBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.textBox1.Location = new global::System.Drawing.Point(220, 21);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new global::System.Drawing.Size(177, 13);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "";
			this.textBox1.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox2.BackColor = global::System.Drawing.Color.FromArgb(45, 45, 55);
			this.textBox2.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.textBox2.Location = new global::System.Drawing.Point(220, 67);
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new global::System.Drawing.Size(177, 13);
			this.textBox2.TabIndex = 2;
			this.textBox2.Text = "";
			this.textBox2.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.panel2.BackColor = global::System.Drawing.Color.FromArgb(35, 35, 42);
			this.panel2.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Location = new global::System.Drawing.Point(67, 86);
			this.panel2.Name = "panel2";
			this.panel2.Size = new global::System.Drawing.Size(330, 2);
			this.panel2.TabIndex = 4;
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Calibri", 11f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.Location = new global::System.Drawing.Point(67, 65);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(151, 18);
			this.label2.TabIndex = 3;
			this.label2.Text = "Phone :";
			this.textBox3.BackColor = global::System.Drawing.Color.FromArgb(45, 45, 55);
			this.textBox3.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.textBox3.Location = new global::System.Drawing.Point(216, 117);
			this.textBox3.Name = "textBox3";
			this.textBox3.ReadOnly = true;
			this.textBox3.Size = new global::System.Drawing.Size(219, 13);
			this.textBox3.TabIndex = 5;
			this.textBox3.Text = "";
			this.textBox3.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.panel3.BackColor = global::System.Drawing.Color.FromArgb(35, 35, 42);
			this.panel3.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel3.Location = new global::System.Drawing.Point(22, 137);
			this.panel3.Name = "panel3";
			this.panel3.Size = new global::System.Drawing.Size(420, 2);
			this.panel3.TabIndex = 7;
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Calibri", 11f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.Location = new global::System.Drawing.Point(29, 113);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(191, 18);
			this.label3.TabIndex = 6;
			this.label3.Text = "Website  :";
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("Calibri", 8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label4.Location = new global::System.Drawing.Point(152, 179);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(161, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "MASA InstaPilot";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(25, 25, 30);
			base.ClientSize = new global::System.Drawing.Size(465, 211);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.textBox3);
			base.Controls.Add(this.panel3);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.textBox2);
			base.Controls.Add(this.panel2);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.textBox1);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.label1);
			base.MaximizeBox = false;
			this.MaximumSize = new global::System.Drawing.Size(481, 250);
			base.MinimizeBox = false;
			this.MinimumSize = new global::System.Drawing.Size(481, 250);
			base.Name = "HelpForm";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Get Help";
			base.Load += new global::System.EventHandler(this.HelpForm_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000050 RID: 80
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000051 RID: 81
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000052 RID: 82
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000053 RID: 83
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x04000054 RID: 84
		private global::System.Windows.Forms.TextBox textBox2;

		// Token: 0x04000055 RID: 85
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x04000056 RID: 86
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000057 RID: 87
		private global::System.Windows.Forms.TextBox textBox3;

		// Token: 0x04000058 RID: 88
		private global::System.Windows.Forms.Panel panel3;

		// Token: 0x04000059 RID: 89
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400005A RID: 90
		private global::System.Windows.Forms.Label label4;
	}
}
