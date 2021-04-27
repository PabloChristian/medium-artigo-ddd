using System;

namespace SG.Vendas.Domain
{
    public class PedidoVendaFactory
    {
      public PedidoVendaEntity CriarPedido()
      {
        return new PedidoVendaEntity();
      }
    }
}
