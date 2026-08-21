using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace MASAInstaPilot
{
	// Token: 0x02000010 RID: 16
	public partial class OneClickFollow_Unfollow : Form
	{
		// Token: 0x060000BA RID: 186 RVA: 0x00010084 File Offset: 0x0000E284
		public OneClickFollow_Unfollow()
		{
			this.InitializeComponent();
		}

		// Token: 0x060000BB RID: 187 RVA: 0x0001009C File Offset: 0x0000E29C
		private void btn_Import_Click(object sender, EventArgs e)
		{
			OpenFileDialog open = new OpenFileDialog();
			open.Title = "choose your file";
			open.Filter = "Txt Files |*.txt";
			open.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			DialogResult file = open.ShowDialog();
			bool flag = file == DialogResult.OK;
			if (flag)
			{
				SignInMethodes.ReadFile(open.FileName, OneClickFollow_Unfollow.usersOneClick);
				foreach (string name in OneClickFollow_Unfollow.usersOneClick)
				{
					this.list_follow.Items.Add(name);
				}
			}
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00010218 File Offset: 0x0000E418
		private void button3_Click(object sender, EventArgs e)
		{
			bool flag = this.list_follow.Items.Count > 0;
			if (flag)
			{
				this.list_follow.Items.Clear();
				OneClickFollow_Unfollow.usersOneClick.Clear();
			}
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0001025C File Offset: 0x0000E45C
		private void button2_Click(object sender, EventArgs e)
		{
			bool flag = this.list_follow.SelectedItem != null;
			if (flag)
			{
				this.list_follow.Items.Remove(this.list_follow.SelectedItem);
			}
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00010298 File Offset: 0x0000E498
		private void actualiser()
		{
			OneClickFollow_Unfollow.usersOneClick.Clear();
			foreach (object obj in this.list_follow.Items)
			{
				string name = (string)obj;
				OneClickFollow_Unfollow.usersOneClick.Add(name);
			}
		}

		// Token: 0x060000BF RID: 191 RVA: 0x0001030C File Offset: 0x0000E50C
		private void OneClickFollow_Unfollow_Load(object sender, EventArgs e)
		{
			base.Icon = Icon.ExtractAssociatedIcon(AppDomain.CurrentDomain.FriendlyName);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00010328 File Offset: 0x0000E528
		private void bgOneClick_DoWork(object sender, DoWorkEventArgs e)
		{
			while (!this.stopProgress)
			{
				this.label4.Text = "Action : Follow";
				int num;
				int i;
				for (i = 0; i < OneClickFollow_Unfollow.usersOneClick.Count; i = num + 1)
				{
					bool hours = this.Hours;
					if (hours)
					{
						this.lbltester.Text = "In Stop Mode Now";
						Thread.Sleep(TimeSpan.FromHours((double)(int)this.HoursStop.Value));
						this.d = DateTime.Now.AddHours((double)(int)this.HoursToWork.Value);
						this.Hours = false;
						this.lbltester.Text = "";
					}
					this.lblStatus.Invoke(new MethodInvoker(delegate
					{
						this.lblStatus.Text = (i + 1).ToString() + "/" + OneClickFollow_Unfollow.usersOneClick.Count.ToString();
					}));
					SignInMethodes.Follow(OneClickFollow_Unfollow.usersOneClick[i]);
					Thread.Sleep((int)this.numericUpDown1.Value * 1000);
					bool flag = this.stopWork;
					if (flag)
					{
						break;
					}
					num = i;
				}
				bool flag2 = !this.stopWork;
				if (flag2)
				{
					Thread.Sleep((int)this.numericUpDown2.Value * 60000);
				}
				this.label4.Text = "Action : UnFollow";
				bool flag3 = !this.stopWork;
				if (flag3)
				{
					int j;
					for (j = 0; j < OneClickFollow_Unfollow.usersOneClick.Count; j = num + 1)
					{
						bool hours2 = this.Hours;
						if (hours2)
						{
							this.lbltester.Text = "In Stop Mode Now";
							Thread.Sleep(TimeSpan.FromHours((double)(int)this.HoursStop.Value));
							this.d = DateTime.Now.AddHours((double)(int)this.HoursToWork.Value);
							this.Hours = false;
							this.lbltester.Text = "";
						}
						this.lblStatus.Invoke(new MethodInvoker(delegate
						{
							this.lblStatus.Text = (j + 1).ToString() + "/" + OneClickFollow_Unfollow.usersOneClick.Count.ToString();
						}));
						SignInMethodes.UnFollow(OneClickFollow_Unfollow.usersOneClick[j]);
						Thread.Sleep((int)this.numericUpDown1.Value * 1000);
						bool flag4 = this.stopWork;
						if (flag4)
						{
							break;
						}
						num = j;
					}
				}
			}
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x000105E4 File Offset: 0x0000E7E4
		private void btn_cut_Click(object sender, EventArgs e)
		{
			this.stopProgress = true;
			this.stopWork = true;
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x000105F8 File Offset: 0x0000E7F8
		private void button1_Click(object sender, EventArgs e)
		{
			this.d = DateTime.Now.AddHours((double)(int)this.HoursToWork.Value);
			this.lbltester.Text = this.d.ToString();
			this.stopWork = false;
			this.stopProgress = false;
			try
			{
				bool flag = !this.bgOneClick.IsBusy;
				if (flag)
				{
					bool flag2 = this.list_follow.Items.Count > 0;
					if (flag2)
					{
						this.actualiser();
						this.bgOneClick.RunWorkerAsync();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x000106BC File Offset: 0x0000E8BC
		private void bgOneClick_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			SignInMethodes.Driver.Navigate().GoToUrl("https://www.instagram.com/?hl=en");
			MessageBox.Show("Completed", "One Click", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x000106E8 File Offset: 0x0000E8E8
		private void timer1_Tick(object sender, EventArgs e)
		{
			bool flag = !this.Hours;
			if (flag)
			{
				this.lbltester.Text = DateTime.Now.ToString("hh:mm:ss");
			}
			bool flag2 = DateTime.Now.ToString() == this.d.ToString();
			if (flag2)
			{
				this.lbltester.Text = "";
				this.Hours = true;
			}
		}

		// Token: 0x040000D2 RID: 210
		private static List<string> usersOneClick = new List<string>();

		// Token: 0x040000D3 RID: 211
		private bool stopProgress;

		// Token: 0x040000D4 RID: 212
		private bool stopWork;

		// Token: 0x040000D5 RID: 213
		private bool Hours;

		// Token: 0x040000D6 RID: 214
		private DateTime d;
	}
}
