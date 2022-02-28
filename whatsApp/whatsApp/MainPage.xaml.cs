using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace whatsApp
{
    public partial class MainPage : FlyoutPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.Flyout = new principal();
            this.Detail = new NavigationPage(new portada()) { 
            
                BarBackgroundColor = Color.FromHex("#00bb2d")
            
            };

            App.FlyoutP = this;

            



        }
       
    }
}
