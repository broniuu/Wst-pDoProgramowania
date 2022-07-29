﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazaDanych.Model
{
    internal class Department
    {
        public Department(string departmentName)
        {
            Name = departmentName;
        }

        public int DepartmentId { get; set; }
        public string Name { get; set; }

        public override string? ToString()
        {
            return $"{DepartmentId} |  {Name}";
        }
    }
}