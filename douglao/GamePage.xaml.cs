namespace douglao;

public partial class GamePage : ContentPage
{
	arvore 	arvore;
	mamaco mamaco;  

	calango calango;

	Objetosjogo GetCoisas;

	public GamePage()
	{
		InitializeComponent();

		mamaco = new mamaco();
		calango = new calango();
		arvore = new arvore();


		GetCoisas = mamaco;

		//objetosjogo = BarraDolly;

		var timer = Application.Current.Dispatcher.CreateTimer();
		timer.Interval = TimeSpan.FromSeconds(1);
		timer.Tick += (s, e) => PassouTempo();
		timer.Start();
		
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
			GetCoisas = arvore;
		}
		else if (GetCoisas == arvore)
		{
			GetCoisas = mamaco;
		}
		

		Bixoimg.Source = GetCoisas.GetCoisas();

	}


	protected void TrocaDeBixoE(object sender, EventArgs args)
	{
		if (GetCoisas == arvore)
		{
			GetCoisas = calango;
		}
		else if (GetCoisas == calango)
		{
			GetCoisas = mamaco;
		}
		else if (GetCoisas == mamaco)
		{
			GetCoisas = arvore;
		}
		
		Bixoimg.Source = GetCoisas.GetCoisas();

	}


//-----------------------------------------------------------------------------------------------------------------\\

	public void PassouTempo()
	{
		GetCoisas.SetFominha(GetCoisas.Getfominha() - 0.01);
		LaBarraFominha.Progress = GetCoisas.Getfominha();

		GetCoisas.SetRatata(GetCoisas.GetRatata() - 0.01);
		LaBarraRatata.Progress = GetCoisas.GetRatata();

		GetCoisas.SetDolly(GetCoisas.Getdolly() - 0.01);
		BarraDolly.Progress = GetCoisas.Getdolly();

		mamaco.SetFominha(mamaco.Getfominha() - 0.01);
		mamaco.SetRatata(mamaco.GetRatata() - 0.001);
		mamaco.SetDolly(mamaco.Getdolly() - 0.0001);

		calango.SetFominha(calango.Getfominha() - 0.07);
		calango.SetRatata(calango.GetRatata() - 0.007);
		calango.SetDolly(calango.Getdolly() - 0.0007);
	}

//-----------------------------------------------------------------------------------------------------------------\\


	public void ClicaVolta(object sender, EventArgs args)
	{
		 Application.Current.MainPage = new MainPage();
	}

//-----------------------------------------------------------------------------------------------------------------\\

	public void BarraDollyV(object sender, EventArgs args)
	{ 														
		GetCoisas.SetDolly(GetCoisas.Getdolly() + 0.1);
		BarraDolly.Progress = GetCoisas.Getdolly();
	}

	public void BarraFominhaV(object sender, EventArgs args)
	{ 														
		GetCoisas.SetFominha(GetCoisas.Getfominha() + 0.1);
		LaBarraFominha.Progress = GetCoisas.Getfominha();
	}

	public void BarraRatataV(object sender, EventArgs args)
	{ 														
		GetCoisas.SetRatata(GetCoisas.GetRatata() + 0.1);
		LaBarraRatata.Progress = GetCoisas.GetRatata();
	}

//-----------------------------------------------------------------------------------------------------------------\\

	public void ArrumarBarra()
	{
		LaBarraFominha.Progress = GetCoisas.Getfominha();

		BarraDolly.Progress = GetCoisas.Getdolly();

		LaBarraRatata.Progress = GetCoisas.GetRatata();

	}

	//void BeberDolyy(){}


}