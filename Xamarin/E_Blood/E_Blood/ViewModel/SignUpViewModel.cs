using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using E_Blood.View;
using E_Blood.Services;

namespace E_Blood.ViewModel
{
    class SignUpViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        
        public SignUpViewModel()
        {
        }

        ApiServices apiServices = new ApiServices();

        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Emails"));
            }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Passwords"));
            }
        }

        private string confirmPassword;
        public string ConfirmPassword
        {
            get { return confirmPassword; }
            set
            {
                confirmPassword = value;
                PropertyChanged(this, new PropertyChangedEventArgs("ConfirmPassword"));
            }
        }





        public Command RegisterCommand
        {
            get
            {
                return new Command(async()=>
                {
                    var isSuccess = await apiServices.RegisterAsync(Email, Password, ConfirmPassword);

                    if(isSuccess)
                        App.Current.MainPage.DisplayAlert("Success", "Registered successfully", "OK");
                    else
                    {
                        App.Current.MainPage.DisplayAlert("Error", "Retry please!", "OK");
                    }
                });
            }
        }

    }
}
