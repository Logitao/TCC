using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace PDV.Conexão
{
    public partial class Conn
    {
        private OracleConnection Con;

        public bool Connect()
        {
            try
            {
                Con = new OracleConnection
                {
                    ConnectionString = @"Data Source=
(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)
(HOST=localhost)
(PORT=1521)))
(CONNECT_DATA=(SID=xe)));
User ID=TCC;Password=123456"
                };
                return true;
            }
            catch (Exception e)
            {
                TratarErro(e);
                return false;
            }
        }

        private void TratarErro(Exception p)
        {
            MessageBox.Show(p.Message);
            Close();
        }


        public bool Open()
        {
            try
            {
                if (Con.State == ConnectionState.Closed)
                {
                    Con.Open();
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                TratarErro(e);
                return false;
            }
        }

        public bool Close()
        {
            try
            {
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                TratarErro(e);
                return false;
            }
        }

        public DataTable Query(string sql, int i = 0)
        {
            try
            {
                if (Open())
                {
                    if (i == 0)
                    {
                        OracleCommand cmd = new OracleCommand(sql, Con);

                        DataSet ds = new DataSet();
                        OracleDataAdapter da = new OracleDataAdapter { SelectCommand = cmd };
                        da.Fill(ds);
                        Close();
                        return ds.Tables[0];
                    }

                    else
                    {
                        OracleCommand cmd = new OracleCommand(sql, Con);
                        cmd.ExecuteNonQuery();
                        Close();
                        return null;
                    }
                }
                else return null;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public bool ExecuteInsertTB_CATEGORIA(string descricao)
        {
            try
            {
                if (Open())
                {
                    OracleCommand cmd = new OracleCommand("INSERT_TB_CATEGORIA", Con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new OracleParameter("DESCRICAO", descricao));
                    cmd.ExecuteNonQuery();
                    Close();
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                TratarErro(e);
                return false;
            }
        }

        public bool ExecuteInsertTB_FORNECEDOR(string cpf_cnpj, string complemento, string cep, string email,
            string telefone, string descricao)
        {
            try
            {
                if (Open())
                {
                    OracleCommand cmd = new OracleCommand("INSERT_TB_FORNECEDOR", Con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new OracleParameter("CPF_CNPJ", cpf_cnpj));
                    cmd.Parameters.Add(new OracleParameter("COMPLEMENTO", complemento));
                    cmd.Parameters.Add(new OracleParameter("CEP", cep));
                    cmd.Parameters.Add(new OracleParameter("EMAIL", email));
                    cmd.Parameters.Add(new OracleParameter("TELEFONE", telefone));
                    cmd.Parameters.Add(new OracleParameter("DESCRICAO", descricao));
                    cmd.ExecuteNonQuery();
                    Close();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                TratarErro(ex);
                return false;
            }
        }

        public bool ExecuteInsertTB_PRODUTO(decimal idfornecedor, decimal idcategoria, string nomeproduto,
            string unidade, decimal valorvenda)
        {
            try
            {
                if (Open())
                {
                    OracleCommand cmd = new OracleCommand("INSERT_TB_PRODUTO", Con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new OracleParameter("IDFORNECEDOR", idfornecedor));
                    cmd.Parameters.Add(new OracleParameter("IDCATEGORIA", idcategoria));
                    cmd.Parameters.Add(new OracleParameter("NOMEPRODUTO", nomeproduto));
                    cmd.Parameters.Add(new OracleParameter("UNIDADE", unidade));
                    cmd.Parameters.Add(new OracleParameter("VALORVENDA", valorvenda));
                    cmd.ExecuteNonQuery();
                    Close();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                TratarErro(ex);
                return false;
            }
        }
        public bool ExecuteInsertTB_PRODUTO(long idproduto, decimal idfornecedor, decimal idcategoria, string nomeproduto,
            string unidade, decimal valorvenda)
        {
            try
            {
                if (Open())
                {
                    OracleCommand cmd = new OracleCommand("INSERT_TB_PRODUTO2", Con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.Add(new OracleParameter("IDPRODUTO", idproduto));
                    cmd.Parameters.Add(new OracleParameter("IDFORNECEDOR", idfornecedor));
                    cmd.Parameters.Add(new OracleParameter("IDCATEGORIA", idcategoria));
                    cmd.Parameters.Add(new OracleParameter("NOMEPRODUTO", nomeproduto));
                    cmd.Parameters.Add(new OracleParameter("UNIDADE", unidade));
                    cmd.Parameters.Add(new OracleParameter("VALORVENDA", valorvenda));
                    cmd.ExecuteNonQuery();
                    Close();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                TratarErro(ex);
                return false;
            }
        }

        public bool ExecuteInsertTB_CARGO(string descricao, decimal salario)
        {
            try
            {
                if (Open())
                {
                    OracleCommand cmd = new OracleCommand("INSERT_TB_CARGO", Con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new OracleParameter("DESCRICAO", descricao));
                    cmd.Parameters.Add(new OracleParameter("SALARIO", salario));
                    cmd.ExecuteNonQuery();
                    Close();
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                TratarErro(ex);
                return false;
            }
        }

        public bool ExecuteInsertTB_FUNCIONARIO(decimal idcargo, string nome, string sexo, DateTime dt_nasc, string rg,
            string cpf, string num_resid, string cep, string telefone, string email, string complemento)
        {
            try
            {
                if (Open())
                {
                    OracleCommand cmd = new OracleCommand("INSERT_TB_FUNCIONARIO", Con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new OracleParameter("IDCARGO", idcargo));
                    cmd.Parameters.Add(new OracleParameter("NOME", nome));
                    cmd.Parameters.Add(new OracleParameter("SEXO", sexo));
                    cmd.Parameters.Add(new OracleParameter("DT_NASC", dt_nasc));
                    cmd.Parameters.Add(new OracleParameter("RG", rg));
                    cmd.Parameters.Add(new OracleParameter("CPF", cpf));
                    cmd.Parameters.Add(new OracleParameter("NUM_RESID", num_resid));
                    cmd.Parameters.Add(new OracleParameter("CEP", cep));
                    cmd.Parameters.Add(new OracleParameter("TELEFONE", telefone));
                    cmd.Parameters.Add(new OracleParameter("EMAIL", email));
                    cmd.Parameters.Add(new OracleParameter("COMPLEMENTO", complemento));
                    cmd.ExecuteNonQuery();
                    Close();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                TratarErro(ex);
                return false;
            }
        }

        public bool ExecuteInsertTB_MVESTOQUE(string tipo, int qtdemov)
        {
            try
            {
                if (Open())
                {
                    OracleCommand cmd = new OracleCommand("INSERT_TB_MVESTOQUE", Con) { CommandType = CommandType.StoredProcedure };
                    cmd.Parameters.Add(new OracleParameter("TIPO", tipo));
                    cmd.Parameters.Add(new OracleParameter("QTDEMOV", qtdemov));
                    cmd.ExecuteNonQuery();
                    Close();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                TratarErro(ex);
                return false;
            }
        }

        public bool ExecuteInsertTB_PRODUTO_MVESTOQUE(long idproduto, int idmov, int quant)
        {
            try
            {
                if (Open())
                {
                    OracleCommand cmd = new OracleCommand("INSERT_TB_PRODUTO_MVESTOQUE", Con) { CommandType = CommandType.StoredProcedure };
                    cmd.Parameters.Add(new OracleParameter("IDPRODUTO", idproduto));
                    cmd.Parameters.Add(new OracleParameter("IDMOV", idmov));
                    cmd.Parameters.Add(new OracleParameter("QUANT", quant));
                    cmd.ExecuteNonQuery();
                    Close();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                TratarErro(ex);
                return false;
            }
        }

        public bool UpdateTB_PRODUTOQUANTIDADE(long id, int quant)
        {
            try
            {
                if (Open())
                {

                    OracleCommand cmd = new OracleCommand("UPDATE_QTATUAL", Con) { CommandType = CommandType.StoredProcedure };
                    cmd.Parameters.Add(new OracleParameter("IDP", id));
                    cmd.Parameters.Add(new OracleParameter("QT", quant));
                    
                   
                    cmd.ExecuteNonQuery();
                    Close();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                TratarErro(ex);
                return false;
            }
        }

        public bool ExecuteInsertTB_PRODUTO_VENDA(decimal idproduto, int status)
        {
            try
            {
                if (Open())
                {
                    OracleCommand cmd = new OracleCommand("INSERT_TB_PRODUTO_VENDA", Con) { CommandType = CommandType.StoredProcedure };
                    cmd.Parameters.Add(new OracleParameter("IDPRODUTO", idproduto));
                    cmd.Parameters.Add(new OracleParameter("STATUS", status));
                    cmd.ExecuteNonQuery();
                    Close();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                TratarErro(ex);
                return false;
            }
        }

        public bool ExecuteInsertTB_VENDA(int status, decimal valor, decimal valor_pago, int idusuario)
        {
            try
            {
                if (Open())
                {
                    OracleCommand cmd = new OracleCommand("INSERT_TB_VENDA", Con) { CommandType = CommandType.StoredProcedure };
                    cmd.Parameters.Add(new OracleParameter("STATUS", status));
                    cmd.Parameters.Add(new OracleParameter("VALOR", valor));
                    cmd.Parameters.Add(new OracleParameter("VALOR_PAGO", valor_pago));
                    cmd.Parameters.Add(new OracleParameter("IDUSUARIO", idusuario));
                    cmd.ExecuteNonQuery();
                    Close();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                TratarErro(ex);
                return false;
            }
        }

        public bool ExecuteInsertTB_USUARIO(int idfuncionario, string login, string senha, int status, int idpermissao)
        {
            try
            {
                if (Open())
                {
                    OracleCommand cmd = new OracleCommand("INSERT_TB_USUARIO", Con) { CommandType = CommandType.StoredProcedure };
                    cmd.Parameters.Add(new OracleParameter("IDFUNCIONARIO", idfuncionario));
                    cmd.Parameters.Add(new OracleParameter("LOGIN", login));
                    cmd.Parameters.Add(new OracleParameter("SENHA", senha));
                    cmd.Parameters.Add(new OracleParameter("STATUS", status));
                    cmd.Parameters.Add(new OracleParameter("IDPERMISSAO", idpermissao));
                    cmd.ExecuteNonQuery();
                    Close();
                }
                return false;
            }
            catch (Exception ex)
            {
                TratarErro(ex);
                return false;
            }
        }

        public bool ExecuteInsertTB_PGTO_VENDA(double valor, int idformapgto)
        {
            try
            {
                if (Open())
                {
                    OracleCommand cmd = new OracleCommand("INSERT_TB_PGTO_VENDA", Con) { CommandType = CommandType.StoredProcedure };
                    cmd.Parameters.Add(new OracleParameter("IDFORMAPGTO", idformapgto));
                    cmd.Parameters.Add(new OracleParameter("VALOR", valor));
                    cmd.ExecuteNonQuery();
                    Close();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                TratarErro(ex);
                return false;
            }
        }

        public bool ExecuteInsertTB_LOG_CAIXA(int idusuario, int idevento, int idcaixa)
        {
            try
            {
                if (Open())
                {
                    OracleCommand cmd = new OracleCommand("INSERT_TB_LOG_CAIXA", Con) { CommandType = CommandType.StoredProcedure };
                    cmd.Parameters.Add(new OracleParameter("IDUSUARIO", idusuario));
                    cmd.Parameters.Add(new OracleParameter("IDEVENTO", idevento));
                    cmd.Parameters.Add(new OracleParameter("IDCAIXA", idcaixa));

                    cmd.ExecuteNonQuery();
                    Close();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                TratarErro(ex);
                return false;
            }
        }

        public DataTable ReturnLogin(string login, string senha)
        {
            try
            {
                if (Open())
                {
                    OracleCommand cmd = new OracleCommand()
                    {
                        CommandType = CommandType.Text,
                        Connection = Con

                    };

                    cmd.Parameters.Add(new OracleParameter("LOGIN", login));
                    cmd.Parameters.Add(new OracleParameter("SENHA", senha));

                    cmd.CommandText = "SELECT * FROM TB_USUARIO WHERE LOGIN = :LOGIN AND SENHA = :SENHA";

                    DataSet ds = new DataSet();
                    OracleDataAdapter da = new OracleDataAdapter
                    {
                        SelectCommand = cmd,

                    };
                    da.Fill(ds);
                    Close();
                    return ds.Tables[0];
                }
                return null;
            }
            catch (Exception ex)
            {
                TratarErro(ex);
                return null;
            }
        }

        public bool ExecuteUpdateTB_CATEGORIA(int idcategoria, string descricao)
        {
            try
            {
                if (Open())
                {
                    OracleCommand cmd = new OracleCommand("UPDATE_TB_CATEGORIA", Con) { CommandType = CommandType.StoredProcedure };
                    cmd.Parameters.Add(new OracleParameter("IDCATEGORI", idcategoria));
                    cmd.Parameters.Add(new OracleParameter("DESCRICA", descricao));
                    cmd.ExecuteNonQuery();
                    Close();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                TratarErro(ex);
                return false;
            }
        }
        public bool ExecuteUpdateTB_CARGO(int idcargo, string descricao, decimal salario)
        {
            try
            {
                if (Open())
                {
                    OracleCommand cmd = new OracleCommand("UPDATE_TB_CARGO", Con) { CommandType = CommandType.StoredProcedure };
                    cmd.Parameters.Add(new OracleParameter("IDCARG", idcargo));
                    cmd.Parameters.Add(new OracleParameter("DESCRICA", descricao));
                    cmd.Parameters.Add(new OracleParameter("SALARI", salario));
                    cmd.ExecuteNonQuery();
                    Close();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                TratarErro(ex);
                return false;
            }
        }
        public bool ExecuteUpdateTB_PRODUTO(long idproduto, int idfornecedor, int idcategoria, string nomeproduto, string unidade, decimal valorvenda)
        {
            try
            {
                if (Open())
                {
                    OracleCommand cmd = new OracleCommand("UPDATE_TB_PRODUTO", Con) { CommandType = CommandType.StoredProcedure };
                    cmd.Parameters.Add(new OracleParameter("IDPRODUT", idproduto));
                    cmd.Parameters.Add(new OracleParameter("IDFORNECEDO", idfornecedor));
                    cmd.Parameters.Add(new OracleParameter("IDCATEGORI", idcategoria));
                    cmd.Parameters.Add(new OracleParameter("NOMEPRODUT", nomeproduto));
                    cmd.Parameters.Add(new OracleParameter("UNIDAD", unidade));
                    cmd.Parameters.Add(new OracleParameter("VALORVEND", valorvenda));
                    cmd.ExecuteNonQuery();
                    Close();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                TratarErro(ex);
                return false;
            }
        }
        public bool ExecuteUpdateTB_USUARIO(int idusuario, int idfuncionario, string login, string senha, decimal status, int idpermissao)
        {
            try
            {
                if (Open())
                {
                    OracleCommand cmd = new OracleCommand("UPDATE_TB_USUARIO", Con) { CommandType = CommandType.StoredProcedure };
                    cmd.Parameters.Add(new OracleParameter("IDUSUARI", idusuario));
                    cmd.Parameters.Add(new OracleParameter("IDFUNCIONARI", idfuncionario));
                    cmd.Parameters.Add(new OracleParameter("LOGI", login));
                    cmd.Parameters.Add(new OracleParameter("SENH", senha));
                    cmd.Parameters.Add(new OracleParameter("STATU", status));
                    cmd.Parameters.Add(new OracleParameter("IDPERMISSA", idpermissao));
                    cmd.ExecuteNonQuery();
                    Close();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                TratarErro(ex);
                return false;
            }
        }
        public bool ExecuteUpdateTB_FORNECEDOR(int idfornecedor, string cpf_cnpj, string complemento, string cep, string email, string telefone, string descricao)
        {
            try
            {
                if (Open())
                {
                    OracleCommand cmd = new OracleCommand("UPDATE_TB_FORNECEDOR", Con) { CommandType = CommandType.StoredProcedure };
                    cmd.Parameters.Add(new OracleParameter("IDFORNECEDO", idfornecedor));
                    cmd.Parameters.Add(new OracleParameter("CPF_CNP", cpf_cnpj));
                    cmd.Parameters.Add(new OracleParameter("COMPLEMENT", complemento));
                    cmd.Parameters.Add(new OracleParameter("CE", cep));
                    cmd.Parameters.Add(new OracleParameter("EMAI", email));
                    cmd.Parameters.Add(new OracleParameter("TELEFON", telefone));
                    cmd.Parameters.Add(new OracleParameter("DESCRICA", descricao));
                    cmd.ExecuteNonQuery();
                    Close();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                TratarErro(ex);
                return false;
            }
        }
        public bool ExecuteUpdateTB_FUNCIONARIO(int idfuncionario, int idcargo, string nome, string sexo, DateTime dt_nasc, string rg, string cpf, string num_resid, string cep, string telefone, string email, string complemento)
        {
            try
            {
                if (Open())
                {
                    OracleCommand cmd = new OracleCommand("UPDATE_TB_FUNCIONARIO", Con) { CommandType = CommandType.StoredProcedure };
                    cmd.Parameters.Add(new OracleParameter("IDFUNCIONARI", idfuncionario));
                    cmd.Parameters.Add(new OracleParameter("IDCARG", idcargo));
                    cmd.Parameters.Add(new OracleParameter("NOM", nome));
                    cmd.Parameters.Add(new OracleParameter("SEX", sexo));
                    cmd.Parameters.Add(new OracleParameter("DT_NAS", dt_nasc));
                    cmd.Parameters.Add(new OracleParameter("R", rg));
                    cmd.Parameters.Add(new OracleParameter("CP", cpf));
                    cmd.Parameters.Add(new OracleParameter("NUM_RESI", num_resid));
                    cmd.Parameters.Add(new OracleParameter("CE", cep));
                    cmd.Parameters.Add(new OracleParameter("TELEFON", telefone));
                    cmd.Parameters.Add(new OracleParameter("EMAI", email));
                    cmd.Parameters.Add(new OracleParameter("COMPLEMENT", complemento));
                    cmd.ExecuteNonQuery();
                    Close();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                TratarErro(ex);
                return false;
            }
        }



    }
}