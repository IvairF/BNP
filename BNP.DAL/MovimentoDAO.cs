using BNP.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNP.DAL
{
    public class MovimentoDAO : BaseDAO
    {



     
        public List<DTO.Movimento> ListarTodos()
        {
            try
            {                         
                   
                 return Context.Database.SqlQuery<Movimento>("exec Proc_consulta").ToList();                 
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       

        /// <summary>
        /// Gravar novo convênio.
        /// </summary>
        /// <param name="convenio"></param>
        /// <returns></returns>
        public int Gravar(DTO.Movimento movimento)
        {
            var model = new Movimento()
            {
                DAT_MES = movimento.DAT_MES,
                DAT_ANO = movimento.DAT_ANO,
                NUM_LANCAMENTO = movimento.NUM_LANCAMENTO,
                COD_PRODUTO = movimento.COD_PRODUTO,
                COD_CONSIF = movimento.COD_CONSIF,
                DAT_MOVIMENTO = movimento.DAT_MOVIMENTO,
                VAL_VALOR = movimento.VAL_VALOR,
            };
            Context.Movimento.Add(model);
            Context.SaveChanges();
            return model.DAT_MES;
        }

    }
}
