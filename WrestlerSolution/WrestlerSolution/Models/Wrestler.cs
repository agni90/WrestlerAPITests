using System;

namespace WrestlerSolution.Models
{
    public class Wrestler
    {
        public string Lname { get; set; }
        public string Fname { get; set; }
        public string Mname { get; set; }
        public string Dob { get; set; }
        public int Style { get; set; }
        public int Region1 { get; set; }
        public int Region2 { get; set; }
        public int Fst1 { get; set; }
        public int Fst2 { get; set; }
        public int Trainerid1 { get; set; }
        public string Trainer1 { get; set; }
        public int Trainerid2 { get; set; }
        public string Trainer2 { get; set; }
        public int Expires { get; set; }
        public int Lictype { get; set; }
        public int CardState { get; set; }
        public int Id { get; set; }
    }
}
