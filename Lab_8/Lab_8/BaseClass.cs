using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Lab_8
{
    public abstract class White
    {
        private string input;
        public string Input
        {
            get => input;
            
        }

        protected static readonly char[] punctuations = { '.', '!', '?', ',', ':', '"', ';', '–', '(', ')', '[', ']', '{', '}', '/' };
        protected static readonly char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y', 'A', 'E', 'I', 'O', 'U', 'Y',
                                                    'а', 'е', 'ё', 'и', 'о', 'у', 'ы', 'э', 'ю', 'я', 'А', 'Е', 'Ё', 'И', 'О', 'У', 'Ы', 'Э', 'Ю', 'Я' };
        protected White(string _input)
        {
            input = _input;
        }
        public abstract void Review();
        protected bool IsWordChar(char c)
        {
            return (char.IsLetter(c) || c == '\'' || c == '-');
        }
        protected bool IsPunctuation(char c)
        {
            return (Array.IndexOf(punctuations, c) >= 0);
        }
        protected bool IsVowel(char c)
        {
            return (Array.IndexOf(vowels, c) >= 0);
        }

        
    }

}
