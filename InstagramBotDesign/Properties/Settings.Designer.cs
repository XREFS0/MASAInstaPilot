using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace MASAInstaPilot.Properties
{
	// Token: 0x02000017 RID: 23
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.5.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x060000FE RID: 254 RVA: 0x00013710 File Offset: 0x00011910
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x060000FF RID: 255 RVA: 0x00013728 File Offset: 0x00011928
		// (set) Token: 0x06000100 RID: 256 RVA: 0x0001374A File Offset: 0x0001194A
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string email
		{
			get
			{
				return (string)this["email"];
			}
			set
			{
				this["email"] = value;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000101 RID: 257 RVA: 0x0001375C File Offset: 0x0001195C
		// (set) Token: 0x06000102 RID: 258 RVA: 0x0001377E File Offset: 0x0001197E
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string password
		{
			get
			{
				return (string)this["password"];
			}
			set
			{
				this["password"] = value;
			}
		}

		// Token: 0x04000111 RID: 273
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
