using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Lab_8
{
    public class White_3 : White
    {
        private string answer;
        public string Output => answer;

        private readonly string[,] matrix;

        public White_3(string input, string[,] _matrix) : base(input)
        {
            matrix = _matrix;
        }

        public override void Review()
        {
            answer = "";
            if (Input == null || matrix == null)
            {
                return;
            }
            string word = "";
            foreach ( char c in Input)
            {
                if (IsWordChar(c))
                {
                    word = word + c;
                }
                else
                {
                    answer += FindReplacement(word) + c;
                    word = "";
                }
            }
            if(word.Length>0)answer += FindReplacement(word); 
        }

        private string FindReplacement(string word)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, 0] == word)
                {
                    return matrix[i, 1];
                }
            }
            return word;
        }

        public override string ToString()
        {
            if(answer == null) { return ""; }
            return answer;
        }
    }
}
