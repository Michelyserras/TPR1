using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaVenda.Model;

namespace SistemaVenda.Dao
{
    internal class ClienteDao
    {
        private List<Cliente> clientes;
        public ClienteDao() { 
            clientes = new List<Cliente>();
        }

        public void AddCliente(Cliente cliente) {
            clientes.Add(cliente);
        }

        public Cliente BuscarPorId(int Id) {
          for(int i=0; i<clientes.Count; i++)
            {
                if (clientes[i].Equals(Id))
                {
                    Console.WriteLine("Cliente não existe");
                    return clientes[i];
                }
            }
            Console.WriteLine("Cliente não existe");
            return null;
        }

        public List<Cliente> ListarCliente()
        {
            return clientes;
        }
    }
}
