using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM5_PasswordGenerator.Models
{
    public class Generator
    {
        private int _length;

        public Generator(int length, bool[] options)
        {
            Length = length;
            Options = options;
        }

        public int Length
        {
            get => _length;
            set => _length = value > 0 ? value : 4;
        }
        public bool[] Options { get; private set; }

        public string Generate()
        {
            string password = Options[4] ? ExcludeRepetitions() : IncludeRepetitions();
            return password;
        }

        private string ExcludeRepetitions()
        {
            var password = new StringBuilder(_length);
            Random rnd = new();

            for (int i = 0; i < _length;)
            {
                switch (rnd.Next(1, 5))
                {
                    case 1:
                        {
                            if (Options[0]) { password.Append(GetDigit(rnd)); ++i; }
                            break;
                        }
                    case 2:
                        {
                            if (Options[1]) { password.Append(GetSmallLetter(rnd)); ++i; }
                            break;
                        }
                    case 3:
                        {
                            if (Options[2]) { password.Append(GetCapitalLetter(rnd)); ++i; }
                            break;
                        }
                    case 4:
                        {
                            if (Options[3]) { password.Append(GetSymbol(rnd)); ++i; }
                            break;
                        }
                }
                if (password.Length > 1)
                {
                    char c = password[password.Length - 1];
                    for (int j = 0; j < password.Length - 1; ++j)
                    {
                        if (password[j].Equals(c))
                        {
                            --i;
                            password.Remove(password.Length - 1, 1);
                            break;
                        }
                    }
                }
            }
            return password.ToString();
        }

        private string IncludeRepetitions()
        {
            var password = new StringBuilder(_length);
            Random rnd = new();

            for (int i = 0; i < _length; ++i)
            {
                switch (rnd.Next(1, 5))
                {
                    case 1:
                        {
                            if (Options[0]) { password.Append(GetDigit(rnd)); }
                            else { --i; }
                            break;
                        }
                    case 2:
                        {
                            if (Options[1]) { password.Append(GetSmallLetter(rnd)); }
                            else { --i; }
                            break;
                        }
                    case 3:
                        {
                            if (Options[2]) { password.Append(GetCapitalLetter(rnd)); }
                            else { --i; }
                            break;
                        }
                    case 4:
                        {
                            if (Options[3]) { password.Append(GetSymbol(rnd)); }
                            else { --i; }
                            break;
                        }
                }
            }
            return password.ToString();
        }
        private string GetDigit(Random rnd) => char.ConvertFromUtf32(rnd.Next(48, 58));
        private string GetCapitalLetter(Random rnd) => char.ConvertFromUtf32(rnd.Next(65, 91));
        private string GetSmallLetter(Random rnd) => char.ConvertFromUtf32(rnd.Next(97, 123));
        private string GetSymbol(Random rnd) => char.ConvertFromUtf32(rnd.Next(33, 48));
    }
}