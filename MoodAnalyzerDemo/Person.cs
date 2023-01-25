using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MoodAnalyzerDemo
{
    public class Person
    {
        [Required]
        public string FirstName { get; set; }

        [StringLength(5)]
        public string LastName { get; set; }
        [Range(30000,100000)]
        public int Salary { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [RegularExpression("")]
        public string Age { get; set; }
    }


}
