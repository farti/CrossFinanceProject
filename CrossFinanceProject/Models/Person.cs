using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CrossFinanceProject.Models
{
    [Table("Person")]
    public class Person
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string Surname { get; set; }

        public string NationalIdentificationNumber { get; set; }

        public int AddressId { get; set; }

        public string PhoneNumber { get; set; }

        public string PhoneNumber2 { get; set; }
    }
}