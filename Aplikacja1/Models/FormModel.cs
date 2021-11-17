using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Aplikacja1.Models
{
    public class FormModel
    {
        [Display(Name = "Imię")]
        public string Name { get; set; }

        [Display(Name = "Liczba powtórzeń")]
        public int NumOfReplications { get; set; }
        public int Replications { get; set; }
    }
}
