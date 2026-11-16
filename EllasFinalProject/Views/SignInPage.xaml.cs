using EllasFinalProject.Helpers;
using EllasFinalProject.Services;
using EllasFinalProject.ViewsModels;

namespace EllasFinalProject.Views;

public partial class SignInPage : ContentPage
{
	public SignInPage()
	{

        InitializeComponent();
        BindingContext = new SignInViewModel();
    }

    
}