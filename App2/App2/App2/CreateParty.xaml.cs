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

        private void getInfo(object sender, EventArgs e)
        {
            numb.Text = Party.numberPeople.ToString();
            alc.Text = Party.alc;
            mode.Text = Party.mode;
        }
    }
}