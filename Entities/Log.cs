using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumindoApi.Entities
{
    internal class Log
    {
        public int Id_log { get; set; }

        public string? Mensagem { get; set; }

        public int Data_criacao { get; set; }

        public bool Verificacao { get; set; }

    }
}
