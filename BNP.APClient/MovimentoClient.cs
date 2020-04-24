using BNP.DTO;
using BNP.APClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BNP.APIClient
{
    public class MovimentoClient : BaseClient
    {
        public MovimentoClient()
            : base()
        {
        }

        public MovimentoClient(string urlFornecedor)
            : base(urlFornecedor)
        {

        }
        public MovimentoClient(HttpSessionStateBase session)
                : base(session)
        {
        }

        public List<Movimento> Listar()
        {
            return this.Get<List<Movimento>>("Movimento");
        }

        public Movimento ListarPorId(int id)
        {
            return this.Get<Movimento>(String.Format("movimento/{0}", id));
        }

        public int Gravar(Movimento movimento)
        {
            return this.Post<int>("movimento", movimento);
        }
    }
}
}
