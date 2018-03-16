using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace App2
{
   
    public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        //protected override void OnAppearing()
        //{
        //    alcoholList.ItemsSource = App.Database.GetItems();
        //    base.OnAppearing();
        //}

        //private async void CreateAlcohol(object sender, EventArgs e)
        //{
        //    Alcohol alcohol = new Alcohol();
        //    AlcoholPage alcoholPage = new AlcoholPage();
        //    alcoholPage.BindingContext = alcohol;
        //    await Navigation.PushAsync(alcoholPage);
        //}

        private async void create_Clicked(object sender, System.EventArgs e)
        {
            AlcoholPage ap = new AlcoholPage();
            await Navigation.PushAsync(ap);
        }

        //private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        //{
        //    Alcohol selectedAlcohol = (Alcohol)e.SelectedItem;
        //    AlcoholPage alcoholPage = new AlcoholPage();
        //    alcoholPage.BindingContext = selectedAlcohol;
        //    await Navigation.PushAsync(alcoholPage);
        //}
    }
}
