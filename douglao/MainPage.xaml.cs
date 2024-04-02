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
		FrameMenu.IsVisible = true;
		VoltarBut.IsVisible = true;

		IniciarMenu.IsVisible = false;
		Oframe.IsVisible = false;
	}

	public void FrameOFF(object sender, EventArgs args)
	{
		FrameMenu.IsVisible = false;
		VoltarBut.IsVisible = false;

		IniciarMenu.IsVisible = true;
		Oframe.IsVisible = true;
	}


}

