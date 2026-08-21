namespace MASAInstaPilot
{
	// Token: 0x0200000B RID: 11
	public partial class GetUsersFromPost : global::System.Windows.Forms.Form
	{
		// Token: 0x0600003D RID: 61 RVA: 0x000056FC File Offset: 0x000038FC
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00005734 File Offset: 0x00003934
		private void InitializeComponent()
		{
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.numericUpDown1 = new global::System.Windows.Forms.NumericUpDown();
			this.label2 = new global::System.Windows.Forms.Label();
			this.button1 = new global::System.Windows.Forms.Button();
			this.save = new global::System.Windows.Forms.SaveFileDialog();
			this.backgroundWorker1 = new global::System.ComponentModel.BackgroundWorker();
			this.listBox1 = new global::System.Windows.Forms.ListBox();
			this.label5 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.button2 = new global::System.Windows.Forms.Button();
			this.button3 = new global::System.Windows.Forms.Button();
			this.button4 = new global::System.Windows.Forms.Button();
			this.label3 = new global::System.Windows.Forms.Label();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown1).BeginInit();
			base.SuspendLayout();
			this.textBox1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.textBox1.Location = new global::System.Drawing.Point(123, 13);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(309, 23);
			this.textBox1.TabIndex = 0;
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.Location = new global::System.Drawing.Point(33, 16);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(84, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "Post URL :  ";
			this.numericUpDown1.Enabled = false;
			this.numericUpDown1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.numericUpDown1.Location = new global::System.Drawing.Point(142, 74);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.numericUpDown1;
			int[] array = new int[4];
			array[0] = 500;
			numericUpDown.Maximum = new decimal(array);
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.numericUpDown1;
			int[] array2 = new int[4];
			array2[0] = 1;
			numericUpDown2.Minimum = new decimal(array2);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new global::System.Drawing.Size(101, 23);
			this.numericUpDown1.TabIndex = 2;
			this.numericUpDown1.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.numericUpDown1;
			int[] array3 = new int[4];
			array3[0] = 100;
			numericUpDown3.Value = new decimal(array3);
			this.numericUpDown1.ValueChanged += new global::System.EventHandler(this.numericUpDown1_ValueChanged);
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.Location = new global::System.Drawing.Point(52, 76);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(81, 15);
			this.label2.TabIndex = 3;
			this.label2.Text = "Max Quantity:";
			this.button1.BackColor = global::System.Drawing.Color.FromArgb(79, 70, 229);
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Bold);
			this.button1.ForeColor = global::System.Drawing.Color.White;
			this.button1.Location = new global::System.Drawing.Point(288, 67);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(144, 34);
			this.button1.TabIndex = 4;
			this.button1.Text = "Extract Users";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.backgroundWorker1.DoWork += new global::System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
			this.backgroundWorker1.RunWorkerCompleted += new global::System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new global::System.Drawing.Point(36, 120);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new global::System.Drawing.Size(398, 290);
			this.listBox1.TabIndex = 17;
			this.label5.AutoSize = true;
			this.label5.Font = new global::System.Drawing.Font("Arial", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label5.Location = new global::System.Drawing.Point(21, 422);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(104, 15);
			this.label5.TabIndex = 20;
			this.label5.Text = "#Extracted Users:";
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label4.ForeColor = global::System.Drawing.Color.FromArgb(248, 113, 113);
			this.label4.Location = new global::System.Drawing.Point(131, 422);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(14, 15);
			this.label4.TabIndex = 21;
			this.label4.Text = "0";
			this.button2.BackColor = global::System.Drawing.Color.FromArgb(239, 68, 68);
			this.button2.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.button2.Location = new global::System.Drawing.Point(187, 422);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(75, 23);
			this.button2.TabIndex = 22;
			this.button2.Text = "STOP";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.button3.BackColor = global::System.Drawing.Color.FromArgb(245, 158, 11);
			this.button3.Location = new global::System.Drawing.Point(268, 422);
			this.button3.Name = "button3";
			this.button3.Size = new global::System.Drawing.Size(75, 23);
			this.button3.TabIndex = 23;
			this.button3.Text = "CLEAR";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new global::System.EventHandler(this.button3_Click);
			this.button4.BackColor = global::System.Drawing.Color.FromArgb(79, 70, 229);
			this.button4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button4.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.button4.Location = new global::System.Drawing.Point(349, 422);
			this.button4.Name = "button4";
			this.button4.Size = new global::System.Drawing.Size(87, 38);
			this.button4.TabIndex = 24;
			this.button4.Text = "EXPORT DATA";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new global::System.EventHandler(this.button4_Click);
			this.label3.AutoSize = true;
			this.label3.ForeColor = global::System.Drawing.Color.FromArgb(239, 68, 68);
			this.label3.Location = new global::System.Drawing.Point(285, 51);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(47, 13);
			this.label3.TabIndex = 25;
			this.label3.Text = "Ready...";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(25, 25, 30);
			base.ClientSize = new global::System.Drawing.Size(465, 461);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.button4);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.listBox1);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.numericUpDown1);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.textBox1);
			base.MaximizeBox = false;
			this.MaximumSize = new global::System.Drawing.Size(481, 500);
			this.MinimumSize = new global::System.Drawing.Size(481, 500);
			base.Name = "GetUsersFromPost";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Get Users From Post \"Like\"";
			base.Load += new global::System.EventHandler(this.GetUsersFromPost_Load);
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400002A RID: 42
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400002B RID: 43
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x0400002C RID: 44
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400002D RID: 45
		private global::System.Windows.Forms.NumericUpDown numericUpDown1;

		// Token: 0x0400002E RID: 46
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400002F RID: 47
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000030 RID: 48
		private global::System.Windows.Forms.SaveFileDialog save;

		// Token: 0x04000031 RID: 49
		private global::System.ComponentModel.BackgroundWorker backgroundWorker1;

		// Token: 0x04000032 RID: 50
		private global::System.Windows.Forms.ListBox listBox1;

		// Token: 0x04000033 RID: 51
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000034 RID: 52
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000035 RID: 53
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000036 RID: 54
		private global::System.Windows.Forms.Button button3;

		// Token: 0x04000037 RID: 55
		private global::System.Windows.Forms.Button button4;

		// Token: 0x04000038 RID: 56
		private global::System.Windows.Forms.Label label3;
	}
}
