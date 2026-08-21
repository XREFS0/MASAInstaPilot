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

namespace MASAInstaPilot
{
	// Token: 0x0200000B RID: 11
	public partial class GetUsersFromPost : Form
	{
		// Token: 0x06000034 RID: 52 RVA: 0x00005306 File Offset: 0x00003506
		public GetUsersFromPost()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00005328 File Offset: 0x00003528
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

		// Token: 0x06000036 RID: 54 RVA: 0x0000537C File Offset: 0x0000357C
		private void GetUsersFromPost_Load(object sender, EventArgs e)
		{
			base.Icon = Icon.ExtractAssociatedIcon(AppDomain.CurrentDomain.FriendlyName);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00005398 File Offset: 0x00003598
		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
			try
			{
				this.label3.Text = "Extracting...please wait";
				SignInMethodes.Driver.Navigate().GoToUrl(this.textBox1.Text + "liked_by/?hl=en");
				Thread.Sleep(3000);
				for (int a = 0; a < 1; a++)
				{
					Thread.Sleep(1500);
					IWebElement Element = SignInMethodes.Driver.FindElement(By.CssSelector("main[role='main']"));
					string Source = Element.GetAttribute("innerHTML");
					IEnumerable<string> fileNames = from Match m in Regex.Matches(Source, "<span class=\"_ap3a _aaco _aacw _aacx _aad7 _aade\"(.*?)>(.*?)</span>")
						select m.Groups[2].Value + "\n";
					using (IEnumerator<string> enumerator = fileNames.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							string t = enumerator.Current;
							bool flag = !this.listBox1.Items.Contains(t);
							if (flag)
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
					bool flag2 = this.stop || this.listBox1.Items.Count >= this.numericUpDown1.Value;
					if (flag2)
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

		// Token: 0x06000038 RID: 56 RVA: 0x000055B0 File Offset: 0x000037B0
		private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			SignInMethodes.Driver.Navigate().GoToUrl("https://www.instagram.com/?hl=en");
			Thread.Sleep(1000);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000055D4 File Offset: 0x000037D4
		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00005628 File Offset: 0x00003828
		private void button4_Click(object sender, EventArgs e)
		{
			SaveFileDialog SFD = new SaveFileDialog();
			SFD.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
			SFD.FileName = "userspostlike";
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

		// Token: 0x0600003B RID: 59 RVA: 0x000056DC File Offset: 0x000038DC
		private void button3_Click(object sender, EventArgs e)
		{
			this.listBox1.Items.Clear();
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000056F0 File Offset: 0x000038F0
		private void button2_Click(object sender, EventArgs e)
		{
			this.stop = true;
		}

		// Token: 0x04000029 RID: 41
		public bool stop = false;
	}
}
