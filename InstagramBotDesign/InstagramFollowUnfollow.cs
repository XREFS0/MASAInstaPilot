using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using MASAInstaPilot.Properties;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace MASAInstaPilot
{
	// Token: 0x0200000F RID: 15
	public partial class InstagramFollowUnfollow : Form
	{
		// Token: 0x06000059 RID: 89 RVA: 0x000080B4 File Offset: 0x000062B4
		private void actualiser()
		{
			SignInMethodes.names.Clear();
			foreach (object obj in this.list_follow.Items)
			{
				string name = (string)obj;
				SignInMethodes.names.Add(name);
			}
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00008128 File Offset: 0x00006328
		[DebuggerStepThrough]
		private async void SoftBlink(Control ctrl, Color c1, Color c2, short CycleTime_ms, bool BkClr)
		{
			while (true)
			{
				int half = CycleTime_ms / 10;
				for (int i = 0; i < 10; i++)
				{
					int r = c1.R + (c2.R - c1.R) * i / 10;
					int g = c1.G + (c2.G - c1.G) * i / 10;
					int b = c1.B + (c2.B - c1.B) * i / 10;
					if (BkClr)
						ctrl.BackColor = Color.FromArgb(r, g, b);
					else
						ctrl.ForeColor = Color.FromArgb(r, g, b);
					await System.Threading.Tasks.Task.Delay(half);
				}
				for (int i = 10; i > 0; i--)
				{
					int r = c1.R + (c2.R - c1.R) * i / 10;
					int g = c1.G + (c2.G - c1.G) * i / 10;
					int b = c1.B + (c2.B - c1.B) * i / 10;
					if (BkClr)
						ctrl.BackColor = Color.FromArgb(r, g, b);
					else
						ctrl.ForeColor = Color.FromArgb(r, g, b);
					await System.Threading.Tasks.Task.Delay(half);
				}
			}
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00008188 File Offset: 0x00006388
		public InstagramFollowUnfollow()
		{
			this.InitializeComponent();
			this.GetEmojiList();
			Control.CheckForIllegalCrossThreadCalls = false;
			this.SoftBlink(this.button9, Color.FromArgb(35, 35, 42), Color.FromArgb(79, 70, 229), 1500, true);
		}

		// Token: 0x0600005C RID: 92
		[DllImport("User32.dll")]
		private static extern int SendMessage(int Handle, int wMsg, int wParam, int lParam);

		// Token: 0x0600005F RID: 95 RVA: 0x00008302 File Offset: 0x00006502
		private void lblClose_MouseHover(object sender, EventArgs e)
		{
			this.lblClose.BackColor = Color.Gray;
			this.lblClose.Cursor = Cursors.Hand;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00008327 File Offset: 0x00006527
		private void lblClose_MouseLeave(object sender, EventArgs e)
		{
			this.lblClose.BackColor = Color.FromArgb(55, 55, 65);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x0000833B File Offset: 0x0000653B
		private void lblMinus_MouseHover(object sender, EventArgs e)
		{
			this.lblMinus.BackColor = Color.Gray;
			this.lblMinus.Cursor = Cursors.Hand;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00008360 File Offset: 0x00006560
		private void lblMinus_MouseLeave(object sender, EventArgs e)
		{
			this.lblMinus.BackColor = Color.FromArgb(55, 55, 65);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00008374 File Offset: 0x00006574
		private void txt_Email_TextChanged(object sender, EventArgs e)
		{
			bool flag = Regex.IsMatch(this.txt_Email.Text, "^\\s*$") || Regex.IsMatch(this.txt_Password.Text, "^\\s*$");
			if (flag)
			{
				this.btn_SignIn.Enabled = false;
			}
			else
			{
				this.btn_SignIn.Enabled = true;
			}
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000083D4 File Offset: 0x000065D4
		private void txt_Email_Click(object sender, EventArgs e)
		{
			bool flag = this.txt_Email.Text == "Email/Username";
			if (flag)
			{
				this.txt_Email.Clear();
			}
			else
			{
				bool flag2 = this.txt_Email.Text != "";
				if (flag2)
				{
					this.txt_Email.SelectAll();
				}
			}
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00008430 File Offset: 0x00006630
		private void txt_Password_Click(object sender, EventArgs e)
		{
			bool flag = this.txt_Password.Text == "Password";
			if (flag)
			{
				this.txt_Password.Clear();
			}
			else
			{
				bool flag2 = this.txt_Password.Text != "";
				if (flag2)
				{
					this.txt_Password.SelectAll();
				}
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x0000848A File Offset: 0x0000668A
		private void btn_SignIn_Click(object sender, EventArgs e)
		{
			SignInMethodes.Th = new Thread(new ThreadStart(this.Login));
			SignInMethodes.Th.Start();
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000084B0 File Offset: 0x000066B0
		private void Login()
		{
			ChromeOptions options = new ChromeOptions();
			string[] _user = WindowsIdentity.GetCurrent().Name.Split(new char[] { '\\' });
			options.AddArgument(string.Format("user-data-dir=C:\\Users\\{0}\\AppData\\Local\\Google\\Chrome\\User Data\\Default", _user[1]));
			this.CloseAllSelenium();
			try
			{
				SignInMethodes.Driver = new ChromeDriver(options);
			}
			catch
			{
			}
			SignInMethodes.Driver.Manage().Window.Maximize();
			SignInMethodes.Driver.Navigate().GoToUrl("https://www.instagram.com/accounts/login/");
			Thread.Sleep(1000);
			this.lblConnection.Text = "Loading app... Please Wait....";
			List<IWebElement> Cookies = SignInMethodes.Driver.FindElements(By.CssSelector("button[class='aOOlW  bIiDR  ']")).ToList<IWebElement>();
			bool flag = Cookies.Count > 0;
			if (flag)
			{
				Cookies[0].Click();
			}
			Thread.Sleep(500);
			SignInMethodes.Username = this.txt_Email.Text;
			SignInMethodes.Password = this.txt_Password.Text;
			try
			{
				IWebElement user = SignInMethodes.Driver.FindElement(By.Name("username"));
				user.SendKeys(SignInMethodes.Username);
				Thread.Sleep(2000);
				IWebElement pass = SignInMethodes.Driver.FindElement(By.Name("password"));
				pass.SendKeys(SignInMethodes.Password);
				Thread.Sleep(2000);
				SignInMethodes.Driver.FindElement(By.CssSelector("button[class='sqdOP  L3NKy   y3zKF     ']")).Click();
				Thread.Sleep(2000);
				List<IWebElement> FirstNotNow = SignInMethodes.Driver.FindElements(By.CssSelector("div[class='cmbtv']")).ToList<IWebElement>();
				Thread.Sleep(1500);
				bool flag2 = FirstNotNow.Count > 0;
				if (flag2)
				{
					Thread.Sleep(1000);
					FirstNotNow[0].Click();
				}
				bool flag3 = SignInMethodes.Driver.Url == "https://www.instagram.com/";
				if (flag3)
				{
					Settings.Default.email = this.txt_Email.Text;
					bool @checked = this.checkremamber.Checked;
					if (@checked)
					{
						Settings.Default.password = this.txt_Password.Text;
					}
					else
					{
						Settings.Default.password = "";
					}
					Settings.Default.Save();
					List<IWebElement> NotNow = SignInMethodes.Driver.FindElements(By.CssSelector("button[class='aOOlW   HoLwm ']")).ToList<IWebElement>();
					bool flag4 = NotNow.Count > 0;
					if (flag4)
					{
						NotNow[0].Click();
					}
					Thread.Sleep(1000);
					this.btn_SignIn.Enabled = false;
					this.panel2.Visible = false;
					this.gb_LikeComment.Visible = true;
					this.button9.Text = "Ready";
					this.button9.Enabled = false;
					this.button10.Enabled = true;
				}
				else
				{
					this.lblConnection.Text = "Please refresh the page";
					MessageBox.Show("The username Or Password you entered doesn't belong to an account.\nPlease check your username\nClick the Refresh Button\nand try again.", "Not Connected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00008818 File Offset: 0x00006A18
		private void InstagramFollowUnfollow_Load(object sender, EventArgs e)
		{
			try
			{
				base.Icon = Icon.ExtractAssociatedIcon(AppDomain.CurrentDomain.FriendlyName);
				string corent_email = Settings.Default.email;
				string corent_pass = Settings.Default.password;
				bool flag = corent_email != "";
				if (flag)
				{
					this.txt_Email.Text = corent_email;
				}
				bool flag2 = corent_pass != "";
				if (flag2)
				{
					this.txt_Password.Text = corent_pass;
					this.txt_Password.PasswordChar = '*';
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000088CC File Offset: 0x00006ACC
		private void button1_Click(object sender, EventArgs e)
		{
			this.openFileDialog1.Title = "choose your file";
			this.openFileDialog1.Filter = "Txt Files |*.txt";
			this.openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			DialogResult file = this.openFileDialog1.ShowDialog();
			bool flag = file == DialogResult.OK;
			if (flag)
			{
				SignInMethodes.ReadFile(this.openFileDialog1.FileName, SignInMethodes.names);
				foreach (string name in SignInMethodes.names)
				{
					bool flag2 = !name.Contains(" ") && name != "";
					if (flag2)
					{
						this.list_follow.Items.Add(name.Replace("@", ""));
					}
				}
			}
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00008AD4 File Offset: 0x00006CD4
		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			this.move = 1;
			this.moveX = e.X;
			this.moveY = e.Y;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00008AF6 File Offset: 0x00006CF6
		private void txt_Password_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.txt_Password.PasswordChar = '*';
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00008B08 File Offset: 0x00006D08
		private void InstagramFollowUnfollow_FormClosing(object sender, FormClosingEventArgs e)
		{
			try
			{
				SignInMethodes.Driver.Quit();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00008B3C File Offset: 0x00006D3C
		private void lblClose_Click(object sender, EventArgs e)
		{
			DialogResult d = MessageBox.Show("Are you sure you want to close the app?", "Close Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
			bool flag = d == DialogResult.Yes;
			if (flag)
			{
				Application.Exit();
			}
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00008B70 File Offset: 0x00006D70
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			bool flag = Regex.IsMatch(this.textBox1.Text, "^\\s*$");
			if (flag)
			{
				this.button1.Enabled = false;
			}
			else
			{
				this.button1.Enabled = true;
			}
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00008BB4 File Offset: 0x00006DB4
		private void button1_Click_1(object sender, EventArgs e)
		{
			bool flag = !this.textBox1.Text.Contains(" ") && this.textBox1.Text != "";
			if (flag)
			{
				this.list_follow.Items.Add(this.textBox1.Text.Replace("@", ""));
			}
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00008C20 File Offset: 0x00006E20
		private void button2_Click(object sender, EventArgs e)
		{
			bool flag = this.list_follow.SelectedItem != null;
			if (flag)
			{
				this.list_follow.Items.Remove(this.list_follow.SelectedItem);
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00008C5C File Offset: 0x00006E5C
		private void textBox1_Click(object sender, EventArgs e)
		{
			this.textBox1.Clear();
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00008C6C File Offset: 0x00006E6C
		private void btn_Follow_Click(object sender, EventArgs e)
		{
			this.stop = false;
			this.follow = true;
			try
			{
				bool isBusy = this.bgWork.IsBusy;
				if (isBusy)
				{
					this.lblWorking.Text = "Working....";
				}
				else
				{
					bool flag = this.FollowUnfollowDelay.Value < this.FollowUnfollowDelay1.Value;
					if (flag)
					{
						this.lblWorking.Text = "";
						bool flag2 = this.list_follow.Items.Count > 0;
						if (flag2)
						{
							this.actualiser();
							this.bgWork.RunWorkerAsync();
						}
					}
					else
					{
						MessageBox.Show("The Delay On the left Must be less on the right one", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00008D50 File Offset: 0x00006F50
		private void bgWork_DoWork(object sender, DoWorkEventArgs e)
		{
			bool flag = this.follow;
			if (flag)
			{
				this.btn_Unfollow.Enabled = false;
				this.lblWorking.Text = "Working...please wait";
				this.lblWorking.ForeColor = Color.FromArgb(239, 68, 68);
				int j;
				int i;
				for (i = 0; i < SignInMethodes.names.Count; i = j + 1)
				{
					this.list_follow.SelectedItem = this.list_follow.Items[i];
					int delay = this.random.Next((int)this.FollowUnfollowDelay.Value, (int)this.FollowUnfollowDelay1.Value);
					this.lblStatus.Invoke(new MethodInvoker(delegate
					{
						this.lblStatus.Text = (i + 1).ToString() + "/" + SignInMethodes.names.Count.ToString();
					}));
					SignInMethodes.Follow(SignInMethodes.names[i]);
					Thread.Sleep(delay * 1000);
					bool flag2 = this.stop;
					if (flag2)
					{
						break;
					}
					j = i;
				}
			}
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00008E7C File Offset: 0x0000707C
		private void bgWork_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			this.lblWorking.Text = "Complete";
			this.lblWorking.ForeColor = Color.FromArgb(16, 185, 129);
			this.btn_Unfollow.Enabled = true;
			this.btn_Follow.Enabled = true;
			SignInMethodes.Driver.Navigate().GoToUrl("https://www.instagram.com/?hl=en");
			this.button2.Enabled = true;
			this.follow = false;
			this.getfromhash = false;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00008EF8 File Offset: 0x000070F8
		private void button3_Click(object sender, EventArgs e)
		{
			bool flag = this.stop;
			if (flag)
			{
				this.stop = false;
			}
			else
			{
				this.stop = true;
			}
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00008F20 File Offset: 0x00007120
		private void bgWorkerUnfollow_DoWork(object sender, DoWorkEventArgs e)
		{
			this.btn_Follow.Enabled = false;
			int i;
			int j;
			for (i = 0; i < SignInMethodes.names.Count; i = j + 1)
			{
				this.list_follow.SelectedItem = this.list_follow.Items[i];
				int delay = this.random.Next((int)this.FollowUnfollowDelay.Value, (int)this.FollowUnfollowDelay1.Value);
				this.lblStatus.Invoke(new MethodInvoker(delegate
				{
					this.lblStatus.Text = (i + 1).ToString() + "/" + SignInMethodes.names.Count.ToString();
				}));
				SignInMethodes.UnFollow(SignInMethodes.names[i]);
				Thread.Sleep(delay * 1000);
				bool flag = this.stop;
				if (flag)
				{
					break;
				}
				j = i;
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00009018 File Offset: 0x00007218
		private void btn_Unfollow_Click(object sender, EventArgs e)
		{
			this.stop = false;
			try
			{
				bool isBusy = this.bgWorkerUnfollow.IsBusy;
				if (isBusy)
				{
					this.lblWorking.Text = "Working....";
				}
				else
				{
					bool flag = this.FollowUnfollowDelay.Value < this.FollowUnfollowDelay1.Value;
					if (flag)
					{
						this.lblWorking.Text = "";
						bool flag2 = this.list_follow.Items.Count > 0;
						if (flag2)
						{
							this.actualiser();
							this.bgWorkerUnfollow.RunWorkerAsync();
						}
					}
					else
					{
						MessageBox.Show("The Delay On the left Must be less on the right one", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x06000078 RID: 120 RVA: 0x000090F8 File Offset: 0x000072F8
		private void btn_Direct_Click(object sender, EventArgs e)
		{
			this.stop = false;
			try
			{
				bool isBusy = this.bgWorkerDirect.IsBusy;
				if (isBusy)
				{
					this.lblWorking.Text = "Working....";
				}
				else
				{
					bool flag = this.FollowUnfollowDelay.Value < this.FollowUnfollowDelay1.Value;
					if (flag)
					{
						this.lblWorking.Text = "";
						bool flag2 = this.list_follow.Items.Count > 0;
						if (flag2)
						{
							this.actualiser();
							this.bgWorkerDirect.RunWorkerAsync();
						}
					}
					else
					{
						MessageBox.Show("The Delay On the left Must be less on the right one", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x000091D8 File Offset: 0x000073D8
		private string EncodeNonBMP(string input)
		{
			StringBuilder sb = new StringBuilder();
			foreach (char c in input)
			{
				bool flag = !char.IsSurrogate(c);
				if (flag)
				{
					sb.Append(c);
				}
				else
				{
					sb.Append(' ');
				}
			}
			return sb.ToString();
		}

		// Token: 0x0600007A RID: 122 RVA: 0x0000923C File Offset: 0x0000743C
		private void bgWorkerDirect_DoWork(object sender, DoWorkEventArgs e)
		{
			this.btn_Direct.Enabled = false;
			int i;
			int j;
			for (i = 0; i < SignInMethodes.names.Count; i = j + 1)
			{
				this.list_follow.SelectedItem = this.list_follow.Items[i];
				int delay = this.random.Next((int)this.FollowUnfollowDelay.Value, (int)this.FollowUnfollowDelay1.Value);
				this.lblStatus.Invoke(new MethodInvoker(delegate
				{
					this.lblStatus.Text = (i + 1).ToString() + "/" + SignInMethodes.names.Count.ToString();
				}));
				SignInMethodes.Direct(SignInMethodes.names[i], this.textBox2.Text);
				Thread.Sleep(delay * 1000);
				bool flag = this.stop;
				if (flag)
				{
					break;
				}
				j = i;
			}
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00009340 File Offset: 0x00007540
		private void btn_Start_Click(object sender, EventArgs e)
		{
			ByName.Stop = false;
			this.btn_cut.Enabled = true;
			bool isBusy = this.bgWorkLike.IsBusy;
			if (isBusy)
			{
				this.lblS.Text = "Working...";
				this.label15.Text = "Processing...";
			}
			else
			{
				bool flag = this.list_Comments.Items.Count > 0;
				if (flag)
				{
					InstagramFollowUnfollow.Comments.Clear();
					foreach (object obj in this.list_Comments.Items)
					{
						string s = (string)obj;
						InstagramFollowUnfollow.Comments.Add(s);
					}
				}
				else
				{
					InstagramFollowUnfollow.Comments.Add("Comment");
				}
				this.bgWorkLike.RunWorkerAsync();
			}
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00009438 File Offset: 0x00007638
		private void bgWorkLike_DoWork(object sender, DoWorkEventArgs e)
		{
			bool isBusy = this.bgWorkLike.IsBusy;
			if (isBusy)
			{
				this.label15.Text = "Working...";
			}
			bool flag = this.by;
			if (flag)
			{
				ByName.like(this.txt_UserOrHashtag.Text, this.rdo_Like.Checked, this.rdo_Unlike.Checked, this.rdo_Comment.Checked, InstagramFollowUnfollow.Comments, this.random.Next((int)this.delay.Value, (int)this.delay1.Value));
			}
			else
			{
				bool flag2 = this.by1;
				if (flag2)
				{
					for (int i = 0; i < this.list_follow.Items.Count; i++)
					{
						this.list_follow.SelectedItem = this.list_follow.Items[i];
						ByName1.like(this.list_follow.Items[i].ToString(), this.rdo_Like.Checked, this.rdo_Unlike.Checked, this.rdo_Comment.Checked, InstagramFollowUnfollow.Comments, this.random.Next((int)this.delay.Value, (int)this.delay1.Value));
						bool flag3 = ByName.Stop;
						if (flag3)
						{
							break;
						}
					}
				}
				else
				{
					this.list_follow.Items.Clear();
					bool flag4 = this.txt_UserOrHashtag.Text.Contains(',');
					if (flag4)
					{
						try
						{
							string AA = this.txt_UserOrHashtag.Text.Split(new char[] { ',' })[0].Replace(" ", "");
							ByHashtag1.LikeLoop(AA, this.rdo_Like.Checked, this.rdo_Unlike.Checked, this.rdo_Comment.Checked, InstagramFollowUnfollow.Comments, this.rdo_Follow.Checked, this.rdo_Unfollow.Checked, this.random.Next((int)this.delay.Value, (int)this.delay1.Value), ByName.Stop);
						}
						catch
						{
						}
						try
						{
							string BB = this.txt_UserOrHashtag.Text.Split(new char[] { ',' })[1].Replace(" ", "");
							ByHashtag1.LikeLoop(BB, this.rdo_Like.Checked, this.rdo_Unlike.Checked, this.rdo_Comment.Checked, InstagramFollowUnfollow.Comments, this.rdo_Follow.Checked, this.rdo_Unfollow.Checked, this.random.Next((int)this.delay.Value, (int)this.delay1.Value), ByName.Stop);
						}
						catch
						{
						}
						try
						{
							string CC = this.txt_UserOrHashtag.Text.Split(new char[] { ',' })[2].Replace(" ", "");
							ByHashtag1.LikeLoop(CC, this.rdo_Like.Checked, this.rdo_Unlike.Checked, this.rdo_Comment.Checked, InstagramFollowUnfollow.Comments, this.rdo_Follow.Checked, this.rdo_Unfollow.Checked, this.random.Next((int)this.delay.Value, (int)this.delay1.Value), ByName.Stop);
						}
						catch
						{
						}
						try
						{
							string DD = this.txt_UserOrHashtag.Text.Split(new char[] { ',' })[3].Replace(" ", "");
							ByHashtag1.LikeLoop(DD, this.rdo_Like.Checked, this.rdo_Unlike.Checked, this.rdo_Comment.Checked, InstagramFollowUnfollow.Comments, this.rdo_Follow.Checked, this.rdo_Unfollow.Checked, this.random.Next((int)this.delay.Value, (int)this.delay1.Value), ByName.Stop);
						}
						catch
						{
						}
					}
					else
					{
						ByHashtag1.LikeLoop(this.txt_UserOrHashtag.Text, this.rdo_Like.Checked, this.rdo_Unlike.Checked, this.rdo_Comment.Checked, InstagramFollowUnfollow.Comments, this.rdo_Follow.Checked, this.rdo_Unfollow.Checked, this.random.Next((int)this.delay.Value, (int)this.delay1.Value), ByName.Stop);
					}
				}
			}
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00009944 File Offset: 0x00007B44
		private void ScrollToBottom(IWebDriver driver)
		{
			Actions scrollAction = new Actions(SignInMethodes.Driver);
			scrollAction.KeyDown(OpenQA.Selenium.Keys.Control).SendKeys(OpenQA.Selenium.Keys.End).Perform();
			Thread.Sleep(1000);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00009984 File Offset: 0x00007B84
		private void button3_Click_1(object sender, EventArgs e)
		{
			bool flag = this.list_follow.Items.Count > 0;
			if (flag)
			{
				this.list_follow.Items.Clear();
				SignInMethodes.names.Clear();
			}
		}

		// Token: 0x0600007F RID: 127 RVA: 0x000099C7 File Offset: 0x00007BC7
		private void txt_UserOrHashtag_Click(object sender, EventArgs e)
		{
			this.txt_UserOrHashtag.Clear();
		}

		// Token: 0x06000080 RID: 128 RVA: 0x000099D6 File Offset: 0x00007BD6
		private void txt_Comment_Click(object sender, EventArgs e)
		{
			this.txt_Comment.Clear();
		}

		// Token: 0x06000081 RID: 129 RVA: 0x000099E8 File Offset: 0x00007BE8
		private void txt_UserOrHashtag_TextChanged(object sender, EventArgs e)
		{
			bool flag = !Regex.IsMatch(this.txt_UserOrHashtag.Text, "^\\s*$");
			if (flag)
			{
				this.rdo_Like.Enabled = true;
				this.rdo_Unlike.Enabled = true;
				this.rdo_Comment.Enabled = true;
			}
			else
			{
				this.rdo_Like.Enabled = false;
				this.rdo_Unlike.Enabled = false;
				this.rdo_Comment.Enabled = false;
			}
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00009A66 File Offset: 0x00007C66
		private void btn_cut_Click(object sender, EventArgs e)
		{
			SignInMethodes.Driver.Navigate().GoToUrl("https://www.instagram.com");
			this.label15.Text = "Completed";
			ByName.Stop = true;
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00009A95 File Offset: 0x00007C95
		private void bgWorkLike_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			this.label15.Text = "Completed";
			this.btn_cut.Enabled = false;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00009AB8 File Offset: 0x00007CB8
		private void btn_Refresh_Click(object sender, EventArgs e)
		{
			string user = Environment.UserName;
			string seleniumProfile = "C:\\Users\\" + user + "\\AppData\\Local\\MyApp\\IGProfile";
			ChromeOptions options = new ChromeOptions();
			options.AddArgument("--user-data-dir=" + seleniumProfile);
			options.AddArgument("--profile-directory=Default");
			options.AddExcludedArgument("enable-automation");
			options.AddAdditionalOption("useAutomationExtension", false);
			ChromeDriverService service = ChromeDriverService.CreateDefaultService();
			service.HideCommandPromptWindow = true;
			SignInMethodes.Driver = new ChromeDriver(service, options);
			bool flag = SignInMethodes.Driver == null;
			if (!flag)
			{
				SignInMethodes.Driver.Manage().Window.Maximize();
				SignInMethodes.Driver.Navigate().GoToUrl("https://www.instagram.com/");
				Thread.Sleep(1000);
				this.panel2.Visible = false;
				this.button9.Text = "Ready";
				this.button9.Enabled = false;
				this.button10.Enabled = true;
			}
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00009BB8 File Offset: 0x00007DB8
		private void CloseAllSelenium()
		{
			bool ProcessIsRunning;
			do
			{
				ProcessIsRunning = true;
				Process[] processes = Process.GetProcesses();
				for (int i = 0; i < processes.Length; i++)
				{
					bool flag = processes[i].ProcessName == "chrome" || processes[i].ProcessName == "chromedriver";
					if (flag)
					{
						processes[i].Kill();
						processes[i].WaitForExit();
						Thread.Sleep(500);
						Application.DoEvents();
						ProcessIsRunning = false;
						break;
					}
				}
			}
			while (!ProcessIsRunning);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00009C48 File Offset: 0x00007E48
		private void rdo_ByHashtag_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.rdo_ByHashtag.Checked;
			if (@checked)
			{
				this.pnl_FollowHashtag.Visible = true;
				this.by = false;
				this.by1 = false;
				this.btn_Start.Enabled = true;
			}
			else
			{
				this.pnl_FollowHashtag.Visible = false;
				this.btn_Start.Enabled = false;
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00009CB0 File Offset: 0x00007EB0
		private void rdo_ByName_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.rdo_ByName.Checked;
			if (@checked)
			{
				this.by = true;
				this.by1 = false;
				this.btn_Start.Enabled = true;
			}
			else
			{
				this.btn_Start.Enabled = false;
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00009CFC File Offset: 0x00007EFC
		private void bgWorkLike_RunWorkerCompleted_1(object sender, RunWorkerCompletedEventArgs e)
		{
			this.btn_cut.Enabled = false;
			this.label15.Text = "Completed";
			this.lblS.Text = "Completed";
			this.lblS.ForeColor = Color.FromArgb(16, 185, 129);
			SignInMethodes.Driver.Navigate().GoToUrl("https://www.instagram.com/");
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00009D5F File Offset: 0x00007F5F
		private void lblMinus_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00009D6C File Offset: 0x00007F6C
		private void GetFromHashtag_Click(object sender, EventArgs e)
		{
			Get_Users_From_Hashtag f = new Get_Users_From_Hashtag();
			f.ShowDialog();
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00009D88 File Offset: 0x00007F88
		private void btn_UsersByLike_Click(object sender, EventArgs e)
		{
			GetUsersFromPost f = new GetUsersFromPost();
			f.ShowDialog();
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00009DA4 File Offset: 0x00007FA4
		private void btn_GetUsersByComment_Click(object sender, EventArgs e)
		{
			GetUsersFromPostByComments f = new GetUsersFromPostByComments();
			f.ShowDialog();
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00009DC0 File Offset: 0x00007FC0
		private void button4_Click(object sender, EventArgs e)
		{
			bool flag = !Regex.IsMatch(this.txt_Comment.Text, "^\\s*$");
			if (flag)
			{
				this.list_Comments.Items.Add(this.txt_Comment.Text);
			}
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00009E08 File Offset: 0x00008008
		private void rdo_Comment_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.list_Comments.Items.Count == 0;
			if (flag)
			{
				MessageBox.Show("Please add a comment first!");
				this.rdo_Comment.Checked = false;
			}
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00009E48 File Offset: 0x00008048
		private void button5_Click(object sender, EventArgs e)
		{
			bool flag = this.list_Comments.SelectedItem != null;
			if (flag)
			{
				this.list_Comments.Items.Remove(this.list_Comments.SelectedItem);
			}
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00009E84 File Offset: 0x00008084
		private void button6_Click(object sender, EventArgs e)
		{
			this.panel2.Visible = false;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00009E94 File Offset: 0x00008094
		private void btn_FollowersFromUser_Click(object sender, EventArgs e)
		{
			GetFollowersFromUser f = new GetFollowersFromUser();
			f.ShowDialog();
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00009EB0 File Offset: 0x000080B0
		private void button7_Click(object sender, EventArgs e)
		{
			this.txt_Comment.Clear();
			this.txt_UserOrHashtag.Clear();
			this.list_Comments.Items.Clear();
			this.rdo_ByHashtag.Checked = false;
			this.rdo_ByName.Checked = false;
			this.rdo_Comment.Checked = false;
			this.rdo_Follow.Checked = false;
			this.rdo_Unfollow.Checked = false;
			this.rdo_Like.Checked = false;
			this.rdo_Unlike.Checked = false;
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00009F44 File Offset: 0x00008144
		private void oneClick_DoWork(object sender, DoWorkEventArgs e)
		{
			for (int i = 0; i < SignInMethodes.names.Count; i++)
			{
				SignInMethodes.Follow(SignInMethodes.names[i]);
				Thread.Sleep((int)this.FollowUnfollowDelay.Value * 1000);
				bool flag = this.stop;
				if (flag)
				{
					break;
				}
			}
			Thread.Sleep(20000);
			for (int j = 0; j < SignInMethodes.names.Count; j++)
			{
				SignInMethodes.UnFollow(SignInMethodes.names[j]);
				Thread.Sleep((int)this.FollowUnfollowDelay.Value * 1000);
				bool flag2 = this.stop;
				if (flag2)
				{
					break;
				}
			}
		}

		// Token: 0x06000094 RID: 148 RVA: 0x0000A009 File Offset: 0x00008209
		private void oneClick_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			SignInMethodes.Driver.Navigate().GoToUrl("https://www.instagram.com/");
		}

		// Token: 0x06000095 RID: 149 RVA: 0x0000A024 File Offset: 0x00008224
		private void one_click_Click(object sender, EventArgs e)
		{
			OneClickFollow_Unfollow f = new OneClickFollow_Unfollow();
			f.ShowDialog();
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0000A040 File Offset: 0x00008240
		private void Get_Followings_btn_Click(object sender, EventArgs e)
		{
			Get_Followings_From_User frm = new Get_Followings_From_User();
			frm.ShowDialog();
		}

		// Token: 0x06000097 RID: 151 RVA: 0x0000A05C File Offset: 0x0000825C
		private void GetHelpBtn_Click(object sender, EventArgs e)
		{
			HelpForm frm = new HelpForm();
			frm.ShowDialog();
		}

		// Token: 0x06000098 RID: 152 RVA: 0x0000A078 File Offset: 0x00008278
		private void FollowUnfollowDelay1_ValueChanged(object sender, EventArgs e)
		{
			bool flag = this.FollowUnfollowDelay.Value > this.FollowUnfollowDelay1.Value && this.FollowUnfollowDelay.Value != 120m;
			if (flag)
			{
				this.FollowUnfollowDelay1.Value = this.FollowUnfollowDelay.Value + 1m;
			}
			else
			{
				bool flag2 = this.FollowUnfollowDelay.Value == 120m;
				if (flag2)
				{
					this.FollowUnfollowDelay1.Value = 120m;
				}
			}
		}

		// Token: 0x06000099 RID: 153 RVA: 0x0000A114 File Offset: 0x00008314
		private void delay1_ValueChanged(object sender, EventArgs e)
		{
			bool flag = this.delay.Value > this.delay1.Value && this.delay.Value != 120m;
			if (flag)
			{
				this.delay1.Value = this.delay.Value + 1m;
			}
			else
			{
				bool flag2 = this.delay.Value == 120m;
				if (flag2)
				{
					this.delay1.Value = 120m;
				}
			}
		}

		// Token: 0x0600009A RID: 154 RVA: 0x0000A1AE File Offset: 0x000083AE
		private void button8_Click(object sender, EventArgs e)
		{
			Process.Start("");
		}

		// Token: 0x0600009B RID: 155 RVA: 0x0000A1BC File Offset: 0x000083BC
		private void label4_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600009C RID: 156 RVA: 0x0000A1BF File Offset: 0x000083BF
		private void lblStatus_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0000A1C2 File Offset: 0x000083C2
		private void groupBox1_Enter(object sender, EventArgs e)
		{
		}

		// Token: 0x0600009E RID: 158 RVA: 0x0000A1C5 File Offset: 0x000083C5
		private void gb_LikeComment_Enter(object sender, EventArgs e)
		{
		}

		// Token: 0x0600009F RID: 159 RVA: 0x0000A1C8 File Offset: 0x000083C8
		private void lblWorking_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x0000A1CC File Offset: 0x000083CC
		private void list_follow_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = this.list_follow.Items.Count > 0;
			if (flag)
			{
				this.btn_Follow.Enabled = true;
				this.btn_Unfollow.Enabled = true;
			}
			else
			{
				this.btn_Follow.Enabled = false;
				this.btn_Unfollow.Enabled = false;
			}
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x0000A22C File Offset: 0x0000842C
		private void button9_Click(object sender, EventArgs e)
		{
			this.panel2.Visible = true;
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x0000A336 File Offset: 0x00008536
		private void button10_Click(object sender, EventArgs e)
		{
			Application.Restart();
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x0000A35B File Offset: 0x0000855B
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x0000A35E File Offset: 0x0000855E
		private void list_Comments_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x0000A361 File Offset: 0x00008561
		private void rdo_Like_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x0000A380 File Offset: 0x00008580
		private void button13_Click(object sender, EventArgs e)
		{
			GetUsersFromPost f = new GetUsersFromPost();
			f.ShowDialog();
		}

		// Token: 0x060000AA RID: 170 RVA: 0x0000A39C File Offset: 0x0000859C
		private void textBox2_TextChanged(object sender, EventArgs e)
		{
			bool flag = Regex.IsMatch(this.textBox2.Text, "^\\s*$");
			if (flag)
			{
				this.btn_Direct.Enabled = false;
			}
			else
			{
				this.btn_Direct.Enabled = true;
			}
		}

		// Token: 0x060000AB RID: 171 RVA: 0x0000A3DF File Offset: 0x000085DF
		private void textBox2_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x060000AD RID: 173 RVA: 0x0000A3F0 File Offset: 0x000085F0
		private void button15_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000AE RID: 174 RVA: 0x0000A3F4 File Offset: 0x000085F4
		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.radioButton1.Checked;
			if (@checked)
			{
				this.by1 = true;
				this.btn_Start.Enabled = true;
				this.rdo_Like.Enabled = true;
				this.rdo_Unlike.Enabled = true;
				this.rdo_Comment.Enabled = true;
			}
			else
			{
				this.btn_Start.Enabled = false;
			}
		}

		// Token: 0x060000AF RID: 175 RVA: 0x0000A460 File Offset: 0x00008660
		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = this.move == 1;
			if (flag)
			{
				base.SetDesktopLocation(Control.MousePosition.X - this.moveX, Control.MousePosition.Y - this.moveY);
			}
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0000A4AC File Offset: 0x000086AC
		private void GetEmojiList()
		{
			this.SetListViewSpacing(this.listView2, 25, 25);
			this.SetListViewSpacing(this.listView1, 20, 20);
			string path = AppDomain.CurrentDomain.BaseDirectory + "emoji.txt";
			IEnumerable<ListViewItem> list = from str in File.ReadAllLines(path)
				select new ListViewItem
				{
					Text = str
				};
			this.listView2.View = View.LargeIcon;
			this.listView2.Items.AddRange(list.ToArray<ListViewItem>());
			this.listView1.View = View.LargeIcon;
			this.listView1.Items.AddRange(list.ToArray<ListViewItem>());
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x0000A564 File Offset: 0x00008764
		private void listView2_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = this.listView2.SelectedItems.Count > 0;
			if (flag)
			{
				string item = this.listView2.SelectedItems[0].Text;
				this.textBox2.AppendText(item);
			}
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x0000A5B0 File Offset: 0x000087B0
		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = this.listView1.SelectedItems.Count > 0;
			if (flag)
			{
				string item = this.listView1.SelectedItems[0].Text;
				this.txt_Comment.AppendText(item);
			}
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x0000A5FB File Offset: 0x000087FB
		private void panel2_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x0000A600 File Offset: 0x00008800
		private void button15_Click_1(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "File di testo (*.txt)|*.txt";
			openFileDialog.Title = "Select txt file (one comment per row)";
			bool flag = openFileDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				string filePath = openFileDialog.FileName;
				try
				{
					string[] lines = File.ReadAllLines(filePath);
					this.list_Comments.Items.Clear();
					foreach (string line in lines)
					{
						this.list_Comments.Items.Add(line);
					}
					MessageBox.Show("Comments added successfully", "Comments added successfully", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x0000A6DC File Offset: 0x000088DC
		public void SetListViewSpacing(ListView lst, int x, int y)
		{
			InstagramFollowUnfollow.SendMessage(lst.Handle.ToInt32(), 4149, 0, x * 65536 + y);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x0000A70D File Offset: 0x0000890D
		private void panel1_MouseUp(object sender, MouseEventArgs e)
		{
			this.move = 0;
		}

		// Token: 0x0400005B RID: 91
		private bool stop;

		// Token: 0x0400005C RID: 92
		private bool by;

		// Token: 0x0400005D RID: 93
		private bool by1;

		// Token: 0x0400005E RID: 94
		private bool follow;

		// Token: 0x0400005F RID: 95
		private bool getfromhash;

		// Token: 0x04000060 RID: 96
		private static List<string> Comments = new List<string>();

		// Token: 0x04000061 RID: 97
		private const int LVM_FIRST = 4096;

		// Token: 0x04000062 RID: 98
		private const int LVM_SETICONSPACING = 4149;

		// Token: 0x04000063 RID: 99
		private int move;

		// Token: 0x04000064 RID: 100
		private int moveX;

		// Token: 0x04000065 RID: 101
		private int moveY;

		// Token: 0x04000066 RID: 102
		private Random random = new Random();
	}
}
