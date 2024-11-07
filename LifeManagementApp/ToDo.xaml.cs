using LifeManagementApp.ViewModel;

namespace LifeManagementApp;

public partial class ToDo : ContentPage
{
    public ToDo()
    {
    }

    public ToDo(MainViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}