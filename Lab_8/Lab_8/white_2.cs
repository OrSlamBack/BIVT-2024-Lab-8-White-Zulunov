using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;


namespace Lab_8
{
    public class White_2 : White
    {
        private int [,] array;

        public int [,] Output
        {
            get
            {
                int n, m;
                if (array == null)
                {
                    return null;
                }
                n = array.GetLength(0);
                m = array.GetLength(1);
                int[,] _array = new int[n, m];
                for(int i = 0;i < n; i++)
                {
                    for(int j = 0;j < m; j++)
                    {
                        _array[i,j] = array[i, j];
                    }
                }

                return _array;
            }
        }

        public White_2(string input) : base(input) { }

        public override void Review()
        {
                int MaxSyllables = 0;
                array = new int[0 , 0];
                if (Input == null)
                {
                    return;
                }
                
                {
                    bool word = false;
                    bool number = false;
                    int syllables = 0;
                    foreach (char c in Input)
                    {
                        if (IsWordChar(c) || c >= '0' &&  c<='9')
                        {
                            if(c >= '0' && c <= '9')
                            {
                                number = true;
                            }
                            word = true;
                            if (IsVowel(c)) syllables++;
                        }
                        else
                        {
                            if (syllables == 0 && word) syllables = 1;
                            if(!number)MaxSyllables = Math.Max(MaxSyllables, syllables);
                            syllables = 0;
                            word = false;
                            number = false;
                        }
                    }
                    if (word)
                    {
                        if(syllables == 0)
                        {
                            syllables = 1;
                        }
                        if(!number)MaxSyllables = Math.Max(MaxSyllables, syllables);
                    }
                }
                array = new int[MaxSyllables,2];
                for(int i = 0;i < MaxSyllables; i++)
                {
                    array[i , 0] = i + 1;
                }

                {
                    bool word = false;
                    int syllables = 0;
                    bool number = false;
                    foreach (char c in Input)
                    {
                        if (IsWordChar(c) || c >= '0' && c <= '9')
                        {
                            if (c >= '0' && c <= '9')
                            {
                                number = true;
                            }
                            word = true;
                            if (IsVowel(c)) syllables++;
                        }
                        else
                        {
                            if (word && !number)
                            {
                                if (syllables == 0) syllables = 1;
                                if (syllables > 0) array[syllables - 1, 1]++;
                            }
                            syllables = 0;
                            word = false;
                            number = false;
                        }
                    }
                    if(word && !number)
                    {
                        if (syllables == 0) syllables = 1;
                        if (syllables > 0) array[syllables - 1, 1]++;
                    }
                }
                int n = 0;
                for(int i = 0;i < MaxSyllables; i++)
                {
                    if (array[i, 1] > 0) { n++; }
                }
                int[,] t = new int[n, 2];
                int j = 0;
                for (int i = 0; i < MaxSyllables; i++) 
                {
                    if (array[i, 1] > 0) 
                    {
                        t[j, 0] = array[i, 0];
                        t[j, 1] = array[i, 1];
                        j++;
                    }
                }
                array = t;
        }
        public override string ToString()
        {
            string res = "";
            if(array == null)
            {
                return res;
            }
            for (int i = 0; i < array.GetLength(0); i++) {
                if (i < array.GetLength(0) - 1) res = res + array[i, 0].ToString() + " - " + array[i, 1].ToString() + Environment.NewLine;
                else res = res + array[i, 0].ToString() + " - " + array[i, 1].ToString();
            }
            return res; 
        }

    }
}

