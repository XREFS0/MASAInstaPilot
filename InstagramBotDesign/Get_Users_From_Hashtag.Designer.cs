namespace MASAInstaPilot
{
	// Token: 0x02000009 RID: 9
	public partial class Get_Users_From_Hashtag : global::System.Windows.Forms.Form
	{
		// Token: 0x06000024 RID: 36 RVA: 0x00003890 File Offset: 0x00001A90
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000038C8 File Offset: 0x00001AC8
		private void InitializeComponent()
		{
			this.button1 = new global::System.Windows.Forms.Button();
			this.label2 = new global::System.Windows.Forms.Label();
			this.numericUpDown1 = new global::System.Windows.Forms.NumericUpDown();
			this.label1 = new global::System.Windows.Forms.Label();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.backgroundWorker1 = new global::System.ComponentModel.BackgroundWorker();
			this.save = new global::System.Windows.Forms.SaveFileDialog();
			this.listBox1 = new global::System.Windows.Forms.ListBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.button2 = new global::System.Windows.Forms.Button();
			this.button3 = new global::System.Windows.Forms.Button();
			this.button4 = new global::System.Windows.Forms.Button();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown1).BeginInit();
			base.SuspendLayout();
			this.button1.BackColor = global::System.Drawing.Color.FromArgb(79, 70, 229);
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Bold);
			this.button1.ForeColor = global::System.Drawing.Color.White;
			this.button1.Location = new global::System.Drawing.Point(127, 70);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(219, 34);
			this.button1.TabIndex = 9;
			this.button1.Text = "Extract Users";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f);
			this.label2.Location = new global::System.Drawing.Point(22, 45);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(101, 15);
			this.label2.TabIndex = 8;
			this.label2.Text = "Users to Extract : ";
			this.numericUpDown1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.numericUpDown1.Location = new global::System.Drawing.Point(127, 41);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.numericUpDown1;
			int[] array = new int[4];
			array[0] = 100000;
			numericUpDown.Maximum = new decimal(array);
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.numericUpDown1;
			int[] array2 = new int[4];
			array2[0] = 1;
			numericUpDown2.Minimum = new decimal(array2);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new global::System.Drawing.Size(94, 23);
			this.numericUpDown1.TabIndex = 7;
			this.numericUpDown1.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.numericUpDown1;
			int[] array3 = new int[4];
			array3[0] = 15;
			numericUpDown3.Value = new decimal(array3);
			this.numericUpDown1.ValueChanged += new global::System.EventHandler(this.numericUpDown1_ValueChanged);
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.Location = new global::System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(115, 17);
			this.label1.TabIndex = 6;
			this.label1.Text = "HashTag Name :";
			this.textBox1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.textBox1.Location = new global::System.Drawing.Point(127, 12);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(305, 23);
			this.textBox1.TabIndex = 5;
			this.backgroundWorker1.DoWork += new global::System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
			this.backgroundWorker1.RunWorkerCompleted += new global::System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new global::System.Drawing.Point(45, 117);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new global::System.Drawing.Size(387, 264);
			this.listBox1.TabIndex = 10;
			this.label3.AutoSize = true;
			this.label3.ForeColor = global::System.Drawing.Color.FromArgb(252, 165, 165);
			this.label3.Location = new global::System.Drawing.Point(114, 403);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(13, 13);
			this.label3.TabIndex = 11;
			this.label3.Text = "0";
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f);
			this.label4.Location = new global::System.Drawing.Point(57, 400);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(55, 15);
			this.label4.TabIndex = 12;
			this.label4.Text = "#Users : ";
			this.button2.BackColor = global::System.Drawing.Color.FromArgb(239, 68, 68);
			this.button2.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.button2.Location = new global::System.Drawing.Point(168, 397);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(75, 23);
			this.button2.TabIndex = 13;
			this.button2.Text = "STOP";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.button3.BackColor = global::System.Drawing.Color.FromArgb(245, 158, 11);
			this.button3.Location = new global::System.Drawing.Point(249, 397);
			this.button3.Name = "button3";
			this.button3.Size = new global::System.Drawing.Size(75, 23);
			this.button3.TabIndex = 14;
			this.button3.Text = "CLEAR";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new global::System.EventHandler(this.button3_Click);
			this.button4.BackColor = global::System.Drawing.Color.FromArgb(79, 70, 229);
			this.button4.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.button4.Location = new global::System.Drawing.Point(330, 397);
			this.button4.Name = "button4";
			this.button4.Size = new global::System.Drawing.Size(102, 23);
			this.button4.TabIndex = 15;
			this.button4.Text = "EXPORT DATA";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new global::System.EventHandler(this.button4_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(25, 25, 30);
			base.ClientSize = new global::System.Drawing.Size(465, 461);
			base.Controls.Add(this.button4);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.listBox1);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.numericUpDown1);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.textBox1);
			base.MaximizeBox = false;
			this.MaximumSize = new global::System.Drawing.Size(481, 500);
			this.MinimumSize = new global::System.Drawing.Size(481, 500);
			base.Name = "Get_Users_From_Hashtag";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Get_Users_From_Hashtag";
			base.Load += new global::System.EventHandler(this.Get_Users_From_Hashtag_Load);
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400000C RID: 12
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400000D RID: 13
		private global::System.Windows.Forms.Button button1;

		// Token: 0x0400000E RID: 14
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400000F RID: 15
		private global::System.Windows.Forms.NumericUpDown numericUpDown1;

		// Token: 0x04000010 RID: 16
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000011 RID: 17
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x04000012 RID: 18
		private global::System.ComponentModel.BackgroundWorker backgroundWorker1;

		// Token: 0x04000013 RID: 19
		private global::System.Windows.Forms.SaveFileDialog save;

		// Token: 0x04000014 RID: 20
		private global::System.Windows.Forms.ListBox listBox1;

		// Token: 0x04000015 RID: 21
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000016 RID: 22
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000017 RID: 23
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000018 RID: 24
		private global::System.Windows.Forms.Button button3;

		// Token: 0x04000019 RID: 25
		private global::System.Windows.Forms.Button button4;
	}
}
