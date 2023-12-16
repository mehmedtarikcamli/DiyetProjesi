using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetProjesi.DAL.Classes
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        [Precision(6,2)]
        public decimal Calories { get; set; }

        [Precision(6, 2)]
        public decimal Carbohydrate { get; set; }


        public int CategoryId { get; set; }


        public byte[]? Image { get; set; }


        public virtual Category Category { get; set; }


        public virtual List<Process> Processes { get; set; } = new();

        public override string ToString()
        {
            return Name + " - " + Calories+" cal, "+Carbohydrate+" gr"; 
        }
    }
}
