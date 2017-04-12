using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapperReflect
{
    class Program
    {
        static void Main(string[] args)
        {
            Mapper m = AutoMapper.Build(typeof(Student), typeof(Person));
            Student s = new Student { Nr = 27721, Name = "Ze Manel" };
            Person p = (Person)m.Map(s);

    }

    class Student
    {
        public string Name { get; set; }
        public int Nr { get; set; }
    }

    class Person
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }

    class Teacher
    {

        
        public Teacher(int nr, string name)
        {
            Id = nr;
            Name = name;    
        }

        public string Name { get; set; }
        public int Id { get; set; }
    }

}
