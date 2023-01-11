using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiotec_exc.Entities
{
    public class DadosEmail
    {
        public string Nome { get; set; }
        public string Remetente { get; set; }
        public string Destinatario { get; set; }
        public DateTime Data { get; set; }
        public string Conteudo { get; set; }
    }
}
