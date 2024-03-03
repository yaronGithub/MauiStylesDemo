using MauiStylesDemo.ViewModels;

namespace MauiStylesDemo.Views;

public partial class FormValidation : ContentPage
{
	public FormValidation()
	{
		InitializeComponent();
		this.BindingContext = new FormValidationViewModel();
	}
}