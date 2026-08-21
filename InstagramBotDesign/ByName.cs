using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace MASAInstaPilot
{
	// Token: 0x02000008 RID: 8
	internal class ByName
	{
		// Token: 0x06000017 RID: 23 RVA: 0x00003080 File Offset: 0x00001280
		public static void like(string username, bool like, bool unlike, bool Comment, List<string> comment, int delay)
		{
			try
			{
				SignInMethodes.Driver.Navigate().GoToUrl("https://www.instagram.com/" + username + "/?hl=en");
				Thread.Sleep(6000);
				IWebElement ele = SignInMethodes.Driver.FindElement(By.CssSelector("div[class*='_aagu']"));
				ByName.LikeLoop(ele, like, unlike, Comment, comment, delay);
			}
			catch
			{
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000030F8 File Offset: 0x000012F8
		private static void LikeLoop(IWebElement element, bool like, bool unlike, bool Comment, List<string> comment, int delay)
		{
			try
			{
				int j = 0;
				element.Click();
				bool stop;
				do
				{
					if (like)
					{
						Thread.Sleep(2000);
						IReadOnlyCollection<IWebElement> lik = SignInMethodes.Driver.FindElements(By.XPath("//*[@aria-label='Like']/parent::span/parent::div/parent::div"));
						Thread.Sleep(300);
						IWebElement lastElement = lik.First<IWebElement>();
						lastElement.Click();
						Thread.Sleep(500);
						j++;
					}
					if (unlike)
					{
						Thread.Sleep(2000);
						IReadOnlyCollection<IWebElement> lik2 = SignInMethodes.Driver.FindElements(By.XPath("//*[@aria-label='Unlike']/parent::span/parent::div/parent::div"));
						Thread.Sleep(300);
						IWebElement lastElement2 = lik2.First<IWebElement>();
						lastElement2.Click();
					}
					if (Comment)
					{
						Thread.Sleep(1000);
						Random random = new Random();
						int i = random.Next(0, comment.Count);
						List<IWebElement> textarea = SignInMethodes.Driver.FindElements(By.CssSelector("textarea[aria-label='Add a comment…']")).ToList<IWebElement>();
						Thread.Sleep(1000);
						bool flag = textarea.Count > 0;
						if (flag)
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
							Thread.Sleep(2500);
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
			List<IWebElement> next = SignInMethodes.Driver.FindElements(By.XPath("//div[@class=' _aaqg _aaqh']/button")).ToList<IWebElement>();
				Thread.Sleep(1000);
				bool flag2 = next.Count > 0 && j < 300;
				if (!flag2)
				{
					break;
				}
				next[0].Click();
				j++;
				Thread.Sleep(delay * 1000);
			stop = ByName.Stop;
				}
				while (!stop);
			}
			catch
			{
			}
		}

		// Token: 0x04000009 RID: 9
		public static bool Stop;
	}
}
