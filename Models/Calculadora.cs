using System;
using exemploPOO.Models;
using exemploPOO.Interfaces;


namespace exemploPOO.Models
{
  public class Calculadora : ICalculadora
  {
    public int Dividir(int first, int second)
    {
      try {
          return first/second;
      }
      catch(DivideByZeroException)
      {
          throw new DivideByZeroException();
      }
    }

    public int Multiplicar(int first, int second)
    {
      return first * second;
    }

    public int Somar(int first, int second)
    {
      return first + second;
    }

    public int Subtrair(int first, int second)
    {
      return first - second;
    }
  }
}