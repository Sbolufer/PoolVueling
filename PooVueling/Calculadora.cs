using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooVueling
{
  public class Calculadora : ICalculadora, IPorcentaje
  {
    public int Division(int num1, int num2)
    {
      return num1 / num2;
      //throw new NotImplementedException();
    }

    public int Multiplicacion(int num1, int num2)
    {
      return num1 * num2;
      //throw new NotImplementedException();
    }

    public int Resta(int num1, int num2)
    {
      return num1 - num2;
      //throw new NotImplementedException();
    }

    public int Suma(int num1, int num2)
    {
      return num1 + num2;
      //throw new NotImplementedException();
    }

    public double Porcentaje(int num1, int num2)
    {
      return ((num1 * num2) / 100);
      //throw new NotImplementedException();
    }

  }
}
