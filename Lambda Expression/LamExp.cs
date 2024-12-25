using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expression
{
    public class LamExp
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Marks { get; set; }

    }
    
    public class Lam1
    {
        List<LamExp> l1 = new List<LamExp>();

        
        public void Add1()
        {
            Console.WriteLine("Enter the number of record ");
            int n = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Enter the Name : ");
                string name = Console.ReadLine();

                Console.WriteLine("Enter the Age : ");
                int age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the Marks : ");
                int marks = Convert.ToInt32(Console.ReadLine());

                l1.Add(new LamExp { Name = name, Age = age, Marks = marks });
                
            }
            // Lambda Expression with Anonymous Types
            var name1 = l1.Select(x => new { Name = x.Name, Age = x.Age });
            foreach(var n1 in name1)
            {
                Console.WriteLine(n1);
            }

            // Sorting Lambda Expression
            var sortData = l1.OrderByDescending(x => x.Age);
            foreach(var n2 in sortData)
            {
                Console.WriteLine(string.Format("Name {0} is {1} year Old.", n2.Name, n2.Age));
            }
        }
    }
        

}
