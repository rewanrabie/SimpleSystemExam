using System.Diagnostics;

namespace SimpleExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject s = new Subject(1,"c#");

            s.CreateExam();
            char c;
            do
            {
                Console.WriteLine("Do You Want To Start Exam [Y|N]");
            } while (!char.TryParse(Console.ReadLine(), out c));
            if (c == 'y' || c=='Y')
            {
                Console.Clear();
                Stopwatch sw = new Stopwatch();
                sw.Start();
                s.SubjectExam.ShowExam();
                Console.WriteLine($"Time Token : {sw.Elapsed}");
            }
            else
            {
                Console.WriteLine("Thank You");
            }
        }
    }
}
