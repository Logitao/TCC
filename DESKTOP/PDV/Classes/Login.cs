using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using PDV.Conexão;

namespace PDV.Forms.Venda
{
    public class Login
    {
        public Login(string usuario, string senha, Conn cn)
        {
            Usuario = usuario;
            Senha = senha;
            Cn = cn;
            DataTable T = new DataTable();
            T = cn.ReturnLogin(usuario, senha);

            if (T.Rows.Count == 1)
            {
                IdUsuario = int.Parse(T.Rows[0]["IDUSUARIO"].ToString());
                IdPermissao = int.Parse(T.Rows[0]["IDPERMISSAO"].ToString());
                IdFuncionario = int.Parse(T.Rows[0]["IDFUNCIONARIO"].ToString());
                Status = int.Parse(T.Rows[0]["STATUS"].ToString());

                LoginSucesso = true;
            }
            else LoginSucesso = false;

        }
        public bool LoginSucesso { get; set; }
        public int IdUsuario { get; set; }
        public int IdFuncionario { get; set; }
        public int IdPermissao { get; set; }
        public String Usuario { get; set; }
        public String Senha { get; set; }
        public int Status { get; set; }
        public Conn Cn { get; set; }
    }
}
