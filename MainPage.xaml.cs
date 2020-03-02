using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace APP3
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    
    public partial class MainPage : ContentPage
    {
        string dbpath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "databse1.db");

        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());

        }
        private async void Button_Clicked2(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());



        }
        public static class playersfactory
        {
            
            public static IList<Class1> class1s { get; set; }
            static playersfactory()
            {
                class1s = new ObservableCollection<Class1>()
                {
                    new Class1
                    {
                        fullname = "saron keneni",
                        username = "sari"
                    },
                    new Class1
                    {
                        fullname = "rahel worku",
                        username = "rich"
                    }


                };
                
            }
        }
    }
}
