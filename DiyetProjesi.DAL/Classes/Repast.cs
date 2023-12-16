using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetProjesi.DAL.Classes
{
    public class Repast
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public virtual List<Process> Processes { get; set; } = new();

        public override string ToString()
        {
            return Name;
        }
    }
}
