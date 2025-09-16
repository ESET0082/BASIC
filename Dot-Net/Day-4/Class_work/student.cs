using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class student
    {
        int student_id;
        string name;
        int age;
        string course_name;
        string contactno;
        string emailid;

        public student(string name,int student_id,int age,string course_name)
        {
            this.name = name;
            this.student_id = student_id;
            this.age = age;
            this.course_name = course_name;
        }
        public void initialize()
        {
            student_id = 1;
            name = "gopal";
            age = 100;
            course_name = "science";
        }
        public void show_display()
        {
          
            Console.WriteLine("name : {0}", name);
            Console.WriteLine($"student_id :{student_id}");
            Console.WriteLine($"cource_name :{course_name}");
            Console.WriteLine("age :  {0}", age);  
        }
        public void add_marks()
        {

        }
        public void get_avg()
        {

        }
        public void change_course()
        {

        }
        public void change_contactno()
        {

        }
        public void change_emailid()
        {

        }
    }
}
