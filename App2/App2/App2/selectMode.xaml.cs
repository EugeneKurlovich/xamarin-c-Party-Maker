using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class selectMode : ContentPage
	{
		public selectMode ()
		{
			InitializeComponent ();
		}

        private async void selectMode_Clicked(object sender, System.EventArgs e)
        {
            try { String sM = picker2.SelectedItem.ToString();
           
            if(sM.Length > 0)
            {
                Party.mode = sM;
                CreateParty cP = new CreateParty();
                await Navigation.PushAsync(cP);
            }
            else
           {

           }
            }
            catch { }
        }
        
    }
}