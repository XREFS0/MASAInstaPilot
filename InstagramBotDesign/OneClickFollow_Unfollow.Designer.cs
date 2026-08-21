namespace MASAInstaPilot
{
	// Token: 0x02000010 RID: 16
	public partial class OneClickFollow_Unfollow : global::System.Windows.Forms.Form
	{
		// Token: 0x060000C5 RID: 197 RVA: 0x0001075C File Offset: 0x0000E95C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00010794 File Offset: 0x0000E994
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.button1 = new global::System.Windows.Forms.Button();
			this.list_follow = new global::System.Windows.Forms.ListBox();
			this.label5 = new global::System.Windows.Forms.Label();
			this.btn_Import = new global::System.Windows.Forms.Button();
			this.button3 = new global::System.Windows.Forms.Button();
			this.button2 = new global::System.Windows.Forms.Button();
			this.label2 = new global::System.Windows.Forms.Label();
			this.numericUpDown1 = new global::System.Windows.Forms.NumericUpDown();
			this.label3 = new global::System.Windows.Forms.Label();
			this.numericUpDown2 = new global::System.Windows.Forms.NumericUpDown();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.btn_cut = new global::System.Windows.Forms.Button();
			this.bgOneClick = new global::System.ComponentModel.BackgroundWorker();
			this.lblStatus = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.label7 = new global::System.Windows.Forms.Label();
			this.HoursToWork = new global::System.Windows.Forms.NumericUpDown();
			this.HoursStop = new global::System.Windows.Forms.NumericUpDown();
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.lbltester = new global::System.Windows.Forms.Label();
			this.label8 = new global::System.Windows.Forms.Label();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.HoursToWork).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.HoursStop).BeginInit();
			base.SuspendLayout();
			this.button1.BackColor = global::System.Drawing.Color.FromArgb(79, 70, 229);
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Bold);
			this.button1.ForeColor = global::System.Drawing.Color.White;
			this.button1.Location = new global::System.Drawing.Point(290, 371);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(163, 30);
			this.button1.TabIndex = 19;
			this.button1.Text = "START";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.list_follow.BackColor = global::System.Drawing.Color.FromArgb(40, 40, 48);
			this.list_follow.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.list_follow.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.list_follow.ForeColor = global::System.Drawing.Color.FromArgb(35, 35, 42);
			this.list_follow.FormattingEnabled = true;
			this.list_follow.ItemHeight = 16;
			this.list_follow.Location = new global::System.Drawing.Point(290, 12);
			this.list_follow.Name = "list_follow";
			this.list_follow.Size = new global::System.Drawing.Size(163, 258);
			this.list_follow.TabIndex = 20;
			this.label5.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label5.Location = new global::System.Drawing.Point(27, 12);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(240, 24);
			this.label5.TabIndex = 22;
			this.label5.Text = "Import file of users (1 user per line)";
			this.btn_Import.BackColor = global::System.Drawing.Color.FromArgb(55, 55, 65);
			this.btn_Import.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btn_Import.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btn_Import.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btn_Import.ForeColor = global::System.Drawing.Color.FromArgb(35, 35, 42);
			this.btn_Import.Location = new global::System.Drawing.Point(93, 41);
			this.btn_Import.Name = "btn_Import";
			this.btn_Import.Size = new global::System.Drawing.Size(94, 30);
			this.btn_Import.TabIndex = 23;
			this.btn_Import.Text = "Import...";
			this.btn_Import.UseVisualStyleBackColor = false;
			this.btn_Import.Click += new global::System.EventHandler(this.btn_Import_Click);
			this.button3.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.button3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f);
			this.button3.ForeColor = global::System.Drawing.Color.FromArgb(35, 35, 42);
			this.button3.Location = new global::System.Drawing.Point(359, 276);
			this.button3.Name = "button3";
			this.button3.Size = new global::System.Drawing.Size(94, 30);
			this.button3.TabIndex = 33;
			this.button3.Text = "Clear All";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new global::System.EventHandler(this.button3_Click);
			this.button2.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.button2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f);
			this.button2.ForeColor = global::System.Drawing.Color.FromArgb(35, 35, 42);
			this.button2.Location = new global::System.Drawing.Point(290, 276);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(68, 30);
			this.button2.TabIndex = 31;
			this.button2.Text = "Delete";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.Location = new global::System.Drawing.Point(12, 114);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(168, 40);
			this.label2.TabIndex = 35;
			this.label2.Text = "Delay between Follow And Follow (in seconds)";
			this.numericUpDown1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.numericUpDown1.Location = new global::System.Drawing.Point(194, 121);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.numericUpDown1;
			int[] array = new int[4];
			array[0] = 1020;
			numericUpDown.Maximum = new decimal(array);
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.numericUpDown1;
			int[] array2 = new int[4];
			array2[0] = 1;
			numericUpDown2.Minimum = new decimal(array2);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new global::System.Drawing.Size(86, 23);
			this.numericUpDown1.TabIndex = 34;
			this.numericUpDown1.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.numericUpDown1;
			int[] array3 = new int[4];
			array3[0] = 1;
			numericUpDown3.Value = new decimal(array3);
			this.label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.Location = new global::System.Drawing.Point(12, 170);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(175, 40);
			this.label3.TabIndex = 37;
			this.label3.Text = "Delay between Follow And UnFollow (in Minutes)";
			this.numericUpDown2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.numericUpDown2.Location = new global::System.Drawing.Point(194, 177);
			global::System.Windows.Forms.NumericUpDown numericUpDown4 = this.numericUpDown2;
			int[] array4 = new int[4];
			array4[0] = 240;
			numericUpDown4.Maximum = new decimal(array4);
			global::System.Windows.Forms.NumericUpDown numericUpDown5 = this.numericUpDown2;
			int[] array5 = new int[4];
			array5[0] = 1;
			numericUpDown5.Minimum = new decimal(array5);
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new global::System.Drawing.Size(86, 23);
			this.numericUpDown2.TabIndex = 36;
			this.numericUpDown2.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown numericUpDown6 = this.numericUpDown2;
			int[] array6 = new int[4];
			array6[0] = 1;
			numericUpDown6.Value = new decimal(array6);
			this.panel1.BackColor = global::System.Drawing.Color.FromArgb(79, 70, 229);
			this.panel1.Location = new global::System.Drawing.Point(12, 159);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(270, 5);
			this.panel1.TabIndex = 38;
			this.btn_cut.BackColor = global::System.Drawing.Color.FromArgb(239, 68, 68);
			this.btn_cut.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btn_cut.FlatAppearance.BorderSize = 0;
			this.btn_cut.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btn_cut.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btn_cut.ForeColor = global::System.Drawing.Color.White;
			this.btn_cut.Location = new global::System.Drawing.Point(12, 371);
			this.btn_cut.Name = "btn_cut";
			this.btn_cut.Size = new global::System.Drawing.Size(142, 30);
			this.btn_cut.TabIndex = 39;
			this.btn_cut.Text = "Stop";
			this.btn_cut.UseVisualStyleBackColor = false;
			this.btn_cut.Click += new global::System.EventHandler(this.btn_cut_Click);
			this.bgOneClick.DoWork += new global::System.ComponentModel.DoWorkEventHandler(this.bgOneClick_DoWork);
			this.bgOneClick.RunWorkerCompleted += new global::System.ComponentModel.RunWorkerCompletedEventHandler(this.bgOneClick_RunWorkerCompleted);
			this.lblStatus.AutoSize = true;
			this.lblStatus.Location = new global::System.Drawing.Point(219, 256);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new global::System.Drawing.Size(0, 13);
			this.lblStatus.TabIndex = 40;
			this.lblStatus.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label4.Location = new global::System.Drawing.Point(5, 256);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(55, 13);
			this.label4.TabIndex = 41;
			this.label4.Text = "Action : ";
			this.label4.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label6.AutoSize = true;
			this.label6.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label6.Location = new global::System.Drawing.Point(67, 324);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(51, 13);
			this.label6.TabIndex = 42;
			this.label6.Text = "Work for ";
			this.label6.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label7.AutoSize = true;
			this.label7.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label7.Location = new global::System.Drawing.Point(185, 324);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(113, 13);
			this.label7.TabIndex = 43;
			this.label7.Text = "Hours,  And Stop After";
			this.label7.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.HoursToWork.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.HoursToWork.Location = new global::System.Drawing.Point(123, 320);
			global::System.Windows.Forms.NumericUpDown hoursToWork = this.HoursToWork;
			int[] array7 = new int[4];
			array7[0] = 24;
			hoursToWork.Maximum = new decimal(array7);
			global::System.Windows.Forms.NumericUpDown hoursToWork2 = this.HoursToWork;
			int[] array8 = new int[4];
			array8[0] = 1;
			hoursToWork2.Minimum = new decimal(array8);
			this.HoursToWork.Name = "HoursToWork";
			this.HoursToWork.Size = new global::System.Drawing.Size(56, 23);
			this.HoursToWork.TabIndex = 44;
			this.HoursToWork.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown hoursToWork3 = this.HoursToWork;
			int[] array9 = new int[4];
			array9[0] = 1;
			hoursToWork3.Value = new decimal(array9);
			this.HoursStop.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.HoursStop.Location = new global::System.Drawing.Point(303, 320);
			global::System.Windows.Forms.NumericUpDown hoursStop = this.HoursStop;
			int[] array10 = new int[4];
			array10[0] = 24;
			hoursStop.Maximum = new decimal(array10);
			global::System.Windows.Forms.NumericUpDown hoursStop2 = this.HoursStop;
			int[] array11 = new int[4];
			array11[0] = 1;
			hoursStop2.Minimum = new decimal(array11);
			this.HoursStop.Name = "HoursStop";
			this.HoursStop.Size = new global::System.Drawing.Size(55, 23);
			this.HoursStop.TabIndex = 45;
			this.HoursStop.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown hoursStop3 = this.HoursStop;
			int[] array12 = new int[4];
			array12[0] = 1;
			hoursStop3.Value = new decimal(array12);
			this.timer1.Enabled = true;
			this.timer1.Tick += new global::System.EventHandler(this.timer1_Tick);
			this.lbltester.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lbltester.Location = new global::System.Drawing.Point(159, 375);
			this.lbltester.Name = "lbltester";
			this.lbltester.Size = new global::System.Drawing.Size(127, 23);
			this.lbltester.TabIndex = 46;
			this.lbltester.Text = "test";
			this.lbltester.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label8.AutoSize = true;
			this.label8.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label8.Location = new global::System.Drawing.Point(364, 324);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(33, 13);
			this.label8.TabIndex = 47;
			this.label8.Text = "hours";
			this.label8.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(25, 25, 30);
			base.ClientSize = new global::System.Drawing.Size(465, 413);
			base.Controls.Add(this.label8);
			base.Controls.Add(this.lbltester);
			base.Controls.Add(this.HoursStop);
			base.Controls.Add(this.HoursToWork);
			base.Controls.Add(this.label7);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.lblStatus);
			base.Controls.Add(this.btn_cut);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.numericUpDown2);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.numericUpDown1);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.btn_Import);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.list_follow);
			base.Controls.Add(this.button1);
			base.MaximizeBox = false;
			this.MaximumSize = new global::System.Drawing.Size(481, 452);
			base.MinimizeBox = false;
			this.MinimumSize = new global::System.Drawing.Size(481, 452);
			base.Name = "OneClickFollow_Unfollow";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "One Click Follow Unfollow";
			base.Load += new global::System.EventHandler(this.OneClickFollow_Unfollow_Load);
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.HoursToWork).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.HoursStop).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040000D7 RID: 215
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040000D8 RID: 216
		private global::System.Windows.Forms.Button button1;

		// Token: 0x040000D9 RID: 217
		private global::System.Windows.Forms.ListBox list_follow;

		// Token: 0x040000DA RID: 218
		private global::System.Windows.Forms.Label label5;

		// Token: 0x040000DB RID: 219
		private global::System.Windows.Forms.Button btn_Import;

		// Token: 0x040000DC RID: 220
		private global::System.Windows.Forms.Button button3;

		// Token: 0x040000DD RID: 221
		private global::System.Windows.Forms.Button button2;

		// Token: 0x040000DE RID: 222
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040000DF RID: 223
		private global::System.Windows.Forms.NumericUpDown numericUpDown1;

		// Token: 0x040000E0 RID: 224
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040000E1 RID: 225
		private global::System.Windows.Forms.NumericUpDown numericUpDown2;

		// Token: 0x040000E2 RID: 226
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x040000E3 RID: 227
		private global::System.Windows.Forms.Button btn_cut;

		// Token: 0x040000E4 RID: 228
		private global::System.ComponentModel.BackgroundWorker bgOneClick;

		// Token: 0x040000E5 RID: 229
		private global::System.Windows.Forms.Label lblStatus;

		// Token: 0x040000E6 RID: 230
		private global::System.Windows.Forms.Label label4;

		// Token: 0x040000E7 RID: 231
		private global::System.Windows.Forms.Label label6;

		// Token: 0x040000E8 RID: 232
		private global::System.Windows.Forms.Label label7;

		// Token: 0x040000E9 RID: 233
		private global::System.Windows.Forms.NumericUpDown HoursToWork;

		// Token: 0x040000EA RID: 234
		private global::System.Windows.Forms.NumericUpDown HoursStop;

		// Token: 0x040000EB RID: 235
		private global::System.Windows.Forms.Timer timer1;

		// Token: 0x040000EC RID: 236
		private global::System.Windows.Forms.Label lbltester;

		// Token: 0x040000ED RID: 237
		private global::System.Windows.Forms.Label label8;
	}
}
