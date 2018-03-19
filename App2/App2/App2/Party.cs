using System;
using System.Collections.Generic;
using System.Text;

namespace App2
{
    public class Party
    {
       public static int numberPeople { set; get; }
       public static string alc { set; get; }
       public static string mode { set; get; }

        public static List<Ingr> li = new List<Ingr>();
        public static string result { set; get; }


        public void insertIngrDB()
        {
            Alcohol a1 = new Alcohol();
            Alcohol a2 = new Alcohol();
            Alcohol a3 = new Alcohol();
            Alcohol a4 = new Alcohol();
            Alcohol a5 = new Alcohol();
            a1.setInfo("Piranha Cocktail", "1");
            a2.setInfo("Daiquiri Cocktail", "2");
            a3.setInfo("Margarita Cocktail", "3");
            a4.setInfo("Arago Cocktail", "4");
            a5.setInfo("GodFather Cocktail", "5");
            App.Database.SaveItem(a1);
            App.Database.SaveItem(a2);
            App.Database.SaveItem(a3);
            App.Database.SaveItem(a4);
            App.Database.SaveItem(a5);
            Ingr i1 = new Ingr(); i1.setInfo("Vodka", 37, "Piranha Cocktail");
            Ingr i2 = new Ingr(); i2.setInfo("Chocolate Liker", 25, "Piranha Cocktail");
            Ingr i3 = new Ingr(); i3.setInfo("Coca-Cola", 25, "Piranha Cocktail");
            Ingr i4 = new Ingr(); i4.setInfo("Rom", 50, "Daiquiri Cocktail");
            Ingr i5 = new Ingr(); i5.setInfo("Laim juice", 10, "Daiquiri Cocktail");
            Ingr i6 = new Ingr(); i6.setInfo("Sirup", 50, "Daiquiri Cocktail");
            Ingr i7 = new Ingr(); i7.setInfo("Tequila", 36, "Margarita Cocktail");
            Ingr i8 = new Ingr(); i8.setInfo("Liquor Cointreau", 16, "Margarita Cocktail");
            Ingr i9 = new Ingr(); i9.setInfo("Laim Juice", 20, "Margarita Cocktail");
            Ingr i10 = new Ingr(); i10.setInfo("Liquor Amaretto", 36, "GodFather Cocktail");
            Ingr i11 = new Ingr(); i11.setInfo("Scotch", 36, "GodFather Cocktail");
            Ingr i12 = new Ingr(); i12.setInfo("Cognac", 36, "Arago Cocktail");
            Ingr i13 = new Ingr(); i13.setInfo("Liquor", 25, "Arago Cocktail");
            Ingr i14 = new Ingr(); i14.setInfo("Cream", 25, "Arago Cocktail");
            App.IDatabase.SaveItem(i1);
            App.IDatabase.SaveItem(i2);
            App.IDatabase.SaveItem(i3);
            App.IDatabase.SaveItem(i4);
            App.IDatabase.SaveItem(i5);
            App.IDatabase.SaveItem(i6);
            App.IDatabase.SaveItem(i7);
            App.IDatabase.SaveItem(i8);
            App.IDatabase.SaveItem(i9);
            App.IDatabase.SaveItem(i10);
            App.IDatabase.SaveItem(i11);
            App.IDatabase.SaveItem(i12);
            App.IDatabase.SaveItem(i13);
            App.IDatabase.SaveItem(i14);
        }

        public void createCoctail()
        {
            
            foreach (Ingr i in Party.li)
            {
                i.V = i.V * Party.numberPeople;
                if (Party.mode.Equals("Hard"))
                {
                    i.V = i.V * 10;
                   
                }
                if (Party.mode.Equals("Easy"))
                {
                    i.V = i.V * 2;
                }
                if (Party.mode.Equals("Middle"))
                {
                    i.V = i.V * 5;
                }
            }
            
        }
    }
}
