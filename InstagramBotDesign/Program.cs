using System;
using System.IO;
using System.Windows.Forms;

namespace MASAInstaPilot
{
	internal static class Program
	{
		[STAThread]
		private static void Main()
		{
			string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			string specificFolder = Path.Combine(folder, "Instabot");
			Directory.CreateDirectory(specificFolder);
			Program.SettingsFileName = string.Format("{0}\\settings.cfg", specificFolder);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new InstagramFollowUnfollow());
		}

		public static string SettingsFileName;
	}
}
