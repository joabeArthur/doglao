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
    double  fominha = 0;
    double dolly = 0;
    double Ratata = 0;

//----------------------------------------------------------------------------------------------------\\

    public void SetDolly(double d)
    {
        if (d < 0)
        {
            dolly = 0;
        }
        else if (d > 1)
        {
            dolly = 1;
        }
        else 
        {
            dolly = d;
        }
    }

    public void SetFominha(double f)
    {
        if (f < 0)
        {
            fominha = 0;
        }
        else if (f > 1)
        {
            fominha = 1;
        }
        else
        {
            fominha = f;
        }
    }

    public void SetRatata(double r)
    {
        if (r < 0)
        {
            Ratata = 0;
        }
        else if (r > 1)
        {
            Ratata = 1;
        }
        else
        {
            Ratata = r;
        }
    }

//----------------------------------------------------------------------------------------------------\\
    public double Getfominha()
    {
        return fominha;
    }

    public double Getdolly()
    {
        return dolly;
    }

    public double GetRatata()
    {
        return Ratata;
    }

}