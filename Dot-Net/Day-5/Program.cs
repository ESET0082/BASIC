namespace ConsoleApp3
{
    using Student = (int id, string name, int marks);

    internal class Program
    {
        static void Main(string[] args)
        {

            List<Student> students = new List<Student>();

            // Add Student objects to the list
            Student first = new Student(1, "Alice", 10);
            Student second = new Student(2, "Bob", 90);
            Student third = new Student(3, "Charlie", 78);
            students.Add(first);
            students.Add(second);
            students.Add(third);


            // Access and display each student using foreach
            Console.WriteLine("Student List:");
            foreach (Student s in students)
            {
                Console.WriteLine($"ID: {s.id}, Name: {s.name}, Marks: {s.marks}");
            }

            // Access a specific object by index
            Console.WriteLine($"\nSecond student is: {students[1].name}");


            //Dictionay Example
            Dictionary<string, Student> students_dict = new Dictionary<string, Student>();
            students_dict.Add("firstStudent", first);
            students_dict.Add("seondStudent", second);
            students_dict.Add("thirdStudent", third);

            Console.WriteLine("Dictionary demo");
            foreach (KeyValuePair<string, Student> student in students_dict)
            {
                //Console.WriteLine(student.Value.id);
                Console.WriteLine($"ID: {student.Value.id}, Name: {student.Value.name}, Marks: {student.Value.marks}");
            }


            //Hashset Example
            Console.WriteLine("Hashset demo");
            HashSet<Student> students_hashset = new HashSet<Student>();
            students_hashset.Add(first);
            students_hashset.Add(second);
            students_hashset.Add(first);
            students_hashset.Add(third);

            foreach (Student student in students_hashset)
            {

                Console.WriteLine($"ID: {student.id}, Name: {student.name}, Marks: {student.marks}");
            }


            //StackDemo


            Stack<Student> students_stack = new Stack<Student>();
            students_stack.Push(first);
            students_stack.Push(second);
            students_stack.Push(third);

            //Student pop_stack = students_stack.Pop();
            //Console.WriteLine(pop_stack.name);
            Console.WriteLine("Stack demo");
            foreach (Student student in students_stack)
            {
                Console.WriteLine($"ID: {student.id}, Name: {student.name}, Marks: {student.marks}");

                //Console.WriteLine($"ID: {student.id}, Name: {student.name}, Marks: {student.marks}");
            }


            //Queue demo
            Console.WriteLine("Queue demo");
            Queue<Student> students_queue = new Queue<Student>();
            students_queue.Enqueue(first);
            students_queue.Enqueue(second);
            students_queue.Enqueue(third);

            foreach (Student student in students_queue)
            {
                Console.WriteLine($"ID: {student.id}, Name: {student.name}, Marks: {student.marks}");
            }
        }
    }

}
