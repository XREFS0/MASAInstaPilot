using System;
using System.Windows.Forms;

namespace MASAInstaPilot
{
	public partial class RegistrationForm : Form
	{
		public RegistrationForm()
		{
			this.InitializeComponent();
		}

		public static int IsValidRegData(string Email, string Code)
		{
			return 1;
		}

		public static bool Register(string Email, string Code)
		{
			return true;
		}

		private void btnRegister_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Registered!");
			base.Close();
		}

		private void btnBuyNow_Click(object sender, EventArgs e)
		{
		}

		private void btnFreeTrial_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		public static void OfferFullVersion()
		{
		}

		private void tbRegCode_TextChanged(object sender, EventArgs e)
		{
		}

		private void lblSupportLink_MouseHover(object sender, EventArgs e)
		{
		}

		private void lblSupportLink_MouseLeave(object sender, EventArgs e)
		{
		}

		private void lblSupportLink_Click(object sender, EventArgs e)
		{
		}
	}
}
