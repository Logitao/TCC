using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using PDV.Conexão;

namespace PDV.Forms.Venda
{
    public class Produto
    {
        public long Idproduto { get; set; }
        public int Idfornecedor { get; set; }
        public int Idcategoria { get; set; }
        public string Nomeproduto { get; set; }
        public string Unidade { get; set; }
        public double Valorvenda { get; set; }
        public int Qtatual { get; set; }

        public int Idinterno { get; set; }
        public int Status { get; set; }

        public Conn Cn { get; set; }


        public Produto(long idproduto, int idinterno, Conn cn)
        {
            Idproduto = idproduto;
            Cn = cn;

            DataTable T = Cn.Query("SELECT * FROM TB_PRODUTO WHERE IDPRODUTO = " + idproduto);

            if (T.Rows.Count >= 1)
            {
                Idproduto = long.Parse(T.Rows[0]["IDPRODUTO"].ToString());
                Valorvenda = double.Parse(T.Rows[0]["VALORVENDA"].ToString());
                Nomeproduto = T.Rows[0]["NOMEPRODUTO"].ToString();
                Idfornecedor = int.Parse(T.Rows[0]["IDFORNECEDOR"].ToString());
                Idcategoria = int.Parse(T.Rows[0]["IDCATEGORIA"].ToString());
                Unidade = T.Rows[0]["UNIDADE"].ToString();
                Qtatual = int.Parse(T.Rows[0]["QTATUAL"].ToString());
                Status = 1;
                Idinterno = idinterno;
            }
        }
    }
}
