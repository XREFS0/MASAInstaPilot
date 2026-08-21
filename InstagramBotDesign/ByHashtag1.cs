using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace MASAInstaPilot
{
	// Token: 0x02000006 RID: 6
	internal class ByHashtag1
	{
		// Token: 0x0600000E RID: 14 RVA: 0x00002774 File Offset: 0x00000974
		public static void like(string username, bool like, bool unlike, bool Comment, List<string> comment, int delay)
		{
			try
			{
				SignInMethodes.Driver.Navigate().GoToUrl(username ?? "");
				Thread.Sleep(6000);
			}
			catch
			{
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000027C0 File Offset: 0x000009C0
		public static void LikeLoop(string username, bool like, bool unlike, bool Comment, List<string> comment, bool Follow, bool UnFollow, int delay, bool Stop)
		{
			try
			{
				SignInMethodes.Driver.Navigate().GoToUrl("https://www.instagram.com/explore/search/keyword/?q=%23" + username + "&hl=en");
				Thread.Sleep(delay * 1000);
				int j = 0;
				Thread.Sleep(5000);
				IWebElement ele = SignInMethodes.Driver.FindElement(By.CssSelector("div[class*='_aagu']"));
				try
				{
					ele.Click();
				}
				catch
				{
				}
				while (!Stop)
				{
					if (like)
					{
						Thread.Sleep(2000);
						List<IWebElement> lik = SignInMethodes.Driver.FindElements(By.XPath("//*[@aria-label='Like']/parent::span/parent::div/parent::div")).ToList<IWebElement>();
						Thread.Sleep(500);
						bool flag = lik.Count > 0;
						if (flag)
						{
							lik[0].Click();
							Thread.Sleep(500);
						}
						j++;
					}
					if (unlike)
					{
						Thread.Sleep(2000);
						List<IWebElement> lik2 = SignInMethodes.Driver.FindElements(By.XPath("//*[@aria-label='Unlike']/parent::span/parent::div/parent::div")).ToList<IWebElement>();
						Thread.Sleep(300);
						bool flag2 = lik2.Count > 0;
						if (flag2)
						{
							lik2[0].Click();
							Thread.Sleep(500);
						}
					}
					if (Comment)
					{
						Thread.Sleep(1500);
						Random random = new Random();
						int i = random.Next(0, comment.Count);
						List<IWebElement> textarea = SignInMethodes.Driver.FindElements(By.CssSelector("textarea[aria-label='Add a comment…']")).ToList<IWebElement>();
						Thread.Sleep(1000);
						bool flag3 = textarea.Count > 0;
						if (flag3)
						{
							Actions action = new Actions(SignInMethodes.Driver);
							action.MoveToElement(textarea[0]);
							textarea[0].Click();
							Thread.Sleep(1000);
							Thread clipboardThread = new Thread(new ThreadStart(delegate
							{
								try
								{
									Clipboard.SetText(comment[i]);
								}
								catch (Exception ex)
								{
								}
							}));
							clipboardThread.SetApartmentState(ApartmentState.STA);
							clipboardThread.Start();
							clipboardThread.Join();
							SignInMethodes.Driver.FindElement(By.CssSelector("textarea[aria-label='Add a comment…']")).SendKeys(OpenQA.Selenium.Keys.Control + "v");
							Thread.Sleep(2000);
							try
							{
								SignInMethodes.Driver.FindElement(By.XPath("//div[contains(text(), 'Post')]")).Click();
								SignInMethodes.Driver.FindElement(By.XPath("//div[contains(text(), 'Post')]/parent::div")).Click();
								Thread.Sleep(2500);
							}
							catch
							{
							}
						}
					}
					if (Follow)
					{
						Thread.Sleep(1000);
						List<IWebElement> follow = SignInMethodes.Driver.FindElements(By.XPath("//div[contains(text(), 'Follow')]/parent::div/parent::button")).ToList<IWebElement>();
						Thread.Sleep(1000);
						bool flag4 = follow.Count > 0;
						if (flag4)
						{
							follow[0].Click();
							Thread.Sleep(1500);
						}
					}
					if (UnFollow)
					{
						Thread.Sleep(2000);
						List<IWebElement> unfollow = SignInMethodes.Driver.FindElements(By.XPath("//div[contains(text(), 'Following')]")).ToList<IWebElement>();
						Thread.Sleep(1000);
						bool flag5 = unfollow.Count > 0 && unfollow[0].Text != "Follow";
						if (flag5)
						{
							Thread.Sleep(1000);
							unfollow[0].Click();
							Thread.Sleep(2000);
							SignInMethodes.Driver.FindElements(By.XPath("//button[contains(text(), 'Unfollow')]"))[0].Click();
						}
					}
				List<IWebElement> next = SignInMethodes.Driver.FindElements(By.XPath("//div[@class=' _aaqg _aaqh']/button")).ToList<IWebElement>();
				Thread.Sleep(1000);
				bool flag6 = next.Count > 0 && j < 300;
				if (!flag6)
				{
					break;
				}
				next[0].Click();
				j++;
				Thread.Sleep(delay * 1000);
				if (Stop)
					{
						break;
					}
				}
			}
			catch
			{
			}
			Thread.Sleep(1000);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002CD0 File Offset: 0x00000ED0
		private static void AddUsername(string username1)
		{
			bool flag = ByHashtag1.UserswhileFollow.FindIndex((string x) => x == username1) == -1;
			if (flag)
			{
				ByHashtag1.UserswhileFollow.Add(username1);
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002D1C File Offset: 0x00000F1C
		private static void Add(string username1)
		{
			bool flag = ByHashtag1.HashtagUsers.FindIndex((string x) => x == username1) == -1;
			if (flag)
			{
				ByHashtag1.HashtagUsers.Add(username1);
			}
		}

		// Token: 0x04000005 RID: 5
		public static bool Stop;

		// Token: 0x04000006 RID: 6
		public static List<string> HashtagUsers = new List<string>();

		// Token: 0x04000007 RID: 7
		public static List<string> UserswhileFollow = new List<string>();
	}
}
