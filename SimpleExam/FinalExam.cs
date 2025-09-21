using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleExam
{
    public class FinalExam : Exam
    {
        public FinalExam(int time,int numberofquestion):base(time,numberofquestion)
        {

        }
        public override void CreateListOfQuestion()
        {
            ListOfQuestions = new Questions[NumberOfQuestions];
            for (int i =0; i<ListOfQuestions.Length;i++)
            {
                int choice;
                do
                {
                    Console.WriteLine("Enter 1 For Mcq , 2 for True/False Questions");
                } while (!int.TryParse(Console.ReadLine(),out choice) || choice<1 || choice<2);

                Console.Clear();

                if (choice == 1)
                {
                    ListOfQuestions[i] = new MCqQuestions();
                    ListOfQuestions[i].AddQuestions();
                }else if (choice == 2)
                {
                    ListOfQuestions[i] = new TFquestions();
                    ListOfQuestions[i].AddQuestions();
                }

            }
        }

        public override void ShowExam()
        {
            int totalmarks = 0, grade = 0;

            //Question
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
                    } while(!int.TryParse(Console.ReadLine(), out userAnswerId) || userAnswerId < 1 || userAnswerId > 3) ;
                    question.UserAnswer.AnswerId = userAnswerId;
                    question.UserAnswer.AnswerText = question.AnswerList[userAnswerId - 1].AnswerText;
                    Console.WriteLine("=======================");

                    } 
                else if (question.Header == "True/False Questions")
                {
                    do
                    {
                        Console.WriteLine("Enter The Number Of Your Answer");
                    } while (!int.TryParse(Console.ReadLine(), out userAnswerId) || userAnswerId < 1 || userAnswerId > 3);
                    question.UserAnswer.AnswerId = userAnswerId;
                    question.UserAnswer.AnswerText = question.AnswerList[userAnswerId - 1].AnswerText;
                    Console.WriteLine("=======================");
                }
                Console.WriteLine("=======================================");
                Console.Clear();
                totalmarks += question.Marks;
            }
            for (int i=0; i<ListOfQuestions.Length;i++)
            {
                if (ListOfQuestions[i].RightAnswer.AnswerId == ListOfQuestions[i].UserAnswer.AnswerId)
                {
                    grade += ListOfQuestions[i].Marks;
                }
                Console.WriteLine($"Question {i+1} : {ListOfQuestions[i].Body}");
                Console.WriteLine($"Your Answer : {ListOfQuestions[i].UserAnswer.AnswerText}");
                Console.WriteLine($"User Answer  : {ListOfQuestions[i].RightAnswer.AnswerText}");
            }
            Console.WriteLine($"Your Grade = {grade}/{totalmarks}");

            }
        }
    }

