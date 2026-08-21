using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MASAInstaPilot
{
	// Token: 0x0200000E RID: 14
	public partial class HelpForm : Form
	{
		// Token: 0x06000055 RID: 85 RVA: 0x00007932 File Offset: 0x00005B32
		public HelpForm()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000056 RID: 86 RVA: 0x0000794A File Offset: 0x00005B4A
		private void HelpForm_Load(object sender, EventArgs e)
		{
			base.Icon = Icon.ExtractAssociatedIcon(AppDomain.CurrentDomain.FriendlyName);
		}
	}
}
