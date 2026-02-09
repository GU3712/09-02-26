using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp1.Class2;

namespace ConsoleApp1
{
    internal class Class3
    {
        public class Transacao
        {
            public decimal Valor { get; set; }
            public DateTime Data { get; set; }
            public string Tipo { get; set; }
            public ContaBancaria Origem { get; set; }
            public ContaBancaria Destino { get; set; }
        }
    }
}
