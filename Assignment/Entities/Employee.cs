using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Entities
{
    #region BY Convention
    //class Employee
    //{
    //    // By Con Any table must Hae PK
    //    // public numeric prop [Id || EntityId]
    //    // PK,int, notnull ,sql Identity (1,1)
    //    public int Id { get; set; }


    //    //NvarChar (max), not null
    //    public string Name { get; set; }

    //    //int , notnull
    //    public int? Age { get; set; }

    //    //decimal (18,2)
    //    public decimal Salary { get; set; }

    //    // date
    //    public DateOnly HirringDate { get; set; }

    //    //public string? Adress { get; set; }
    #endregion
    #region Data Annotations 

    //[Table ("EmployeesTable")]
    //[PrimaryKey(nameof(SSn))]
    //class Employee
    //{

    //    public string SSn { get; set; }

    //    [Column(TypeName = "varchar"), MaxLength(30)]
    //    public string Name { get; set; }

    //    public int? Age { get; set; }

    //    [Column(TypeName = "decimal(18,3)")]
    //    public decimal Salary { get; set; }


    //    public DateOnly HirringDate { get; set; }
    #endregion
    #region  Fluent Api
    class Employee
    {

        public int EmpId { get; set; }

        
        public string Name { get; set; }

        public int? Age { get; set; }

        
        public decimal Salary { get; set; }


        public DateOnly HirringDate { get; set; }
        #endregion
    }



