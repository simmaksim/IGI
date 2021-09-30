using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEB_953506_SLIZH.Entities
{
    public class Player
    {
        public int PlayerId { get; set; }
        public string NickName { get; set; }
        public string Team { get; set; }
        public int Cost { get; set; }
        public string Photo { get; set; }

        public int DisciplineId { get; set; }
        public Discipline DisciplineName { get; set; }
    }
}
