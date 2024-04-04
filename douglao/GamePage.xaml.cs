namespace douglao;

public partial class GamePage : ContentPage
{
	
	mamaco mamaco;  

	calango calango;

	Losmamacos GetCoisas;
	public GamePage()
	{
		InitializeComponent();

		mamaco = new mamaco();
		calango = new calango();
		GetCoisas = mamaco;

		
	}
//-----------------------------------------------------------------------------------------------------------------\\
	protected void TrocaDeBixoD(object sender, EventArgs args)
	{
		if (GetCoisas == mamaco)
		{
			GetCoisas = calango;
		}
		else if (GetCoisas == calango)
		{
			GetCoisas = mamaco;
		}

		Bixoimg.Source = GetCoisas.GetCoisas();

	}


	protected void TrocaDeBixoE(object sender, EventArgs args)
	{
		if (GetCoisas == mamaco)
		{
			GetCoisas = calango;
		}
		else if (GetCoisas == calango)
		{
			GetCoisas = mamaco;
		}

		Bixoimg.Source = GetCoisas.GetCoisas();
	}


//-----------------------------------------------------------------------------------------------------------------\\


	public void ClicaVolta(object sender, EventArgs args)
	{
		 Application.Current.MainPage = new MainPage();
	}












	//void BeberDolyy(){}


}