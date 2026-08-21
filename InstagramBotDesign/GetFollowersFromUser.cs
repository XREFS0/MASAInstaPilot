using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace MASAInstaPilot
{
	// Token: 0x0200000A RID: 10
	public partial class GetFollowersFromUser : Form
	{
		// Token: 0x06000027 RID: 39 RVA: 0x000041C7 File Offset: 0x000023C7
		public GetFollowersFromUser()
		{
			this.InitializeComponent();
			this.label3.Text = "";
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000041F8 File Offset: 0x000023F8
		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
			try
			{
				this.label3.Text = "Extracting...please wait";
				Thread.Sleep(1000);
				SignInMethodes.Driver.Navigate().GoToUrl("https://www.instagram.com/" + this.textBox1.Text + "/?hl=en");
				Thread.Sleep(2000);
				List<IWebElement> s = SignInMethodes.Driver.FindElements(By.CssSelector("a[role='link']")).ToList<IWebElement>();
				bool flag = s.Count > 0;
				if (flag)
				{
					foreach (IWebElement el in s)
					{
						bool flag2 = el.Text.Contains("follower");
						if (flag2)
						{
							el.Click();
							Thread.Sleep(3500);
						}
					}
				}
				for (int a = 0; a <= (int)this.numericUpDown1.Value / 7; a++)
				{
					try
					{
						IWebElement Element2 = SignInMethodes.Driver.FindElement(By.CssSelector("div[class*='x1rife3k x1n2onr6']>div:last-child"));
						Actions clickAction = new Actions(SignInMethodes.Driver);
						clickAction.MoveToElement(Element2).Build().Perform();
					}
					catch
					{
					}
					try
					{
						IWebElement Element3 = SignInMethodes.Driver.FindElement(By.CssSelector("div[class*='xyi19xy x1ccrb07 xtf3nb5 x1pc53ja x1lliihq x1iyjqo2 xs83m0k xz65tgg x1rife3k x1n2onr6']>div:last-child"));
						Actions clickAction2 = new Actions(SignInMethodes.Driver);
						clickAction2.MoveToElement(Element3).Build().Perform();
					}
					catch
					{
					}
					Thread.Sleep(2500);
					try
					{
						IWebElement Element4 = SignInMethodes.Driver.FindElement(By.CssSelector("div[class*='x1rife3k x1n2onr6']"));
						string Source = Element4.GetAttribute("innerHTML");
						Thread.Sleep(500);
						IEnumerable<string> fileNames = from Match m in Regex.Matches(Source, "<span class=\"_ap3a _aaco _aacw _aacx _aad7 _aade\"(.*?)>(.*?)</span>")
							select m.Groups[2].Value.Split(new char[] { '<' })[0] + "\n";
						using (IEnumerator<string> enumerator2 = fileNames.GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								string t2 = enumerator2.Current;
								bool flag3 = !this.listBox1.Items.Contains(t2);
								if (flag3)
								{
									this.listBox1.Invoke(new MethodInvoker(delegate
									{
										this.listBox1.Items.Add(t2);
									}));
								}
								this.label4.Invoke(new MethodInvoker(delegate
								{
									this.label4.Text = this.listBox1.Items.Count.ToString();
								}));
							}
						}
					}
					catch
					{
					}
					Thread.Sleep(500);
					try
					{
						IWebElement Element5 = SignInMethodes.Driver.FindElement(By.CssSelector("div[class*='xyi19xy x1ccrb07 xtf3nb5 x1pc53ja x1lliihq x1iyjqo2 xs83m0k xz65tgg x1rife3k x1n2onr6']"));
						string Source2 = Element5.GetAttribute("innerHTML");
						IEnumerable<string> fileNames2 = from Match m in Regex.Matches(Source2, "<span class=\"_ap3a _aaco _aacw _aacx _aad7 _aade\"(.*?)>(.*?)</span>")
							select m.Groups[2].Value.Split(new char[] { '<' })[0] + "\n";
						using (IEnumerator<string> enumerator3 = fileNames2.GetEnumerator())
						{
							while (enumerator3.MoveNext())
							{
								string t = enumerator3.Current;
								bool flag4 = !this.listBox1.Items.Contains(t);
								if (flag4)
								{
									this.listBox1.Invoke(new MethodInvoker(delegate
									{
										this.listBox1.Items.Add(t);
									}));
								}
								this.label4.Invoke(new MethodInvoker(delegate
								{
									this.label4.Text = this.listBox1.Items.Count.ToString();
								}));
							}
						}
					}
					catch
					{
					}
					bool flag5 = this.stop || this.listBox1.Items.Count >= this.numericUpDown1.Value;
					if (flag5)
					{
						this.label3.Text = "COMPLETED!";
						break;
					}
					Thread.Sleep(2000);
				}
				this.label3.Text = "COMPLETED!";
				MessageBox.Show("Completed! You can save data on your PC!");
			}
			catch
			{
				MessageBox.Show("Session Expired. Click on RESTART button to start a new session and try again!");
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000046F0 File Offset: 0x000028F0
		private void GetFollowersFromUser_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000046F3 File Offset: 0x000028F3
		private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			SignInMethodes.Driver.Navigate().GoToUrl("https://www.instagram.com/?hl=en");
			Thread.Sleep(1000);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00004718 File Offset: 0x00002918
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

		// Token: 0x0600002C RID: 44 RVA: 0x0000476C File Offset: 0x0000296C
		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000047C0 File Offset: 0x000029C0
		private void button2_Click(object sender, EventArgs e)
		{
			this.stop = true;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000047CA File Offset: 0x000029CA
		private void button3_Click(object sender, EventArgs e)
		{
			this.listBox1.Items.Clear();
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000047E0 File Offset: 0x000029E0
		private void button4_Click(object sender, EventArgs e)
		{
			SaveFileDialog SFD = new SaveFileDialog();
			SFD.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
			SFD.FileName = "followers";
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

		// Token: 0x0400001A RID: 26
		public bool stop = false;
	}
}
