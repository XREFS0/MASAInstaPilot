namespace MASAInstaPilot
{
	// Token: 0x02000013 RID: 19
	public partial class RegistrationForm : global::System.Windows.Forms.Form
	{
		// Token: 0x060000D8 RID: 216 RVA: 0x00011D20 File Offset: 0x0000FF20
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00011D58 File Offset: 0x0000FF58
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(global::MASAInstaPilot.RegistrationForm));
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.tbEmail = new global::System.Windows.Forms.TextBox();
			this.tbRegCode = new global::System.Windows.Forms.TextBox();
			this.btnRegister = new global::System.Windows.Forms.Button();
			this.btnBuyNow = new global::System.Windows.Forms.Button();
			this.btnFreeTrial = new global::System.Windows.Forms.Button();
			this.label7 = new global::System.Windows.Forms.Label();
			this.lblSupportLink = new global::System.Windows.Forms.Label();
			this.pictureBoxAppIcon = new global::System.Windows.Forms.PictureBox();
			this.label8 = new global::System.Windows.Forms.Label();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBoxAppIcon).BeginInit();
			base.SuspendLayout();
			this.label1.Font = new global::System.Drawing.Font("Calibri", 18f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 204);
			this.label1.Location = new global::System.Drawing.Point(142, 12);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(330, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "MASA InstaPilot";
			this.label1.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(170, 62);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(251, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Register the software to have the following benefits:";
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(170, 104);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(157, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "-  Import Unlimited data from File";
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(170, 88);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(212, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "-  Unlimited Follow/Unfollow/Comment/Like";
			this.label5.AutoSize = true;
			this.label5.Location = new global::System.Drawing.Point(9, 140);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(84, 13);
			this.label5.TabIndex = 5;
			this.label5.Text = "Licensed E-mail:";
			this.label6.AutoSize = true;
			this.label6.Location = new global::System.Drawing.Point(9, 163);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(94, 13);
			this.label6.TabIndex = 6;
			this.label6.Text = "Registration Code:";
			this.tbEmail.Location = new global::System.Drawing.Point(173, 137);
			this.tbEmail.Name = "tbEmail";
			this.tbEmail.Size = new global::System.Drawing.Size(299, 20);
			this.tbEmail.TabIndex = 7;
			this.tbEmail.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.tbRegCode.Location = new global::System.Drawing.Point(173, 160);
			this.tbRegCode.Name = "tbRegCode";
			this.tbRegCode.Size = new global::System.Drawing.Size(299, 20);
			this.tbRegCode.TabIndex = 8;
			this.tbRegCode.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.tbRegCode.TextChanged += new global::System.EventHandler(this.tbRegCode_TextChanged);
			this.btnRegister.Location = new global::System.Drawing.Point(12, 186);
			this.btnRegister.Name = "btnRegister";
			this.btnRegister.Size = new global::System.Drawing.Size(75, 23);
			this.btnRegister.TabIndex = 9;
			this.btnRegister.Text = "Register";
			this.btnRegister.UseVisualStyleBackColor = true;
			this.btnRegister.Click += new global::System.EventHandler(this.btnRegister_Click);
			this.btnBuyNow.Anchor = global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right;
			this.btnBuyNow.Location = new global::System.Drawing.Point(316, 186);
			this.btnBuyNow.Name = "btnBuyNow";
			this.btnBuyNow.Size = new global::System.Drawing.Size(75, 23);
			this.btnBuyNow.TabIndex = 10;
			this.btnBuyNow.Text = "Buy now";
			this.btnBuyNow.UseVisualStyleBackColor = true;
			this.btnBuyNow.Click += new global::System.EventHandler(this.btnBuyNow_Click);
			this.btnFreeTrial.Anchor = global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right;
			this.btnFreeTrial.Location = new global::System.Drawing.Point(397, 186);
			this.btnFreeTrial.Name = "btnFreeTrial";
			this.btnFreeTrial.Size = new global::System.Drawing.Size(75, 23);
			this.btnFreeTrial.TabIndex = 11;
			this.btnFreeTrial.Text = "Free Trial";
			this.btnFreeTrial.UseVisualStyleBackColor = true;
			this.btnFreeTrial.Click += new global::System.EventHandler(this.btnFreeTrial_Click);
			this.label7.AutoSize = true;
			this.label7.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.label7.Location = new global::System.Drawing.Point(9, 212);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(453, 13);
			this.label7.TabIndex = 12;
			this.label7.Text = "Note: if you have any problems with the registration code and software, please visit our website";
			this.lblSupportLink.AutoSize = true;
			this.lblSupportLink.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.lblSupportLink.Location = new global::System.Drawing.Point(138, 232);
			this.lblSupportLink.Name = "lblSupportLink";
			this.lblSupportLink.Size = new global::System.Drawing.Size(135, 13);
			this.lblSupportLink.TabIndex = 13;
			this.lblSupportLink.Text = "";
			this.lblSupportLink.Click += new global::System.EventHandler(this.lblSupportLink_Click);
			this.lblSupportLink.MouseLeave += new global::System.EventHandler(this.lblSupportLink_MouseLeave);
			this.lblSupportLink.MouseHover += new global::System.EventHandler(this.lblSupportLink_MouseHover);
			this.pictureBoxAppIcon.ErrorImage = null;
			this.pictureBoxAppIcon.Image = (global::System.Drawing.Image)resources.GetObject("pictureBoxAppIcon.Image");
			this.pictureBoxAppIcon.InitialImage = null;
			this.pictureBoxAppIcon.Location = new global::System.Drawing.Point(12, 2);
			this.pictureBoxAppIcon.Name = "pictureBoxAppIcon";
			this.pictureBoxAppIcon.Size = new global::System.Drawing.Size(124, 123);
			this.pictureBoxAppIcon.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxAppIcon.TabIndex = 0;
			this.pictureBoxAppIcon.TabStop = false;
			this.label8.AutoSize = true;
			this.label8.Location = new global::System.Drawing.Point(170, 120);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(203, 13);
			this.label8.TabIndex = 14;
			this.label8.Text = "-  Advanced Features and Free Upgrades";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(484, 261);
			base.Controls.Add(this.label8);
			base.Controls.Add(this.lblSupportLink);
			base.Controls.Add(this.label7);
			base.Controls.Add(this.btnFreeTrial);
			base.Controls.Add(this.btnBuyNow);
			base.Controls.Add(this.btnRegister);
			base.Controls.Add(this.tbRegCode);
			base.Controls.Add(this.tbEmail);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.pictureBoxAppIcon);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "RegistrationForm";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Registration";
			((global::System.ComponentModel.ISupportInitialize)this.pictureBoxAppIcon).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040000F5 RID: 245
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040000F6 RID: 246
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040000F7 RID: 247
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040000F8 RID: 248
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040000F9 RID: 249
		private global::System.Windows.Forms.Label label4;

		// Token: 0x040000FA RID: 250
		private global::System.Windows.Forms.Label label5;

		// Token: 0x040000FB RID: 251
		private global::System.Windows.Forms.Label label6;

		// Token: 0x040000FC RID: 252
		private global::System.Windows.Forms.TextBox tbEmail;

		// Token: 0x040000FD RID: 253
		private global::System.Windows.Forms.TextBox tbRegCode;

		// Token: 0x040000FE RID: 254
		private global::System.Windows.Forms.Button btnRegister;

		// Token: 0x040000FF RID: 255
		private global::System.Windows.Forms.Button btnBuyNow;

		// Token: 0x04000100 RID: 256
		private global::System.Windows.Forms.Button btnFreeTrial;

		// Token: 0x04000101 RID: 257
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000102 RID: 258
		private global::System.Windows.Forms.Label lblSupportLink;

		// Token: 0x04000103 RID: 259
		private global::System.Windows.Forms.PictureBox pictureBoxAppIcon;

		// Token: 0x04000104 RID: 260
		private global::System.Windows.Forms.Label label8;
	}
}
