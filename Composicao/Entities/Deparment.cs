using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composicao.Entities
{
    internal class Deparment
    {
        public string Name { get; set; }
        public Deparment()
        {

        }
        public Deparment(string name)
        {
            Name = name;
        }
    }
    
}
