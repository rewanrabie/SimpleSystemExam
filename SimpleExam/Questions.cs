using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleExam
{
    public abstract class Questions // abstract ==> هورث منه 
    {
        public abstract string Header { get; } // عشان كدا كدا مش هيتغير
        public int Marks { get; set; }
        public string Body { get; set; }
        public Answer[] AnswerList { get; set; }
        public Answer UserAnswer { get; set; }
        public Answer RightAnswer { get; set; }

        protected Questions()
        {
            RightAnswer = new Answer();
            UserAnswer = new Answer();
        }

        public abstract void AddQuestions();

        public override string ToString()
        {
            return $"{Header} \t Marks{Marks}\n ======================\n {Body} ";
        }
    }
}
