using Leo.DAL;
using Leo.DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace Leo.BLL
{
   
    public class UserBLL : IUser<Usuario>
    {
        public Usuario GetUserId(int id)
        {
            try
            {
                string sql = "SELECT Id,Nome,Email,Senha FROM Clientes WHERE Id = " + id;
                DataTable tabela = new DataTable();
                tabela = AcessoDB.GetDataTable(sql);
                return GetUsuario(tabela);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Usuario GetUsuario(DataTable tabela)
        {
            try
            {
                Usuario _Usuario = new Usuario();
                if (tabela.Rows.Count > 0)
                {
                    _Usuario.Id = Convert.ToInt32(tabela.Rows[0][0]);
                    _Usuario.nome = Convert.ToString(tabela.Rows[0]["Nome"]);
                    _Usuario.email = tabela.Rows[0][4].ToString();
                    _Usuario.senha = tabela.Rows[0][5].ToString();
                    return _Usuario;
                }
                else
                {
                    _Usuario = null;
                    return _Usuario;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Usuario> Exibir()
        {
            try
            {
                string sql = "SELECT * FROM Usuarios";
                DataTable tabela = new DataTable();
                tabela = AcessoDB.GetDataTable(sql);
                return GetListaUsuario(tabela);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Usuario> GetListaUsuario(DataTable tabela)
        {
            try
            {
                List<Usuario> listaUsuario = new List<Usuario>();
                int i = 0;
                dynamic registros = tabela.Rows.Count;
                if (registros > 0)
                {
                    foreach (DataRow drRow in tabela.Rows)
                    {
                        Usuario _Usuario = new Usuario();
                        _Usuario.Id = Convert.ToInt32(tabela.Rows[i][0]);
                        _Usuario.nome = Convert.ToString(tabela.Rows[i]["Nome"]);
                        _Usuario.email = tabela.Rows[i][4].ToString();
                        _Usuario.senha = tabela.Rows[i][5].ToString();
                        listaUsuario.Add(_Usuario);
                    }
                    while (i <= registros)
                    {
                        Usuario _Usuario = new Usuario();
                        _Usuario.Id = Convert.ToInt32(tabela.Rows[i][0]);
                        _Usuario.nome = Convert.ToString(tabela.Rows[i]["Nome"]);
                        _Usuario.email = tabela.Rows[i][4].ToString();
                        _Usuario.senha = tabela.Rows[i][5].ToString();
                        listaUsuario.Add(_Usuario);
                        i += i;
                    }
                    return listaUsuario;
                }
                else
                {
                    listaUsuario = null;
                    return listaUsuario;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable ConsultarPorID(int id)
        {
            string sql = "SELECT Id,Nome,Email,Senha FROM Usuario WHERE Id = " + id;
            try
            {
                return AcessoDB.GetDataTable(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable Consultar(string nome)
        {
            string sql = "SELECT Id,Nome FROM Usuario WHERE Nome LIKE '" + nome + "%'" + " ORDER BY Nome";
            try
            {
                return AcessoDB.GetDataTable(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Incluir(Usuario oCliente)
        {
            string sql = "";
            try
            {
                string[] parametrosNomes = new string[6];
                parametrosNomes[0] = "@Nome";
                parametrosNomes[3] = "@Email";
                parametrosNomes[4] = "@Senha";
                string[] parametrosValores = new string[6];
                parametrosValores[0] = oCliente.nome;
                //
                parametrosValores[3] = oCliente.email;
                parametrosValores[4] = oCliente.senha;
                sql = "INSERT INTO Usuario(Nome,Email,Senha) values (@Nome,@Email,@Senha)";
                AcessoDB.CRUD(sql, parametrosNomes, parametrosValores);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Alterar(Usuario oCliente)
        {
            string sql = "";
            try
            {
                string[] parametrosNomes = new string[7];
                parametrosNomes[0] = "@Id";
                parametrosNomes[1] = "@Nome";
                parametrosNomes[4] = "@Email";
                parametrosNomes[5] = "@Senha";
                string[] parametrosValores = new string[7];
                parametrosValores[0] = oCliente.Id.ToString();
                parametrosValores[1] = oCliente.nome;
                //
                parametrosValores[4] = oCliente.email;
                parametrosValores[5] = oCliente.senha;
                sql = "UPDATE Usuario SET Nome=@Nome,Email=@Email , Senha=@Senha Where Id=@Id";
                AcessoDB.CRUD(sql, parametrosNomes, parametrosValores);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Excluir(Usuario oCliente)
        {
            string sql = "";
            try
            {
                string[] parametrosNomes = new string[1];
                parametrosNomes[0] = "@Id";
                string[] parametrosValores = new string[1];
                parametrosValores[0] = oCliente.Id.ToString();
                sql = "DELETE FROM Usuario Where Id=@Id";
                AcessoDB.CRUD(sql, parametrosNomes, parametrosValores);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ExibirTodos()
        {
            string sql = "SELECT * FROM Usuario";
            try
            {
                return AcessoDB.GetDataTable(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
