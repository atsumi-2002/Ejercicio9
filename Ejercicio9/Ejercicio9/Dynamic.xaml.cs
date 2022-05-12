using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio9
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Dynamic : ContentPage
	{
        bool originalStyle = true;
		public Dynamic ()
		{
			InitializeComponent ();
            Resources["SearchBarStyle"] = Resources["blueSearchBarStyle"];
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            if (originalStyle)
            {
                Resources["SearchBarStyle"] = Resources["greenSearchBarStyle"];
                originalStyle = false;
            }
            else
            {
                Resources["SearchBarStyle"] = Resources["blueSearchBarStyle"];
                originalStyle = true;
            }
        }
	}
}