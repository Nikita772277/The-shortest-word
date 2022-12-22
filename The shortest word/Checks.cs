using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace The_shortest_word
{
    internal class Checks
    {
        public string MaxLong(string text)
        {           
            if (string.IsNullOrEmpty(text))
            {
                return "Строка пуста";
            }
            int number = 0, counterLetter = 0, counterNumber = 0; ;            
            var words= text.Split(' ');
            for(int i=0; i<words.Length; i++)
            {
                foreach(char symbol in words[i])
                {
                    if (char.IsDigit(symbol)||char.IsNumber(symbol))
                    {
                        counterNumber++;
                    }
                    else if(char.IsLetter(symbol))
                    {
                        counterLetter++;
                    }
                }
                if(counterLetter > 0&& counterNumber > 0)
                {
                    counterLetter += counterNumber;
                }
                if (counterLetter > number)
                {
                    number = counterLetter;
                }
                counterLetter=0;
                counterNumber = 0;
            }
            string maxNumberLetters = number.ToString();
            if (number == 0)
            {
                maxNumberLetters = "В строке нет символов которые можно посчитать";
            }
            return maxNumberLetters;
        }
        public string MinLong(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return "Строка пуста";
            }            
            var words = text.Split(' ');
            int number = 2147483647, counterLetter = 0, counterNumber = 0;
            for (int i = 0; i < words.Length; i++)
            {
                foreach (char symbol in words[i])
                {
                    if (char.IsDigit(symbol) || char.IsNumber(symbol))
                    {
                        counterNumber++;
                    }
                    else if (char.IsLetter(symbol))
                    {
                        counterLetter++;
                    }
                }
                if (counterLetter > 0 && counterNumber > 0)
                {
                    counterLetter += counterNumber;
                }
                if (counterLetter < number&& counterLetter>0)
                {
                    number = counterLetter;
                }
                counterLetter = 0;
                counterNumber = 0;
            }
            string maxNumberLetters = number.ToString();
            if (number == 2147483647)
            {
                maxNumberLetters = "В строке нет символов которые можно посчитать";
            }
            return maxNumberLetters;
        }
    }
}
