namespace douglao;

public  class Objetosjogo 
{
//----------------------------------------------------------------------------------------------------\\

     protected string coisas;
    public string GetCoisas()
    {
        return coisas;
    }

//----------------------------------------------------------------------------------------------------\\
    protected int fominha = 0;
    protected int dolly = 0;
    protected int Ratata = 0;

//----------------------------------------------------------------------------------------------------\\

    public void BarraDollyNv(int Bn)
    {
        if (Bn < 0)
        {
            dolly = 0;
        }
        else if (Bn < 1)
        {
            dolly = 1;
        }
    }

    public void BarraFominhaNv(int Bn)
    {
        if (Bn < 0)
        {
            fominha = 0;
        }
        else if (Bn < 1)
        {
            fominha = 1;
        }
    }

    public void BarraRatataNv(int Bn)
    {
        if (Bn < 0)
        {
            Ratata = 0;
        }
        else if (Bn < 1)
        {
            Ratata = 1;
        }
    }

//----------------------------------------------------------------------------------------------------\\
    public int Getfominha()
    {
        return fominha;
    }

    public int Getdolly()
    {
        return dolly;
    }

    public int GetRatata()
    {
        return Ratata;
    }

}