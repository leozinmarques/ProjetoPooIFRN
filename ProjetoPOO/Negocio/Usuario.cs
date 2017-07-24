using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Usuario
    {
        private Persistencia.Usuario per = new Persistencia.Usuario();

        public List<Modelo.Usuario> Selecionar()
        {
            return per.Selecionar();
        }

        public void Inserir(Modelo.Usuario user)
        {
            if(user == null)
            {
                throw new ArgumentNullException("Dados não informados!");
            }
            // if fazer um para checar se já existe

            per.Inserir(user);
        }

        public void Atualizar(Modelo.Usuario user)
        {
            per.Atualizar(user);
        }

        public void Deletar(Modelo.Usuario user)
        {
            per.Deletar(user);
        }

    }
}
