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
	// Token: 0x0200000D RID: 13
	public partial class Get_Followings_From_User : Form
	{
		// Token: 0x06000048 RID: 72 RVA: 0x00006810 File Offset: 0x00004A10
		public Get_Followings_From_User()
		{
			this.InitializeComponent();
			this.label3.Text = "";
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00006840 File Offset: 0x00004A40
		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
			try
			{
				this.label3.Text = "Extracting...please wait";
				SignInMethodes.Driver.Navigate().GoToUrl("https://www.instagram.com/" + this.textBox1.Text + "/following/?hl=en");
				Thread.Sleep(2000);
				List<IWebElement> s = SignInMethodes.Driver.FindElements(By.CssSelector("a[role='link']")).ToList<IWebElement>();
				Thread.Sleep(1000);
				bool flag = s.Count > 0;
				if (flag)
				{
					foreach (IWebElement el in s)
					{
						bool flag2 = el.Text.Contains("following");
						if (flag2)
						{
							el.Click();
							Thread.Sleep(1000);
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
						Thread.Sleep(1000);
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
					try
					{
						IWebElement Element4 = SignInMethodes.Driver.FindElement(By.CssSelector("div[class*='x1rife3k x1n2onr6']"));
						string Source = Element4.GetAttribute("innerHTML");
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

		// Token: 0x0600004A RID: 74 RVA: 0x00006D2C File Offset: 0x00004F2C
		private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			SignInMethodes.Driver.Navigate().GoToUrl("https://www.instagram.com/");
			Thread.Sleep(1000);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00006D50 File Offset: 0x00004F50
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

		// Token: 0x0600004C RID: 76 RVA: 0x00006DA4 File Offset: 0x00004FA4
		private void Get_Followings_From_User_Load(object sender, EventArgs e)
		{
			base.Icon = Icon.ExtractAssociatedIcon(AppDomain.CurrentDomain.FriendlyName);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00006DC0 File Offset: 0x00004FC0
		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00006E14 File Offset: 0x00005014
		private void button2_Click(object sender, EventArgs e)
		{
			this.stop = true;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00006E1E File Offset: 0x0000501E
		private void button3_Click(object sender, EventArgs e)
		{
			this.listBox1.Items.Clear();
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00006E34 File Offset: 0x00005034
		private void button4_Click(object sender, EventArgs e)
		{
			SaveFileDialog SFD = new SaveFileDialog();
			SFD.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
			SFD.FileName = "followings.txt";
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

		// Token: 0x04000041 RID: 65
		public bool stop = false;
	}
}
