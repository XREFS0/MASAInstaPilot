using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace MASAInstaPilot
{
	// Token: 0x02000009 RID: 9
	public partial class Get_Users_From_Hashtag : Form
	{
		// Token: 0x0600001A RID: 26 RVA: 0x00003449 File Offset: 0x00001649
		public Get_Users_From_Hashtag()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00003468 File Offset: 0x00001668
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

		// Token: 0x0600001C RID: 28 RVA: 0x000034BC File Offset: 0x000016BC
		private void Get_Users_From_Hashtag_Load(object sender, EventArgs e)
		{
			base.Icon = Icon.ExtractAssociatedIcon(AppDomain.CurrentDomain.FriendlyName);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000034D8 File Offset: 0x000016D8
		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
			Get_Users_From_Hashtag.HashtagUsers = new List<string>();
			try
			{
				SignInMethodes.Driver.Navigate().GoToUrl("https://instagram.com/explore/tags/" + this.textBox1.Text + "/?hl=en");
				Thread.Sleep(5000);
				List<IWebElement> ele = SignInMethodes.Driver.FindElements(By.XPath("//*[@class='_aagu']/parent::a")).ToList<IWebElement>();
				Thread.Sleep(200);
				ele[9].Click();
				Thread.Sleep(600);
				int j;
				int i;
				for (i = 1; i <= 1000; i = j + 1)
				{
					Thread.Sleep(500);
					List<IWebElement> username = SignInMethodes.Driver.FindElements(By.CssSelector("span[class='xjp7ctv']>div>a[role='link']")).ToList<IWebElement>();
					Thread.Sleep(500);
					bool flag = username.Count > 0;
					if (flag)
					{
						this.listBox1.Invoke(new MethodInvoker(delegate
						{
							this.listBox1.Items.Add(username[0].Text);
						}));
						this.label3.Invoke(new MethodInvoker(delegate
						{
							this.label3.Text = i.ToString();
						}));
					}
					bool flag2 = this.stop || this.listBox1.Items.Count >= this.numericUpDown1.Value;
					if (flag2)
					{
						break;
					}
					Thread.Sleep(500);
					List<IWebElement> next = SignInMethodes.Driver.FindElements(By.CssSelector("div[class*='_aaqg _aaqh']>button")).ToList<IWebElement>();
					Thread.Sleep(1000);
					bool flag3 = next.Count > 0;
					if (flag3)
					{
						next[0].Click();
					}
					j = i;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			MessageBox.Show("Completed! You can save data on your PC!");
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00003704 File Offset: 0x00001904
		private void ScrollToBottom(IWebDriver driver)
		{
			Actions scrollAction = new Actions(SignInMethodes.Driver);
			scrollAction.KeyDown(OpenQA.Selenium.Keys.Control).SendKeys(OpenQA.Selenium.Keys.End).Perform();
			Thread.Sleep(1000);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00003743 File Offset: 0x00001943
		private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			SignInMethodes.Driver.Navigate().GoToUrl("https://www.instagram.com/");
			Thread.Sleep(1000);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00003768 File Offset: 0x00001968
		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000037BC File Offset: 0x000019BC
		private void button2_Click(object sender, EventArgs e)
		{
			this.stop = true;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000037C6 File Offset: 0x000019C6
		private void button3_Click(object sender, EventArgs e)
		{
			this.listBox1.Items.Clear();
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000037DC File Offset: 0x000019DC
		private void button4_Click(object sender, EventArgs e)
		{
			SaveFileDialog SFD = new SaveFileDialog();
			SFD.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
			SFD.FileName = "hashtag-users";
			bool flag = SFD.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				StreamWriter X = new StreamWriter(SFD.FileName);
				foreach (object obj in this.listBox1.Items)
				{
					string item = (string)obj;
					X.WriteLine(item);
				}
				X.Close();
				MessageBox.Show("Done");
			}
		}

		// Token: 0x0400000A RID: 10
		public static List<string> HashtagUsers = new List<string>();

		// Token: 0x0400000B RID: 11
		public bool stop = false;
	}
}
