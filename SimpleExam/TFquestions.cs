using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleExam
{
    public class TFquestions : Questions
    {
        public override string Header => "True / False Question";



        public TFquestions()
        {
            AnswerList = new Answer[2];
            AnswerList[0] = new Answer(1,"True");
            AnswerList[1] = new Answer(2,"False");
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
            } while (!int.TryParse(Console.ReadLine(), out mark) || mark < 1);
            Marks = mark;

            //Right Answer
            int rightAnswerId;
            do
            {
                Console.WriteLine("Enter The Right Answer");
            } while (!int.TryParse(Console.ReadLine(), out rightAnswerId) || rightAnswerId < 1 || rightAnswerId > 3);
            RightAnswer.AnswerId = rightAnswerId;
            RightAnswer.AnswerText = AnswerList[rightAnswerId - 1].AnswerText;
        }
    }
}
