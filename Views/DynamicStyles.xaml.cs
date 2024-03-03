namespace MauiStylesDemo.Views;

public partial class DynamicStyles : ContentPage
{
	public DynamicStyles()
	{
		InitializeComponent();
        Resources["myStyle"] = Resources["firstStyle"];
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        if (Resources["myStyle"] == Resources["firstStyle"])
            Resources["myStyle"] = Resources["secondStyle"];
        else
            Resources["myStyle"] = Resources["firstStyle"];
    }
}