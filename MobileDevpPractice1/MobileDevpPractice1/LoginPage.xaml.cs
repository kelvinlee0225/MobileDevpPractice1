using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileDevpPractice1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void textEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void loginButton_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(emailEntry.Text) || string.IsNullOrEmpty(passEntry.Text))
            {
                DisplayAlert("Alert!", "Either the email or the password entry is empty", "OK");
            }
            else
            {
                DisplayAlert("Success!", "You have logged in successfully", "OK");
            }
        }
    }
}