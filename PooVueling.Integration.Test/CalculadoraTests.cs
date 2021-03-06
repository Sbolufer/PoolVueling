﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using PooVueling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooVueling.Tests
{
  [TestClass()]
  public class CalculadoraTests
  {
    //[TestMethod()] //Custom atributs, metadades, dades que defineixen dades

    ICalculadora iCalculadora = new Calculadora();
    IPorcentaje iPorcentaje = new Calculadora();

    [DataRow(4, 2, 2)]
    [DataRow(9, 3, 3)]
    [DataTestMethod]
    public void DivisionTest(int num1, int num2, int resultado)
    {
      Assert.IsTrue(iCalculadora.Division(num1, num2) == resultado);
      //Assert.Fail();
    }

    //[TestMethod()]
    [DataRow(4, 2, 8)]
    [DataRow(9, 3, 27)]
    [DataTestMethod]
    public void MultiplicacionTest(int num1, int num2, int resultado)
    {
      Assert.IsTrue(iCalculadora.Multiplicacion(num1, num2) == resultado);
      //Assert.Fail();
    }

    //[TestMethod()]
    [DataRow(4, 2, 2)]
    [DataRow(9, 3, 6)]
    [DataTestMethod]
    public void RestaTest(int num1, int num2, int resultado)
    {
      Assert.IsTrue(iCalculadora.Resta(num1, num2) == resultado);
      //Assert.Fail();
    }

    //[TestMethod()]
    [DataRow(4, 2, 6)]
    [DataRow(9, 3, 12)]
    [DataTestMethod]
    public void SumaTest(int num1, int num2, int resultado)
    {
      Assert.IsTrue(iCalculadora.Suma(num1, num2) == resultado);
      //Assert.Fail();
    }
    //[TestMethod()]
    //[DataRow(4, 80, 3.2)]
    [DataRow(50, 80, 40)]
    [DataTestMethod]
    public void PorcentajeTest(int num1, int num2, double resultado)
    {
      Assert.IsTrue(iPorcentaje.Porcentaje(num1, num2) == resultado);
      //Assert.Fail();
    }
  }
}