using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace MASAInstaPilot
{
	// Token: 0x02000005 RID: 5
	internal class ByHashTag
	{
		// Token: 0x06000005 RID: 5 RVA: 0x00002094 File Offset: 0x00000294
		public static void likeHachtag(string Hashtag, bool like, bool unlike, bool Comment, List<string> comment, bool Follow, bool UnFollow, int delay)
		{
			try
			{
				SignInMethodes.Driver.Navigate().GoToUrl("https://www.instagram.com/explore/tags/" + Hashtag + "/?hl=en");
				Thread.Sleep(4000);
				IWebElement ele = SignInMethodes.Driver.FindElement(By.XPath("//*[@class='_aagu']/parent::a"));
				ByHashTag.LikeLoop(ele, like, unlike, Comment, comment, Follow, UnFollow, delay);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002110 File Offset: 0x00000310
		public static void LikeLoop(IWebElement element, bool like, bool unlike, bool Comment, List<string> comment, bool Follow, bool UnFollow, int delay)
		{
			SignInMethodes.Driver.Navigate().GoToUrl(element.GetAttribute("href"));
			if (like)
			{
				Thread.Sleep(2000);
				IReadOnlyCollection<IWebElement> lik = SignInMethodes.Driver.FindElements(By.XPath("//*[@aria-label='Like']/parent::span/parent::div/parent::div"));
				Thread.Sleep(300);
				IWebElement lastElement = lik.First<IWebElement>();
				lastElement.Click();
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
					SignInMethodes.Driver.FindElement(By.CssSelector("textarea[aria-label='Add a comment…']")).SendKeys(comment[i]);
					Thread.Sleep(2000);
					List<IWebElement> post = SignInMethodes.Driver.FindElements(By.CssSelector("button[type='submit']")).ToList<IWebElement>();
					bool flag2 = post.Count > 0;
					if (flag2)
					{
						post[0].Submit();
					}
					Thread.Sleep(2000);
				}
			}
			if (Follow)
			{
				Thread.Sleep(2000);
				List<IWebElement> username = SignInMethodes.Driver.FindElements(By.ClassName("_aar2")).ToList<IWebElement>();
				Thread.Sleep(500);
				bool flag3 = username.Count > 0;
				if (flag3)
				{
					ByHashTag.AddUsername(username[0].Text);
				}
				List<IWebElement> follow = SignInMethodes.Driver.FindElements(By.XPath("//div[contains(text(), 'Follow')]/parent::div/parent::button")).ToList<IWebElement>();
				Thread.Sleep(1000);
				bool flag4 = follow.Count > 0;
				if (flag4)
				{
					Thread.Sleep(1000);
					bool flag5 = follow[0].Text == "Follow";
					if (flag5)
					{
						Thread.Sleep(1000);
						follow[0].Click();
					}
				}
			}
			if (UnFollow)
			{
				Thread.Sleep(2000);
				List<IWebElement> unfollow = SignInMethodes.Driver.FindElements(By.XPath("//*[@aria-label='Following']/parent::div/parent::div//parent::div/parent::button")).ToList<IWebElement>();
				Thread.Sleep(1000);
				bool flag6 = unfollow.Count > 0 && unfollow[0].Text != "Follow";
				if (flag6)
				{
					Thread.Sleep(1000);
					unfollow[0].Click();
					Thread.Sleep(2000);
					SignInMethodes.Driver.FindElements(By.XPath("//button[contains(text(), 'Unfollow')]"))[0].Click();
				}
			}
			Thread.Sleep(1000);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002468 File Offset: 0x00000668
		public static void GetUsersFromHashtag(string Hashtag, int count)
		{
			ByHashTag.HashtagUsers = new List<string>();
			try
			{
				SignInMethodes.Driver.Navigate().GoToUrl("https://www.instagram.com/explore/tags/" + Hashtag + "/?hl=en");
				Thread.Sleep(4000);
				IWebElement ele = SignInMethodes.Driver.FindElement(By.CssSelector("div[class='v1Nh3 kIKUG _bz0w']"));
				ele.Click();
				Thread.Sleep(2000);
				do
				{
					Thread.Sleep(1000);
					List<IWebElement> username = SignInMethodes.Driver.FindElements(By.ClassName("e1e1d")).ToList<IWebElement>();
					Thread.Sleep(500);
					bool flag = username.Count > 0;
					if (flag)
					{
						ByHashTag.Add(username[0].Text);
					}
					Thread.Sleep(200);
					List<IWebElement> next = SignInMethodes.Driver.FindElements(By.CssSelector("svg[aria-label='Next']")).ToList<IWebElement>();
					Thread.Sleep(1000);
					bool flag2 = next.Count > 0;
					if (flag2)
					{
						next[0].Click();
					}
				}
				while (ByHashTag.HashtagUsers.Count < count + 1);
				ByHashTag.Save_While_Follow(ByHashTag.HashtagUsers, Hashtag);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000025BC File Offset: 0x000007BC
		private static void File(List<string> l)
		{
			using (StreamWriter sw = new StreamWriter("UsersFromhashtag.txt"))
			{
				foreach (string name in l)
				{
					sw.WriteLine(name);
				}
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002634 File Offset: 0x00000834
		public static void Save_While_Follow(List<string> l, string hashtag)
		{
			using (StreamWriter sw = new StreamWriter(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), hashtag + ".txt"), false))
			{
				foreach (string name in l)
				{
					sw.WriteLine(name);
				}
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000026C0 File Offset: 0x000008C0
		private static void AddUsername(string username)
		{
			bool flag = ByHashTag.UserswhileFollow.FindIndex((string x) => x == username) == -1;
			if (flag)
			{
				ByHashTag.UserswhileFollow.Add(username);
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x0000270C File Offset: 0x0000090C
		private static void Add(string username)
		{
			bool flag = ByHashTag.HashtagUsers.FindIndex((string x) => x == username) == -1;
			if (flag)
			{
				ByHashTag.HashtagUsers.Add(username);
			}
		}

		// Token: 0x04000003 RID: 3
		public static List<string> HashtagUsers = new List<string>();

		// Token: 0x04000004 RID: 4
		public static List<string> UserswhileFollow = new List<string>();
	}
}
