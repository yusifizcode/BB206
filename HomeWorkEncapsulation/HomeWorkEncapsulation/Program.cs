namespace HomeWorkEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person(21, "Yusif    Osmanov", "+994555555555");

            //Console.WriteLine(person.FullName);

            Console.WriteLine(Capitalize("salam"));
        }

        static string Capitalize(string word)
        {                               // salam
            string capitalizedWord = "";

            switch (word[0])
            {
                case 'a':
                    capitalizedWord += 'A';
                    break;
                case 'b':
                    capitalizedWord += 'B';
                    break;
                case 'c':
                    capitalizedWord += 'C';
                    break;
                case 'd':
                    capitalizedWord += 'D';
                    break;
                case 'e':
                    capitalizedWord += 'E';
                    break;
                case 'f':
                    capitalizedWord += 'F';
                    break;
                case 'g':
                    capitalizedWord += 'G';
                    break;
                case 'h':
                    capitalizedWord += 'H';
                    break;
                case 'i':
                    capitalizedWord += 'I';
                    break;
                case 'j':
                    capitalizedWord += 'J';
                    break;
                case 'k':
                    capitalizedWord += 'K';
                    break;
                case 'l':
                    capitalizedWord += 'L';
                    break;
                case 'm':
                    capitalizedWord += 'M';
                    break;
                case 'n':
                    capitalizedWord += 'N';
                    break;
                case 'o':
                    capitalizedWord += 'O';
                    break;
                case 'p':
                    capitalizedWord += 'P';
                    break;
                case 'q':
                    capitalizedWord += 'Q';
                    break;
                case 'r':
                    capitalizedWord += 'R';
                    break;
                case 's':
                    capitalizedWord += 'S';
                    break;
                case 't':
                    capitalizedWord += 'T';
                    break;
                case 'u':
                    capitalizedWord += 'U';
                    break;
                case 'v':
                    capitalizedWord += 'V';
                    break;
                case 'w':
                    capitalizedWord += 'W';
                    break;
                case 'x':
                    capitalizedWord += 'X';
                    break;
                case 'y':
                    capitalizedWord += 'Y';
                    break;
                case 'z':
                    capitalizedWord += 'Z';
                    break;
                default:

                    capitalizedWord += word[0];
                    break;
            }

            for (int i = 1; i < word.Length; i++)
            {
                capitalizedWord += word[i];
            }

            return capitalizedWord;
        }
    }
}