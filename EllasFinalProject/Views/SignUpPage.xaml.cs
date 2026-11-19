using EllasFinalProject.Helpers;
using System.ComponentModel.DataAnnotations;
using System.Windows.Input;

namespace EllasFinalProject.Views;

public partial class SignUpPage : ContentPage
{


    public SignUpPage()
    {
        InitializeComponent();
        BindingContext = new SignUpViewModel();

    }
  
}
