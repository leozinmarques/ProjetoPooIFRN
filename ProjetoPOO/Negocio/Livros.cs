using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Livros
    {

        private Persistencia.Usuario per = new Persistencia.Usuario();

        public List<Modelo.Livros> Selecionar()
        {
            return per.Selecionar();
        }

        public void Inserir(Modelo.Livros book)
        {
            if (book == null)
            {
                throw new ArgumentNullException("Dados do Livro não informados!");
            }
            // if fazer um para checar se já existe

            per.Inserir(book);
        }

        public void Atualizar(Modelo.Livros book)
        {
            per.Atualizar(book);
        }

        public void Deletar(Modelo.Usuario book)
        {
            per.Deletar(book);
        }
    }
}
