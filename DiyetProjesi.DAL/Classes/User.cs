using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetProjesi.DAL.Classes
{
    public class User
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string Key { get; set; } = null!;

        public int Age { get; set; }

        public string Gender { get; set; } = null!;

        [Precision(5,2)]
        public decimal Weigth { get; set; }

        public virtual List<Process> Processes { get; set; } = new();

        public virtual List<DailyActivity> DailyActivities { get; set; } = new();

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }

    }
}
