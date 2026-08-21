using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace MASAInstaPilot
{
	// Token: 0x02000007 RID: 7
	internal class ByName1
	{
		// Token: 0x06000014 RID: 20 RVA: 0x00002D84 File Offset: 0x00000F84
		public static void like(string username, bool like, bool unlike, bool Comment, List<string> comment, int delay)
		{
			try
			{
				SignInMethodes.Driver.Navigate().GoToUrl("https://www.instagram.com/" + username + "/?hl=en");
				Thread.Sleep(6000);
				IWebElement ele = SignInMethodes.Driver.FindElement(By.CssSelector("div[class*='_aagu']"));
				bool flag = ele != null;
				if (flag)
				{
					ByName1.LikeLoop(ele, like, unlike, Comment, comment, delay);
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002E04 File Offset: 0x00001004
		private static void LikeLoop(IWebElement element, bool like, bool unlike, bool Comment, List<string> comment, int delay)
		{
			try
			{
				Thread.Sleep(delay * 1000);
				int j = 0;
				element.Click();
				if (like)
				{
					Thread.Sleep(2000);
					IReadOnlyCollection<IWebElement> lik = SignInMethodes.Driver.FindElements(By.XPath("//*[@aria-label='Like']/parent::span/parent::div/parent::div"));
					Thread.Sleep(300);
					IWebElement lastElement = lik.First<IWebElement>();
					Thread.Sleep(500);
					lastElement.Click();
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
			}
			catch
			{
			}
		}

		// Token: 0x04000008 RID: 8
		public static bool Stop;
	}
}
