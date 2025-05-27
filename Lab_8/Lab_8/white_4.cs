using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Lab_8
{
    class White_4 : White
    {
        private int answer;

        public int Output => answer;

        public White_4(string input) : base(input) { }

        public override void Review()
        {
            answer = 0;
            if (Input==null)
            {
                return;
            }
            foreach (char c in Input)
            {
                if (c >= '0' && c <= '9')
                    answer += c - '0';
            }

        }

        public override string ToString()
        {
            return answer.ToString();
        }
    }
}
