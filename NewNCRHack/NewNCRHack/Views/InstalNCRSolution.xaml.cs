using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NewNCRHack.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class InstalNCRSolution : ContentPage
	{
		public InstalNCRSolution ()
		{
			InitializeComponent ();

			MyName.Text = $" {Application.Current.Properties["Name"].ToString()}"; 
		}
	}
}