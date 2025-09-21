using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleExam
{
    public class PractcalExam : Exam
    {
        public PractcalExam(int time, int numberofquestion) : base(time, numberofquestion)
        {

        }
        public override void CreateListOfQuestion()
        {
            ListOfQuestions = new MCqQuestions[NumberOfQuestions];
            for (int i = 0; i < ListOfQuestions.Length; i++)
            {
                ListOfQuestions[i] = new MCqQuestions();
                ListOfQuestions[i].AddQuestions();
                Console.Clear();
            }
        }

        public override void ShowExam()
        {
            foreach (var question in ListOfQuestions)
            {
                Console.WriteLine(question);

                //Answer
                for (int i = 0; i < question.AnswerList.Length; i++)
                {
                    Console.WriteLine(question.AnswerList[i]);
                }

                Console.WriteLine("=====================================");

                //User Answer 
                int userAnswerId;
                if (question.Header == "MCqQuestions")
                {
                    do
                    {
                        Console.WriteLine("Enter The Number Of Your Answer");
                    } while (!int.TryParse(Console.ReadLine(), out userAnswerId) || userAnswerId < 1 || userAnswerId > 3);                  
                    Console.WriteLine("=======================");
                }
                Console.Clear();
                Console.WriteLine("Right Answer");
                for (int i = 0; i < ListOfQuestions.Length; i++)
                {
                    Console.WriteLine($"Right Answer Of Question {i+1} : {ListOfQuestions[i].RightAnswer.AnswerText}");
                }
            }
        }
    }
}
