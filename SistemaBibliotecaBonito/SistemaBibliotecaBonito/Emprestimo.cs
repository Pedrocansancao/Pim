using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBibliotecaBonito
{
    public class Emprestimo
    {
        public Usuario Usuario { get; set; }
        public Livro Livro { get; set; }
        public string DataEmprestimo { get; set; }
        public string DataDevolucao { get; set; }
        public bool Devolvido { get; set; }
    }
}
