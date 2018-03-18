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
	public partial class AlcoholPage : ContentPage
	{

        private  async void getPeoples_Clicked(object sender, EventArgs e)
        {
            Party.li.Clear();
            int nP = Convert.ToInt32(nPeople.Text);
            Party.numberPeople = nP;
            SelectAlco sA = new SelectAlco();
            await Navigation.PushAsync(sA);
        }
        //private void DeleteAlcohol(object sender, EventArgs e)
        //{
        //    var alcohol = (Alcohol)BindingContext;
        //    App.Database.DeleteItem(alcohol.Id);
        //    this.Navigation.PopAsync();
        //}
        //private void Cancel(object sender, EventArgs e)
        //{
        //    this.Navigation.PopAsync();
        //}

        public AlcoholPage ()
		{
			InitializeComponent ();
		}
	}
}