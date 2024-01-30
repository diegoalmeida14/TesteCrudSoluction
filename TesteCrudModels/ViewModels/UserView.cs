using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TesteCrudModels.Models
{
    public class UserView
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public long BirthDate { get; set; }
        [Required]
        public decimal IncomeValue { get; set; }
        [Required,MinLength(11), MaxLength(11)]
        public string Cpf { get; set; }


    }
}
