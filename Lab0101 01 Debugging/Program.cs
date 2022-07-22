using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab0101_Debugging {
    internal class Program {
        static void Main(string[] args) {
            List<Dictionary<string, string>> list = new List<Dictionary<string, string>>();

            Student s1 = new Student("Baramee", 30, 23, 10);
            s1.CalGrade();
            list.Add(s1.getData());
            Student s2 = new Student("JC", 50, 23, 5);
            s2.CalGrade();
            list.Add(s2.getData());
            Student s3 = new Student("Mind", 20, 23, 20);
            s3.CalGrade();
            list.Add(s3.getData());

            foreach (Dictionary<string, string> student in list) {
                Console.WriteLine("\n");
                foreach (var kvp in student) {
                    Console.WriteLine("{0}, {1}", kvp.Key, kvp.Value);
                }

                Console.WriteLine(student.ToString());
            }
            Console.ReadLine();
        }
    }
    class Student {
        private string Name;
        private string Grade { get; set; }
        private int FinalPoint { get; set; }
        private int MidPoints { get; set; }
        private int Quiz { get; set; }

        private Dictionary<string, string> map;

        public Student(string name, int midPoint, int finalPoint, int quiz) {
            this.Name = name;
            this.MidPoints = midPoint;
            this.FinalPoint = finalPoint;
            this.Quiz = quiz;
        }

        public void CalGrade() {
            int sum = this.MidPoints + this.FinalPoint + this.Quiz;
            if (sum >= 80) {
                this.Grade = "A";
            } else if (sum >= 70) {
                this.Grade = "B";
            } else if (sum >= 60) {
                this.Grade = "C";
            } else if (sum >= 50) {
                this.Grade = "D";
            } else {
                this.Grade = "F";
            }
        }

        public Dictionary<string, string> getData() {
            this.map = new Dictionary<string, string>() {
                { "Name", this.Name },
                { "Quiz", this.Quiz.ToString() },
                { "Mid score", this.MidPoints.ToString() },
                { "Fial score", this.FinalPoint.ToString() },
                { "Grade", this.Grade.ToString() }
            };
            return map;
        }


    }
}

