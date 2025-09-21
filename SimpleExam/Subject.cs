using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleExam
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam SubjectExam { get; set; }

        public Subject(int _subjectId, string _subjectName)
        {
            SubjectId = _subjectId;
            SubjectName = _subjectName;
        }

        public void CreateExam()
        {
            int examType,examTime,numOfQuestion;
            do
            {
                Console.WriteLine("Enter 1 for Practal / 2 for Final");
            } while (!int.TryParse(Console.ReadLine(), out examType) || examType < 1 || examType > 3);

            do
            {
                Console.WriteLine("Enter Exam Time");
            } while (!int.TryParse(Console.ReadLine(), out examTime) || examTime < 30 || examTime > 180);
            do
            {
                Console.WriteLine("Enter Number Of Question");
            } while (!int.TryParse(Console.ReadLine(), out numOfQuestion) || numOfQuestion < 1);

            if (examType==1)
            {
                SubjectExam = new PractcalExam(examTime, numOfQuestion);
            }
            else SubjectExam = new FinalExam(examTime, numOfQuestion);
            Console.Clear();
            SubjectExam.CreateListOfQuestion();
        }
    }
}
