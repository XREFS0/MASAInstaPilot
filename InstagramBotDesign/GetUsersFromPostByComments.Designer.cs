namespace MASAInstaPilot
{
	// Token: 0x0200000C RID: 12
	public partial class GetUsersFromPostByComments : global::System.Windows.Forms.Form
	{
		// Token: 0x06000046 RID: 70 RVA: 0x000062E8 File Offset: 0x000044E8
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00006320 File Offset: 0x00004520
		private void InitializeComponent()
		{
			this.button1 = new global::System.Windows.Forms.Button();
			this.label2 = new global::System.Windows.Forms.Label();
			this.numericUpDown1 = new global::System.Windows.Forms.NumericUpDown();
			this.label1 = new global::System.Windows.Forms.Label();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.backgroundWorker1 = new global::System.ComponentModel.BackgroundWorker();
			this.save = new global::System.Windows.Forms.SaveFileDialog();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown1).BeginInit();
			base.SuspendLayout();
			this.button1.BackColor = global::System.Drawing.Color.FromArgb(79, 70, 229);
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Bold);
			this.button1.ForeColor = global::System.Drawing.Color.White;
			this.button1.Location = new global::System.Drawing.Point(288, 66);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(144, 34);
			this.button1.TabIndex = 9;
			this.button1.Text = "Extract Users";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.Location = new global::System.Drawing.Point(55, 75);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(65, 17);
			this.label2.TabIndex = 8;
			this.label2.Text = "Quantity:";
			this.numericUpDown1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.numericUpDown1.Location = new global::System.Drawing.Point(138, 73);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.numericUpDown1;
			int[] array = new int[4];
			array[0] = 500;
			numericUpDown.Maximum = new decimal(array);
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.numericUpDown1;
			int[] array2 = new int[4];
			array2[0] = 1;
			numericUpDown2.Minimum = new decimal(array2);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new global::System.Drawing.Size(105, 23);
			this.numericUpDown1.TabIndex = 7;
			this.numericUpDown1.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.numericUpDown1;
			int[] array3 = new int[4];
			array3[0] = 5;
			numericUpDown3.Value = new decimal(array3);
			this.numericUpDown1.ValueChanged += new global::System.EventHandler(this.numericUpDown1_ValueChanged);
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.Location = new global::System.Drawing.Point(36, 15);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(84, 17);
			this.label1.TabIndex = 6;
			this.label1.Text = "Post URL :  ";
			this.textBox1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.textBox1.Location = new global::System.Drawing.Point(123, 12);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(309, 23);
			this.textBox1.TabIndex = 5;
			this.backgroundWorker1.DoWork += new global::System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
			this.backgroundWorker1.RunWorkerCompleted += new global::System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(25, 25, 30);
			base.ClientSize = new global::System.Drawing.Size(465, 113);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.numericUpDown1);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.textBox1);
			base.MaximizeBox = false;
			this.MaximumSize = new global::System.Drawing.Size(481, 152);
			this.MinimumSize = new global::System.Drawing.Size(481, 152);
			base.Name = "GetUsersFromPostByComments";
			this.Text = "Get Users From Post Comment";
			base.Load += new global::System.EventHandler(this.GetUsersFromPostByComments_Load);
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000039 RID: 57
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400003A RID: 58
		private global::System.Windows.Forms.Button button1;

		// Token: 0x0400003B RID: 59
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400003C RID: 60
		private global::System.Windows.Forms.NumericUpDown numericUpDown1;

		// Token: 0x0400003D RID: 61
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400003E RID: 62
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x0400003F RID: 63
		private global::System.ComponentModel.BackgroundWorker backgroundWorker1;

		// Token: 0x04000040 RID: 64
		private global::System.Windows.Forms.SaveFileDialog save;
	}
}
