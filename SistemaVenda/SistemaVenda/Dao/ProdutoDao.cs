using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaVenda.Model;

namespace SistemaVenda.Dao
{
    internal class ProdutoDao
    {
        public List<Produto> ProdutoList { get; set; }
        public ProdutoDao() {
            ProdutoList = new List<Produto>();
        }
    }
}
