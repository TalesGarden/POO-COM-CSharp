using System;
using exemploPOO.Models;

namespace exemploPOO.Models
{
  public class ContaCorrente : Conta
  {
    public override void Creditar(double valor)
    {
        this.saldo += valor;
    }
  }
}