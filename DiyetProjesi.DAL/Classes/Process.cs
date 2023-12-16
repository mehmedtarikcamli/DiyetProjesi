using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetProjesi.DAL.Classes
{
    public class Process
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public virtual User User { get; set; }

        public DateTime Date { get; set; }

        public int RepastId { get; set; }

        public virtual Repast Repast { get; set; }

        public virtual Product Product { get; set; }

        public int ProductId { get; set; }

        public int Portion { get; set; }

        public override string ToString()
        {
            return $"{Product.Name,-10} {Portion}";
        }

    }
}
