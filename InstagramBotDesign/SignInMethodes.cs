using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace MASAInstaPilot
{
	// Token: 0x02000014 RID: 20
	internal class SignInMethodes
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x060000DA RID: 218 RVA: 0x0001272C File Offset: 0x0001092C
		// (set) Token: 0x060000DB RID: 219 RVA: 0x00012743 File Offset: 0x00010943
		public static IWebDriver Driver
		{
			get
			{
				return SignInMethodes.driver;
			}
			set
			{
				SignInMethodes.driver = value;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x060000DC RID: 220 RVA: 0x0001274C File Offset: 0x0001094C
		// (set) Token: 0x060000DD RID: 221 RVA: 0x00012763 File Offset: 0x00010963
		public static string Username
		{
			get
			{
				return SignInMethodes.username;
			}
			set
			{
				SignInMethodes.username = value;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x060000DE RID: 222 RVA: 0x0001276C File Offset: 0x0001096C
		// (set) Token: 0x060000DF RID: 223 RVA: 0x00012783 File Offset: 0x00010983
		public static string Password
		{
			get
			{
				return SignInMethodes.password;
			}
			set
			{
				SignInMethodes.password = value;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x0001278C File Offset: 0x0001098C
		// (set) Token: 0x060000E1 RID: 225 RVA: 0x000127A3 File Offset: 0x000109A3
		public static Thread Th
		{
			get
			{
				return SignInMethodes.th;
			}
			set
			{
				SignInMethodes.th = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x000127AC File Offset: 0x000109AC
		// (set) Token: 0x060000E3 RID: 227 RVA: 0x000127C3 File Offset: 0x000109C3
		public static string Message
		{
			get
			{
				return SignInMethodes.message;
			}
			set
			{
				SignInMethodes.message = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x000127CC File Offset: 0x000109CC
		// (set) Token: 0x060000E5 RID: 229 RVA: 0x000127E3 File Offset: 0x000109E3
		public static bool Connected
		{
			get
			{
				return SignInMethodes.connected;
			}
			set
			{
				SignInMethodes.connected = value;
			}
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x000127EC File Offset: 0x000109EC
		public static void ReadFile(string chemin, List<string> users)
		{
			using (StreamReader sr = new StreamReader(chemin))
			{
				while (sr.Peek() != -1)
				{
					users.Add(sr.ReadLine());
				}
			}
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00012844 File Offset: 0x00010A44
		public static void Follow(string username)
		{
			try
			{
				SignInMethodes.Driver.Navigate().GoToUrl("https://www.instagram.com/" + username + "/?hl=en");
				Thread.Sleep(3000);
				List<IWebElement> folls = SignInMethodes.driver.FindElements(By.XPath("//div[contains(text(), 'Follow')]/parent::button")).ToList<IWebElement>();
				Thread.Sleep(1000);
				bool flag = folls.Count > 0;
				if (flag)
				{
					bool flag2 = folls[0].Text == "Follow" || folls[0].Text == "Follow Back";
					if (flag2)
					{
						Thread.Sleep(1000);
						folls[0].Click();
					}
				}
				else
				{
					List<IWebElement> folls2 = SignInMethodes.driver.FindElements(By.XPath("//div[contains(text(), 'Follow')]/parent::div/parent::button")).ToList<IWebElement>();
					bool flag3 = folls2.Count > 0;
					if (flag3)
					{
						bool flag4 = folls2[0].Text == "Follow" || folls2[0].Text == "Follow Back";
						if (flag4)
						{
							Thread.Sleep(1000);
							folls2[0].Click();
						}
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x000129A8 File Offset: 0x00010BA8
		public static void UnFollow(string username)
		{
			try
			{
				SignInMethodes.Driver.Navigate().GoToUrl("https://www.instagram.com/" + username + "/?hl=en");
				Thread.Sleep(4500);
				List<IWebElement> Request = SignInMethodes.driver.FindElements(By.XPath("//div[contains(text(), 'Following')]/parent::div/parent::button")).ToList<IWebElement>();
				bool flag = Request.Count > 0;
				if (flag)
				{
					Thread.Sleep(1000);
					Request[0].Click();
					Thread.Sleep(2300);
					SignInMethodes.driver.FindElements(By.XPath("//span[contains(text(), 'Unfollow')]/parent::span/parent::div"))[0].Click();
					Thread.Sleep(6000);
				}
				else
				{
					List<IWebElement> Request2 = SignInMethodes.driver.FindElements(By.XPath("//*[@aria-label='Following']/parent::div/parent::div//parent::div/parent::button")).ToList<IWebElement>();
					bool flag2 = Request2.Count > 0;
					if (flag2)
					{
						Thread.Sleep(1000);
						Request2[0].Click();
						Thread.Sleep(2000);
						SignInMethodes.driver.FindElements(By.XPath("//button[contains(text(), 'Unfollow')]"))[0].Click();
						Thread.Sleep(6000);
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00012AFC File Offset: 0x00010CFC
		private static bool ContainsNonBMP(string input)
		{
			foreach (char c in input)
			{
				bool flag = char.IsSurrogate(c);
				if (flag)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00012B40 File Offset: 0x00010D40
		public static void Direct(string username, string text2)
		{
			try
			{
				SignInMethodes.Driver.Navigate().GoToUrl("https://www.instagram.com/direct/inbox/?hl=en");
				Thread.Sleep(2000);
				try
				{
					SignInMethodes.Driver.FindElement(By.CssSelector("button[class*='_a9-- _ap36']")).Click();
				}
				catch
				{
				}
				Thread.Sleep(1000);
				bool containsNonBMP = SignInMethodes.ContainsNonBMP(text2);
				List<IWebElement> Request = SignInMethodes.driver.FindElements(By.XPath("//div[(text() = 'Send message')]")).ToList<IWebElement>();
				Thread.Sleep(800);
				bool flag = Request.Count > 0;
				if (flag)
				{
					Request[0].Click();
					Thread.Sleep(1000);
					List<IWebElement> textarea = SignInMethodes.driver.FindElements(By.CssSelector("input[name*='query']")).ToList<IWebElement>();
					Thread.Sleep(1000);
					bool flag2 = textarea.Count > 0;
					if (flag2)
					{
						textarea[0].Click();
						Thread.Sleep(1000);
						SignInMethodes.Driver.FindElement(By.CssSelector("input[name*='query']")).SendKeys(username);
						WebDriverWait wait = new WebDriverWait(SignInMethodes.driver, TimeSpan.FromSeconds(40.0));
						wait.PollingInterval = TimeSpan.FromMilliseconds(250.0);
						wait.IgnoreExceptionTypes(new Type[]
						{
							typeof(NoSuchElementException),
							typeof(StaleElementReferenceException)
						});
						try
						{
							IWebElement userRow = wait.Until<IWebElement>(delegate(IWebDriver d)
							{
								By byProfileLink = By.XPath("//div[@role='dialog']//a[contains(@href,'/" + username + "/')]");
								IWebElement link = d.FindElements(byProfileLink).FirstOrDefault<IWebElement>((IWebElement e) => e.Displayed);
								bool flag4 = link != null;
								IWebElement webElement;
								if (flag4)
								{
									IWebElement row = link.FindElements(By.XPath("./ancestor::div[@role='button' or @tabindex='0']")).FirstOrDefault<IWebElement>();
									webElement = row ?? link;
								}
								else
								{
									By byText = By.XPath("//div[@role='dialog']//span[normalize-space(text())='" + username + "']");
									IWebElement span = d.FindElements(byText).FirstOrDefault<IWebElement>((IWebElement e) => e.Displayed);
									bool flag5 = span != null;
									if (flag5)
									{
										IWebElement row2 = span.FindElements(By.XPath("./ancestor::div[@role='button' or @tabindex='0']")).FirstOrDefault<IWebElement>();
										webElement = row2 ?? span;
									}
									else
									{
										By byContains = By.XPath("//div[@role='dialog']//span[contains(normalize-space(text()),'" + username + "')]");
										IWebElement span2 = d.FindElements(byContains).FirstOrDefault<IWebElement>((IWebElement e) => e.Displayed);
										bool flag6 = span2 != null;
										if (flag6)
										{
											IWebElement row3 = span2.FindElements(By.XPath("./ancestor::div[@role='button' or @tabindex='0']")).FirstOrDefault<IWebElement>();
											webElement = row3 ?? span2;
										}
										else
										{
											webElement = null;
										}
									}
								}
								return webElement;
							});
							userRow.Click();
						}
						catch
						{
							return;
						}
						Thread.Sleep(3000);
						SignInMethodes.driver.FindElement(By.XPath("//div[(text() = 'Chat')]")).Click();
						Thread.Sleep(1000);
						IWebElement messageBox = SignInMethodes.driver.FindElement(By.CssSelector("div[role='textbox']"));
						messageBox.Click();
						bool flag3 = containsNonBMP;
						if (flag3)
						{
							Thread clipboardThread = new Thread(new ThreadStart(delegate
							{
								try
								{
									Clipboard.SetText(text2);
								}
								catch (Exception ex)
								{
								}
							}));
							clipboardThread.SetApartmentState(ApartmentState.STA);
							clipboardThread.Start();
							clipboardThread.Join();
							messageBox.SendKeys(OpenQA.Selenium.Keys.Control + "v");
						}
						else
						{
							SignInMethodes.Driver.FindElement(By.CssSelector("div[role='textbox']")).SendKeys(text2);
						}
						Thread.Sleep(2000);
						SignInMethodes.driver.FindElement(By.XPath("//div[@aria-label='Send']")).Click();
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x04000105 RID: 261
		private static IWebDriver driver;

		// Token: 0x04000106 RID: 262
		private static Thread th;

		// Token: 0x04000107 RID: 263
		private static string username;

		// Token: 0x04000108 RID: 264
		private static string password;

		// Token: 0x04000109 RID: 265
		private static string message;

		// Token: 0x0400010A RID: 266
		public static List<string> names = new List<string>();

		// Token: 0x0400010B RID: 267
		private static bool connected = false;
	}
}
