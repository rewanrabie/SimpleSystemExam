using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleExam
{
    public class Answer
    {
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }

        public Answer()
        {
            
        }
        public Answer(int _answerid,string _answertext)
        {
            AnswerId = _answerid;
            AnswerText = _answertext;
        }
        public override string ToString()
        {
            return $"{AnswerId} - {AnswerText}";
        }
    }
}
