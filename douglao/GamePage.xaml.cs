namespace douglao;

public partial class GamePage : ContentPage
{
	
	mamaco mamaco;  

	calango calango;

	Losmamacos atual;
	public GamePage()
	{
		InitializeComponent();

		mamaco = new mamaco();
		calango = new calango();
		atual = mamaco;

		bixoimg.Source = atual.GetCoisas();
	}

	
	public void Obixo()
	{
		if (atual == mamaco)
		{
			atual = calango;
		}
		else if (atual == calango)
		{
			atual = mamaco;
		}
	}

}