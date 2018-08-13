using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDV.Conexão;

namespace PDV.Classes
{
    public class Categoria
    {
        public Decimal Idcategoria { get; set; }
        public String Descricao { get; set; }
        public Conn Cn { get; set; }
        public Categoria(int id, Conn cn)
        {
            DataTable T = cn.Query("SELECT * FROM TB_CATEGORIA WHERE IDCATEGORIA = " + id);
            Idcategoria = id;
            Descricao = T.Rows[0]["DESCRICAO"].ToString();

        }
    }
}
