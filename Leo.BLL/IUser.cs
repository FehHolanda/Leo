using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leo.DTO;
using System.Data;


namespace Leo.BLL
{   
    public interface IUser<T>
    {
        DataTable ExibirTodos();
        List<T> Exibir();
        void Incluir(T obj);
        void Alterar(T obj);
        void Excluir(T obj);
        DataTable Consultar(string nome);
        Usuario GetUserId(int id);
    }
    
}
