using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStudentLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                StudentService service = new StudentService();
                service.Add(new Student
                {
                    Name = "Karl",
                    Age = 54,
                    LastName = "Marx"
                });
                service.Add(new Student
                {
                    Name = "Petro",
                    Age = 22,
                    LastName = "Petrenko"
                });

                Random rand = new Random();
                foreach (Student item in service.Students)
                {
                    item.AddMark("C++", rand.Next(1, 12));
                    item.AddMark("C#", rand.Next(1, 12));
                }
            }
                                                                           
        }
    }
}
