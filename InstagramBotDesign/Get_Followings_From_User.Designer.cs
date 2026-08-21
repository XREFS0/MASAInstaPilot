namespace MASAInstaPilot
{
	// Token: 0x0200000D RID: 13
	public partial class Get_Followings_From_User : global::System.Windows.Forms.Form
	{
		// Token: 0x06000051 RID: 81 RVA: 0x00006EE8 File Offset: 0x000050E8
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00006F20 File Offset: 0x00005120
		private void InitializeComponent()
		{
			this.button1 = new global::System.Windows.Forms.Button();
			this.label2 = new global::System.Windows.Forms.Label();
			this.numericUpDown1 = new global::System.Windows.Forms.NumericUpDown();
			this.label1 = new global::System.Windows.Forms.Label();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.backgroundWorker1 = new global::System.ComponentModel.BackgroundWorker();
			this.label3 = new global::System.Windows.Forms.Label();
			this.listBox1 = new global::System.Windows.Forms.ListBox();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
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
			this.button1.Location = new global::System.Drawing.Point(289, 66);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(144, 34);
			this.button1.TabIndex = 19;
			this.button1.Text = "Extract Users";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.Location = new global::System.Drawing.Point(54, 75);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(65, 17);
			this.label2.TabIndex = 18;
			this.label2.Text = "Quantity:";
			this.numericUpDown1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.numericUpDown1.Location = new global::System.Drawing.Point(146, 73);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.numericUpDown1;
			int[] array = new int[4];
			array[0] = 100000;
			numericUpDown.Maximum = new decimal(array);
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.numericUpDown1;
			int[] array2 = new int[4];
			array2[0] = 1;
			numericUpDown2.Minimum = new decimal(array2);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new global::System.Drawing.Size(102, 23);
			this.numericUpDown1.TabIndex = 17;
			this.numericUpDown1.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.numericUpDown1;
			int[] array3 = new int[4];
			array3[0] = 20;
			numericUpDown3.Value = new decimal(array3);
			this.numericUpDown1.ValueChanged += new global::System.EventHandler(this.numericUpDown1_ValueChanged);
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.Location = new global::System.Drawing.Point(32, 15);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(87, 17);
			this.label1.TabIndex = 16;
			this.label1.Text = "UserName : ";
			this.textBox1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.textBox1.Location = new global::System.Drawing.Point(128, 12);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(305, 23);
			this.textBox1.TabIndex = 15;
			this.backgroundWorker1.DoWork += new global::System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
			this.backgroundWorker1.RunWorkerCompleted += new global::System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
			this.label3.AutoSize = true;
			this.label3.ForeColor = global::System.Drawing.Color.FromArgb(239, 68, 68);
			this.label3.Location = new global::System.Drawing.Point(290, 50);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(35, 13);
			this.label3.TabIndex = 20;
			this.label3.Text = "label3";
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new global::System.Drawing.Point(35, 113);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new global::System.Drawing.Size(398, 277);
			this.listBox1.TabIndex = 21;
			this.label4.AutoSize = true;
			this.label4.ForeColor = global::System.Drawing.Color.FromArgb(252, 165, 165);
			this.label4.Location = new global::System.Drawing.Point(101, 403);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(13, 13);
			this.label4.TabIndex = 22;
			this.label4.Text = "0";
			this.label5.AutoSize = true;
			this.label5.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label5.Location = new global::System.Drawing.Point(32, 403);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(69, 13);
			this.label5.TabIndex = 23;
			this.label5.Text = "# Followings:";
			this.button2.BackColor = global::System.Drawing.Color.FromArgb(239, 68, 68);
			this.button2.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.button2.Location = new global::System.Drawing.Point(173, 403);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(75, 23);
			this.button2.TabIndex = 24;
			this.button2.Text = "STOP";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.button3.BackColor = global::System.Drawing.Color.FromArgb(245, 158, 11);
			this.button3.Location = new global::System.Drawing.Point(254, 403);
			this.button3.Name = "button3";
			this.button3.Size = new global::System.Drawing.Size(75, 23);
			this.button3.TabIndex = 25;
			this.button3.Text = "CLEAR";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new global::System.EventHandler(this.button3_Click);
			this.button4.BackColor = global::System.Drawing.Color.FromArgb(79, 70, 229);
			this.button4.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.button4.Location = new global::System.Drawing.Point(336, 403);
			this.button4.Name = "button4";
			this.button4.Size = new global::System.Drawing.Size(97, 23);
			this.button4.TabIndex = 26;
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
			base.Controls.Add(this.label5);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.listBox1);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.numericUpDown1);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.textBox1);
			base.MaximizeBox = false;
			this.MaximumSize = new global::System.Drawing.Size(481, 500);
			base.MinimizeBox = false;
			this.MinimumSize = new global::System.Drawing.Size(481, 500);
			base.Name = "Get_Followings_From_User";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Get_Followings_From_User";
			base.Load += new global::System.EventHandler(this.Get_Followings_From_User_Load);
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000042 RID: 66
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000043 RID: 67
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000044 RID: 68
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000045 RID: 69
		private global::System.Windows.Forms.NumericUpDown numericUpDown1;

		// Token: 0x04000046 RID: 70
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000047 RID: 71
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x04000048 RID: 72
		private global::System.ComponentModel.BackgroundWorker backgroundWorker1;

		// Token: 0x04000049 RID: 73
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400004A RID: 74
		private global::System.Windows.Forms.ListBox listBox1;

		// Token: 0x0400004B RID: 75
		private global::System.Windows.Forms.Label label4;

		// Token: 0x0400004C RID: 76
		private global::System.Windows.Forms.Label label5;

		// Token: 0x0400004D RID: 77
		private global::System.Windows.Forms.Button button2;

		// Token: 0x0400004E RID: 78
		private global::System.Windows.Forms.Button button3;

		// Token: 0x0400004F RID: 79
		private global::System.Windows.Forms.Button button4;
	}
}
