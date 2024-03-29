﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQL_test.Models
{
    public class Company
    {
        [Key]
        [ForeignKey("Location")]
        public int IdCompany { get; set; }
        public string Title { get; set; }
        public Location Location { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
