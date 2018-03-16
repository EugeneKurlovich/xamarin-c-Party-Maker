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
	public partial class SelectAlco : ContentPage
	{
		public SelectAlco ()
		{
			InitializeComponent ();
		}

        private async void selectAlc_Clicked(object sender, System.EventArgs e)
        {
            string sA = picker1.SelectedItem.ToString();
            Party.alc = sA;
            selectMode sM = new selectMode();
            await Navigation.PushAsync(sM);
        }

        //private void Cancel(object sender, EventArgs e)
        //{
        //    this.Navigation.PopAsync();
        //}

    }
}