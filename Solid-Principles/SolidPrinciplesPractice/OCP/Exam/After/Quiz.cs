using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplesPractice.Exam.After
{
    public class Quiz
    {
        public List<Question> Questions { get; }

        public Quiz(List<Question> questions)
        {
            this.Questions = questions;
        }


        public void Print()
        {
            foreach (var q in Questions)
            {
                Console.WriteLine($"{q.Title} [{q.Mark}]");
                q.Print();
                Console.WriteLine("\n\n");
            }
        }
    }
}
