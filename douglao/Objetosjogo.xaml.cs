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
    public int dolly = 0;
    protected int batepinguim = 0;

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

//----------------------------------------------------------------------------------------------------\\
    public int Getfominha()
    {
        return fominha;
    }

    public int Getdolly()
    {
        return dolly;
    }

    public int Getbatepinguim()
    {
        return batepinguim;
    }

}