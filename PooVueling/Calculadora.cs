using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 
/// </summary>
namespace PooVueling
{
  public class Calculadora : ICalculadora, IPorcentaje
  {
    /// <summary>
    /// Divisions the specified num1.
    /// </summary>
    /// <param name="num1">The num1.</param>
    /// <param name="num2">The num2.</param>
    /// <returns></returns>
    public int Division(int num1, int num2)
    {
      return num1 / num2;
      //throw new NotImplementedException();
    }

    /// <summary>
    /// Multiplicacions the specified num1.
    /// </summary>
    /// <param name="num1">The num1.</param>
    /// <param name="num2">The num2.</param>
    /// <returns></returns>
    public int Multiplicacion(int num1, int num2)
    {
      return num1 * num2;
      //throw new NotImplementedException();
    }

    /// <summary>
    /// Restas the specified num1.
    /// </summary>
    /// <param name="num1">The num1.</param>
    /// <param name="num2">The num2.</param>
    /// <returns></returns>
    public int Resta(int num1, int num2)
    {
      return num1 - num2;
      //throw new NotImplementedException();
    }

    /// <summary>
    /// Sumas the specified num1.
    /// </summary>
    /// <param name="num1">The num1.</param>
    /// <param name="num2">The num2.</param>
    /// <returns></returns>
    public int Suma(int num1, int num2)
    {
      return num1 + num2;
      //throw new NotImplementedException();
    }

    /// <summary>
    /// Porcentajes the specified num1.
    /// </summary>
    /// <param name="num1">The num1.</param>
    /// <param name="num2">The num2.</param>
    /// <returns></returns>
    public double Porcentaje(int num1, int num2)
    {
      return ((num1 * num2) / 100);
      //throw new NotImplementedException();
    }

  }
}
