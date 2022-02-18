using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyecrosPP

{ }
public class operacionesnew
{
    double resultado = 0;
    public operacionesnew()
    {
    }
    public double suma(double v1, double v2)
    {
        try
        {
            resultado = v1 + v2;
            return resultado;

        }
        catch
        {
            return resultado;
        }
    }
    public double resta(double v1, double v2)
    {
        try
        {
            resultado = v1 - v2;
            return resultado;

        }
        catch
        {
            return resultado;
        }


    }
    public double multiplicar(double v1, double v2)
    {
        try
        {
            resultado = v1 * v2;
            return resultado;

        }
        catch
        {
            return resultado;
        }

    }
    public double dividir(double v1, double v2)
    {
        try
        {
            resultado = v1 / v2;
            return resultado;

        }
        catch
        {
            return resultado;
        }
    }
}