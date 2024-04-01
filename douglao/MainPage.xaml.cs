namespace douglao;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	 public void IrOutraPage(object sender, EventArgs args)
    {
        Application.Current.MainPage = new GamePage();
    }

	public void FrameON(object sender, EventArgs args)
	{
		Oframe.IsVisible = true;
	}

	public void FrameOFF(object sender, EventArgs args)
	{
		Oframe.IsVisible = false;
	}


}

