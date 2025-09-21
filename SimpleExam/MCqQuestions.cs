using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleExam
{
    public class MCqQuestions : Questions
    {
        public override string Header => "MCQ Question" ;
        public MCqQuestions()
        {
            AnswerList = new Answer[3];
        }

        public override void AddQuestions()
        {
            //Header
            Console.WriteLine(Header);

            //Body
            Console.WriteLine("Enter The Body Of Question");
            Body = Console.ReadLine();

            //mark
            int mark;
            do
            {
                Console.WriteLine("Enter The Mark Of Question");
            }while(!int.TryParse(Console.ReadLine(),out mark) || mark<1);
            Marks = mark;

            //Answer of Questions
            Console.WriteLine("Enter The Answer Of Question");
            for (int i=0; i<3; i++)
            {
                AnswerList[i] = new Answer()
                {
                    AnswerId = i + 1
                };
                Console.WriteLine($"Enter The Answer number{i+1} Text");
                AnswerList[i].AnswerText = Console.ReadLine();
            }

            //Right Answer
            int rightAnswerId;
            do
            {
                Console.WriteLine("Enter The Right Answer");
            } while (!int.TryParse(Console.ReadLine(), out rightAnswerId) || rightAnswerId < 1 || rightAnswerId>3);
            RightAnswer.AnswerId = rightAnswerId;
            RightAnswer.AnswerText = AnswerList[rightAnswerId - 1].AnswerText;

            Console.Clear();


        }
    }
}
