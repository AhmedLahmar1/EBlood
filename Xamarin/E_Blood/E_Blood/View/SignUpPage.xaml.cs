using E_Blood.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace E_Blood.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUpPage : ContentPage
    {
        SignUpViewModel signUpViewModel;
 
        public SignUpPage()
        {
            signUpViewModel = new SignUpViewModel();
            InitializeComponent();
            BindingContext = signUpViewModel;
        }

       
    }
}