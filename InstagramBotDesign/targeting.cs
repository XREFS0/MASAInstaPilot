using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace MASAInstaPilot
{
	// Token: 0x02000015 RID: 21
	internal class targeting
	{
		// Token: 0x060000ED RID: 237 RVA: 0x00012E58 File Offset: 0x00011058
		public static void FromLike(string url, int count)
		{
			SignInMethodes.Driver.Navigate().GoToUrl(url);
			Thread.Sleep(3000);
			List<IWebElement> likes = SignInMethodes.Driver.FindElements(By.XPath("/html/body/div[1]/div/div[1]/div/div[1]/div/div/div[1]/div[1]/section/main/div[1]/div[1]/article/div/div[2]/div/div[2]/section[2]/div/div/div/a[2]")).ToList<IWebElement>();
			Thread.Sleep(800);
			bool flag = likes.Count > 0;
			if (flag)
			{
				likes[0].Click();
				Thread.Sleep(1500);
				IWebElement element = SignInMethodes.Driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[2]/div/div/div[1]/div/div[2]/div/div/div/div"));
				Thread.Sleep(800);
				targeting.Scroll(element, count);
			}
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00012EF8 File Offset: 0x000110F8
		private static void Scroll(IWebElement element, int count)
		{
			bool flag = count > 0;
			if (flag)
			{
				do
				{
					Thread.Sleep(50);
					for (int i = 0; i < SignInMethodes.Driver.FindElements(By.CssSelector("span[class='_aacl _aaco _aacw _aacx _aad7 _aade']")).Count; i++)
					{
						Thread.Sleep(30);
						targeting.names_from_like.Add(SignInMethodes.Driver.FindElements(By.CssSelector("span[class='_aacl _aaco _aacw _aacx _aad7 _aade']"))[i].Text);
					}
					Thread.Sleep(500);
					Actions clickAction = new Actions(SignInMethodes.Driver);
					clickAction.MoveToElement(element).Click().Build()
						.Perform();
					IJavaScriptExecutor executor = (IJavaScriptExecutor)SignInMethodes.Driver;
					executor.ExecuteScript("arguments[0].scrollIntoView();", new object[] { element });
					Actions scrollAction = new Actions(SignInMethodes.Driver);
					scrollAction.KeyDown(Keys.Control).SendKeys(Keys.End).Perform();
					Thread.Sleep(50);
				}
				while (targeting.names_from_like.Count < count);
				targeting.SaveTxt("users_post_like", targeting.names_from_like);
			}
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00013022 File Offset: 0x00011222
		internal static void Save(object fileName, int value, Action<string, int> followers)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x0001302C File Offset: 0x0001122C
		public static void FromComments(string url, int count)
		{
			SignInMethodes.Driver.Navigate().GoToUrl(url);
			Thread.Sleep(3000);
			IWebElement element = SignInMethodes.Driver.FindElement(By.ClassName("eo2As"));
			Thread.Sleep(800);
			targeting.ScrollComment(element, count);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00013080 File Offset: 0x00011280
		private static void ScrollComment(IWebElement element, int count)
		{
			bool flag = count > 0;
			if (flag)
			{
				do
				{
					Thread.Sleep(50);
					for (int i = 0; i < SignInMethodes.Driver.FindElements(By.ClassName("_6lAjh")).Count; i++)
					{
						Thread.Sleep(30);
						targeting.Add_Comment_Users(SignInMethodes.Driver.FindElements(By.ClassName("_6lAjh"))[i].Text);
						Console.WriteLine("list" + targeting.names_from_Comments.Count.ToString());
					}
					Thread.Sleep(500);
					Actions clickAction = new Actions(SignInMethodes.Driver);
					clickAction.MoveToElement(element).Click().Build()
						.Perform();
					Actions scrollAction = new Actions(SignInMethodes.Driver);
					scrollAction.KeyDown(Keys.Control).SendKeys(Keys.End).Perform();
					Thread.Sleep(50);
				}
				while (targeting.names_from_Comments.Count < count + 1);
			}
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00013194 File Offset: 0x00011394
		private static void Add_Comment_Users(string text)
		{
			bool flag = targeting.names_from_Comments.FindIndex((string x) => x.Equals(text)) == -1;
			if (flag)
			{
				targeting.names_from_Comments.Add(text);
			}
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x000131E0 File Offset: 0x000113E0
		public static void Followers(string profileName, int count)
		{
			SignInMethodes.Driver.Navigate().GoToUrl("https://www.instagram.com/" + profileName + "/?hl=en");
			Thread.Sleep(5000);
			List<IWebElement> s = SignInMethodes.Driver.FindElements(By.XPath("/html/body/div[1]/div/div[1]/div/div[1]/div/div/div[1]/div[1]/section/main/div/header/section/ul/li[2]")).ToList<IWebElement>();
			Thread.Sleep(4000);
			bool flag = s.Count > 0;
			if (flag)
			{
				foreach (IWebElement el in s)
				{
					bool flag2 = el.Text.Contains("followers");
					if (flag2)
					{
						el.Click();
						Thread.Sleep(2000);
						IWebElement Element = SignInMethodes.Driver.FindElement(By.CssSelector("div[class='isgrP']"));
						Thread.Sleep(1000);
						targeting.ScrollASpecificElement(Element, count, "Follwers from " + profileName);
						Thread.Sleep(1000);
					}
				}
			}
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x000132F8 File Offset: 0x000114F8
		private static void ScrollASpecificElement(IWebElement element, int count, string chemin)
		{
			do
			{
				Actions clickAction = new Actions(SignInMethodes.Driver);
				clickAction.MoveToElement(element).Click().Build()
					.Perform();
				Thread.Sleep(1000);
				Actions scrollAction = new Actions(SignInMethodes.Driver);
				scrollAction.KeyDown(Keys.Control).SendKeys(Keys.End).Perform();
				Thread.Sleep(1000);
			}
			while (SignInMethodes.Driver.FindElements(By.CssSelector("span[class='Jv7Aj mArmR MqpiF  ']")).Count <= count);
			string Source = element.GetAttribute("innerHTML");
			IEnumerable<string> fileNames = from Match m in Regex.Matches(Source, "<a class=\"notranslate _0imsa \" title=\"(.*?)\" href=")
				select m.Groups[1].Value + "\n";
			foreach (string s in fileNames)
			{
				File.AppendAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), chemin + ".txt"), s);
			}
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x0001342C File Offset: 0x0001162C
		private static void SaveTxt(string chemin, List<string> f)
		{
			using (StreamWriter sw = new StreamWriter(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), chemin + ".txt"), true))
			{
				foreach (string s in f)
				{
					sw.WriteLine(s);
				}
			}
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x000134B8 File Offset: 0x000116B8
		public static void GetFollowings(string profileName, int count)
		{
			SignInMethodes.Driver.Navigate().GoToUrl("https://www.instagram.com/" + profileName + "/?hl=en");
			Thread.Sleep(5000);
			List<IWebElement> s = SignInMethodes.Driver.FindElements(By.XPath("/html/body/div[1]/section/main/div/header/section/ul/li[3]")).ToList<IWebElement>();
			Thread.Sleep(4000);
			bool flag = s.Count > 0;
			if (flag)
			{
				foreach (IWebElement el in s)
				{
					bool flag2 = el.Text.Contains(" following");
					if (flag2)
					{
						el.Click();
						Thread.Sleep(2000);
						IWebElement Element = SignInMethodes.Driver.FindElement(By.CssSelector("div[class='isgrP']"));
						Thread.Sleep(1000);
						targeting.ScrollASpecificElement(Element, count, "Followings from " + profileName);
						Thread.Sleep(1000);
						Thread.Sleep(1000);
					}
				}
			}
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x000135E0 File Offset: 0x000117E0
		public static void Save(string path, int Count, List<string> list)
		{
			try
			{
				using (StreamWriter sw = new StreamWriter(path))
				{
					bool flag = list.Count > 0;
					if (!flag)
					{
						throw new Exception("no users found");
					}
					for (int i = 0; i < Count; i++)
					{
						sw.WriteLine(list[i]);
					}
				}
			}
			catch (Exception c)
			{
				Console.WriteLine(c.Message);
			}
		}

		// Token: 0x0400010C RID: 268
		public static List<string> names_from_like = new List<string>();

		// Token: 0x0400010D RID: 269
		public static List<string> names_from_Comments = new List<string>();

		// Token: 0x0400010E RID: 270
		private static List<string> els = new List<string>();
	}
}
