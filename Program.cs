using System;

namespace Constructivemethods
{
    class Program
     {
         static void Main(string[] args)
         {
             Console.WriteLine("******* Calisan 1 *********") ;

             Employee employee1 = new Employee ("Ayse", "Kara" , 1 , "insan kaynaklari") ;
             employee1.employeeInfo() ;
             Console.WriteLine("******* Calisan 2 *********") ;
             Employee employee2 = new Employee ("Deniz", "Arda" , 2 , "satin alma") ;
             employee2.employeeInfo() ;
             Console.WriteLine("******* Calisan 3 *********") ;
             Employee employee3 = new Employee ("baris", "demirkap" ) ;
             employee3.employeeInfo() ;
         }
         
     }



     class Employee
     {
         public string name ;
         public string surname ;
         public int no ;
         public string department ;
         public Employee(string Name, string Surname )
        {
            this.name = Name ;
            this.surname = Surname;
            
        }
        public Employee(string Name, string Surname , int No , string Department)
        {
            this.name = Name ;
            this.surname = Surname;
            this.no = No ;
            this.department = Department ;
        }
        public void employeeInfo() 
        {Console.WriteLine("Name of the Employee:{0}", name) ;
        Console.WriteLine("Surname of the Employee:{0}" , surname) ;
        Console.WriteLine("Number of the Employee:{0}" , no) ;
        Console.WriteLine("Department of the Employee:{0}" , department) ;
        }

         }

     }
