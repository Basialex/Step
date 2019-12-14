using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
namespace ClassStudentLibrary
{
    public class StudentService
    {
        private string path = "Student.db";
        public IEnumerable<Student> Students { get; set; }
        public StudentService()
        {
            if (File.Exists(path))
                Load();
            else
                Students = new List<Student>();
            Students = new List<Student>();
        }
        public void Load()
        {
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                BinaryFormatter bf = new BinaryFormatter();
                Students = (List<Student>)bf.Deserialize(fs);
            }
        }
        public void Add(Student st)
        {
            (Students as List<Student>).Add(st);
        }
        public void Remove(string lastname)
        {
            List<Student> temp = Students as List<Student>;
            temp.Remove(temp.Find(st => st.LastName.Equals(lastname)));
        }
        public void Save()
        {
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, Students);
            }
        }
    }
}


