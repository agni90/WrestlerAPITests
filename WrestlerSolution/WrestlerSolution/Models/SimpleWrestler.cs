using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrestlerSolution.Models
{
    public class SimpleWrestler
    {
        public int id_wrestler { get; set; }
        public string lname { get; set; }
        public string fname { get; set; }
        public string mname { get; set; }
        public string dob { get; set; }
        public int style { get; set; }
        public int region1 { get; set; }
        public int fst1 { get; set; }
        public int expires { get; set; }
        public int lictype { get; set; }
        public int card_state { get; set; }
        public string photo { get; set; }
        public List<string> attaches { get; set; }
    }
}
