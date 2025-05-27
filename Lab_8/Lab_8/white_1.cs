using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Lab_8
{
    class White_1 : White
    {
        private int answer;

        public int Output => answer;

        public White_1(string input) : base(input) { }

        public override void Review()
        {
            answer = 0;
            if (Input==null)
            {
                return;
            }
            bool word = false;
            foreach (char c in Input)
            {
                if (IsWordChar(c)) 
                {
                    if(word == false)
                    {
                        answer++;
                    }
                    word = true;
                }
                else
                {
                    word = false;
                }
                if (IsPunctuation(c))
                {
                    answer++;
                }
            }

        }

        public override string ToString()
        {
            return answer.ToString();
        }
    }
}
