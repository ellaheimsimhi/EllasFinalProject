using EllasFinalProject.Helpers;
using System.ComponentModel.DataAnnotations;
using System.Windows.Input;

namespace EllasFinalProject.Views;

public partial class SignUpPage : ContentPage
{

    private string? _firstName;
    private string? _lastName;
    private string? _email;
    private string? _password;
    private string? _mobile;
    private bool _entryAsPassword;
    private string? _passwordIconCode;

    public ICommand? ShowPasswordCommand { get; }
    public ICommand? SignInCommand { get; }
    public SignUpPage()
    {
        InitializeComponent();
        BindingContext = this;
        _entryAsPassword = true;
        _passwordIconCode = FontHelper.CLOSED_EYE_ICON;
        ShowPasswordCommand = new Command(TogglePasswordButton);
        SignInCommand = new Command(SignUp, Validate);

    }
    public string FirstName
    {
        get => _firstName;
        set
        {
            if (_firstName != value)
            {
                _firstName = value;
                OnPropertyChanged();
            }
        }
    }
    public string LastName
    {
        get => _lastName!;
        set
        {
            if (_lastName != value)
            {
                _lastName = value;
                OnPropertyChanged(nameof(LastName));
            }
        }
    }
    public string UserEmail
    {
        get => _email!;
        set
        {
            if (_email != value)
            {
                _email = value;
                OnPropertyChanged(nameof(UserEmail));
            }
        }
    }
    public string UserPassword
    {
        get => _password!;
        set
        {
            if (_password != value)
            {
                _password = value;
                OnPropertyChanged(nameof(UserPassword));
            }
        }
    }
    public string Mobile
    {
        get => _mobile!;
        set
        {
            if (_mobile != value)
            {
                _mobile = value;
                OnPropertyChanged(nameof(Mobile));
            }
        }
    }
    public bool EntryAsPassword
    {
        get => _entryAsPassword;
        set
        {
            if (_entryAsPassword != value)
            {
                _entryAsPassword = value;
                OnPropertyChanged(nameof(EntryAsPassword));
            }
        }
    }
    public string PasswordIconCode
    {
        get => _passwordIconCode!;
        set
        {
            if (_passwordIconCode != value)
            {
                _passwordIconCode = value;
                OnPropertyChanged(nameof(PasswordIconCode));
            }
        }

    }

    private void TogglePasswordButton()
    {
        PasswordEntry.IsPassword = !PasswordEntry.IsPassword;
        if (EntryAsPassword)
            PasswordIconCode = FontHelper.CLOSED_EYE_ICON;
        else
            PasswordIconCode = FontHelper.OPEN_EYE_ICON;

    }
    private void SignUp()
    {
        //Register user into DB
        //Save User to Current User
        //Go to Main Page
    }
    private bool Validate()
    {
        return true;
    }
}
