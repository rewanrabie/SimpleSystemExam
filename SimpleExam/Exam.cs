using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SimpleExam
{
    public abstract class Exam
    {
        public int Time { get; set; }
        public int NumberOfQuestions { get; set; }
        public Questions[] ListOfQuestions { get; set; }

        public Exam(int _time,int _numberofquestion)
        {
            Time = _time;
            NumberOfQuestions = _numberofquestion;
        }

        public abstract void ShowExam();

        public abstract void CreateListOfQuestion();
    }
}
