using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetProjesi.DAL.Classes
{
    public class DailyActivity
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int ActivityId { get; set; }

        public DateTime Date { get; set; }

        public int ActivityTime { get; set; }

        public virtual Activity Activity { get; set; }

        public virtual User User { get; set; }
    }
}
