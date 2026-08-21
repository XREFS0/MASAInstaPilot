using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace MASAInstaPilot
{
	// Token: 0x0200000C RID: 12
	public partial class GetUsersFromPostByComments : Form
	{
		// Token: 0x06000040 RID: 64 RVA: 0x00006142 File Offset: 0x00004342
		public GetUsersFromPostByComments()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000041 RID: 65 RVA: 0x0000615C File Offset: 0x0000435C
		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
			try
			{
				targeting.FromComments(this.textBox1.Text, (int)this.numericUpDown1.Value);
				MessageBox.Show("Completed");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000061BC File Offset: 0x000043BC
		private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			SignInMethodes.Driver.Navigate().GoToUrl("https://www.instagram.com/");
			Thread.Sleep(1000);
			bool flag = this.save.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				targeting.Save(this.save.FileName, (int)this.numericUpDown1.Value, ByHashTag.HashtagUsers);
			}
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00006224 File Offset: 0x00004424
		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = !this.backgroundWorker1.IsBusy;
				if (flag)
				{
					this.backgroundWorker1.RunWorkerAsync();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00006278 File Offset: 0x00004478
		private void GetUsersFromPostByComments_Load(object sender, EventArgs e)
		{
			base.Icon = Icon.ExtractAssociatedIcon(AppDomain.CurrentDomain.FriendlyName);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00006294 File Offset: 0x00004494
		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
		}
	}
}
