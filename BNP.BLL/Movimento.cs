using BNP.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BNP.BLL
{
    public class Movimento
    {


        public static List<DTO.Movimento> Listar(bool listSomenteAtivos = true)
        {
            var retorno = new List<DTO.Movimento>();
            try
            {
                MovimentoDAO dao = new MovimentoDAO();                
                retorno = dao.ListarTodos();
            }
            catch (Exception ex)
            {
                
                throw ex;
            }

            return retorno;

        }


        public static int Gravar(DTO.Movimento movimento)
        {
            int retorno;
            try
            {
                using (var dal = new MovimentoDAO())
                {
                   
                        retorno = dal.Gravar(movimento);
                   
                }
            }
            catch (Exception ex)
            {
                
                throw  ex;
            }
            return retorno;
        }
    }
}
    