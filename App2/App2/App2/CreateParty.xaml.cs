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
	public partial class CreateParty : ContentPage
	{
		public CreateParty ()
		{
			InitializeComponent ();
		}

        private void goMainPage(object sender, EventArgs e)
        {
            MainPage mp = new MainPage();
            this.Navigation.PushAsync(mp);
        }

            private void getInfo(object sender, EventArgs e)
        {
            App.IDatabase.DeleteIngrs();
            App.Database.DeleteA();
            Party aa = new Party();
            aa.insertIngrDB();
            App.IDatabase.geti(Party.alc);
            aa.createCoctail();
            res.Text = "Для вечеринки в составе " + Party.numberPeople + " человек, которые будут пить " +
                Party.alc + " в режиме " + Party.mode + " необходимы следующие ингридиенты (МЛ): ";

            alcoholList.ItemsSource = Party.li;
            //rec.Text = "Рецепт одной порции";
            //op.Text = "Описание";
            if (Party.alc.Equals("Piranha Cocktail"))
            {
                aN.Text = Party.alc;
                iA.Source = "piranha.jpg";
                desc.Text = "Это один из тех обманчивых коктейлей, которые, имея безобидный вкус, на самом деле «кусают», как плотоядная, хищная рыба пиранья.";
                recD.Text = "Водка – 37 мл.Шоколадный ликер – 25 мл. Кола– 25 мл.";
            }
            if (Party.alc.Equals("Daiquiri Cocktail"))
            {
                recD.Text = "Ром белый – 50 мл. Сахарный сироп - 50 мл. Сок лайма - 10 мл.";
                aN.Text = Party.alc;
                iA.Source = "daiquiri.jpg";
                desc.Text = "Дайкири – коктейль, остающийся идеальным рецептом на все времена, с достоинством классики стоящий выше всех модных фруктовых версий.";
            }
            if (Party.alc.Equals("Margarita Cocktail"))
            {
                recD.Text = "Текила «серебряная» – 36 мл. Ликер «Куантро» – 12 мл. Сок лайма - 20 мл.";
                aN.Text = Party.alc;
                iA.Source = "margo.jpg";
                desc.Text = " «Маргарита» является отличным аперитивом. В то же время, коктейль достаточно крепкий.";
            }
            if (Party.alc.Equals("Arago Cocktail"))
            {
                recD.Text = "Коньяк – 36 мл. Ликер - 25 мл. Сливки - 25 мл";
                aN.Text = Party.alc;
                iA.Source = "arag.jpg";
                desc.Text = "Это очень приятный коктейль с банановым вкусом. .";
            }
            if (Party.alc.Equals("GodFather Cocktail"))
            {
                recD.Text = "Ликер «Амаретто» – 36 мл. Scotch – 36 мл";
                aN.Text = Party.alc;
                iA.Source = "godfather.jpg";
                desc.Text = "Есть и «Крестная мать»... Эти два коктейля схожи. Только в «Крестном отце» водку заменяют виски. ";
            }

        }
    }
}