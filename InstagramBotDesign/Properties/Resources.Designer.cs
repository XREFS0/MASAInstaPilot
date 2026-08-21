using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace MASAInstaPilot.Properties
{
	// Token: 0x02000016 RID: 22
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	public class Resources
	{
		// Token: 0x060000FA RID: 250 RVA: 0x0001369D File Offset: 0x0001189D
		internal Resources()
		{
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x060000FB RID: 251 RVA: 0x000136A8 File Offset: 0x000118A8
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static ResourceManager ResourceManager
		{
			get
			{
				bool flag = Resources.resourceMan == null;
				if (flag)
				{
					ResourceManager temp = new ResourceManager("MASAInstaPilot.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = temp;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x060000FC RID: 252 RVA: 0x000136F0 File Offset: 0x000118F0
		// (set) Token: 0x060000FD RID: 253 RVA: 0x00013707 File Offset: 0x00011907
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x0400010F RID: 271
		private static ResourceManager resourceMan;

		// Token: 0x04000110 RID: 272
		private static CultureInfo resourceCulture;
	}
}
