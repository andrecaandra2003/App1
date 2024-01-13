namespace App1.Views;

public partial class AddUpdateClienti : ContentPage
{
	public AddUpdateClienti(AddUpdateClienti viewModel)
	{
		InitializeComponent();
		this.BindingContext = viewModel;
	}
}