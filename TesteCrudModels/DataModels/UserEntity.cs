using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TesteCrudModels.Models
{
    [Table("Users")]
    public class UserEntity
    {
        [Column("id")]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("name")]
        [NotNull]
        public string Name { get; set; }

        [Column("birth_date")]
        public long BirthDate { get; set; }

        [Precision(10, 2)]
        [Column("income_value")]
        public decimal IncomeValue { get; set; }

        [Column("cpf")]
        public string Cpf { get; set; }
    }
}
