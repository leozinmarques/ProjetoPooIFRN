using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Usuario : IId
    {
        public int id { get; set; }
        public string login { get; set; }
        public string senha { get; set; }

        public int Id { get => id; set => id = value; }
    }
}
