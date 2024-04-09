namespace douglao;

public partial class GamePage : ContentPage
{
	arvore irvore;
	mamaco mamaco;  

	calango calango;

	Objetosjogo GetCoisas;

	public GamePage()
	{
		InitializeComponent();

		mamaco = new mamaco();
		calango = new calango();
		GetCoisas = mamaco;
		//objetosjogo = BarraDolly;

		
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
			GetCoisas = irvore;
		}
		else if (GetCoisas == irvore)
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
			GetCoisas = irvore;
		}
		else if (GetCoisas == irvore)
		{
			GetCoisas = mamaco;
		}

		Bixoimg.Source = GetCoisas.GetCoisas();
	}


//-----------------------------------------------------------------------------------------------------------------\\

	//public void LaTempo()
	//{}

//-----------------------------------------------------------------------------------------------------------------\\


	public void ClicaVolta(object sender, EventArgs args)
	{
		 Application.Current.MainPage = new MainPage();
	}

//-----------------------------------------------------------------------------------------------------------------\\

	public void BarraDollyV(object sender, EventArgs args)
	{ 														
		BarraDolly.Progress = GetCoisas.Getdolly()+0.2;
	}

	public void BarraFominhaV(object sender, EventArgs args)
	{ 														
		LaBarraFominha.Progress = GetCoisas.Getfominha()+0.1;
	}

	public void BarraRatataV(object sender, EventArgs args)
	{ 														
		LaBarraRatata.Progress = GetCoisas.GetRatata()+0.3;
	}

//-----------------------------------------------------------------------------------------------------------------\\

	//void BeberDolyy(){}


}