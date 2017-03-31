namespace StudentsAndCourses
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class Startup
    {
        public static void Main()
        {
            var dictionary = new SortedDictionary<string, SortedSet<Student>>();

            ReadStudentsInfoFromFile("../../input.txt", dictionary);
            foreach (var item in dictionary)
            {
                Console.WriteLine("{0}: {1}", item.Key, string.Join(", ", item.Value));
            }
        }

        private static void ReadStudentsInfoFromFile(string filePath, SortedDictionary<string, SortedSet<Student>> courses)
        {
            var reader = new StreamReader(filePath);

            using (reader)
            {
                string line = reader.ReadLine();
                while (line != string.Empty && line != null)
                {
                    var splitted = line.Split(new char[] { ' ', '|' }, StringSplitOptions.RemoveEmptyEntries);
                    string firstName = splitted[0];
                    string lastName = splitted[1];
                    string courseName = splitted[2];

                    if (courses.ContainsKey(courseName))
                    {
                        courses[courseName].Add(new Student(firstName, lastName));
                    }
                    else
                    {
                        courses[courseName] = new SortedSet<Student>();
                        courses[courseName].Add(new Student(firstName, lastName));
                    }

                    line = reader.ReadLine();
                }
            }
        }
    }
}
