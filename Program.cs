using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Font
{
    internal class Program
    {
        static bool Proverka(string Stroka)
        {
            foreach (char c in Stroka)
            {
                if (int.TryParse(c.ToString(), out var bar) || c == ' ' || c == '\\' || c == '.')
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.SetBufferSize(200, 30);
            Console.Write("Введите ряд цифр от 0 до 9 включая разделители (Пробел,Точка,Слеш): ");
            var Vvod = Console.ReadLine();
            if (!Proverka(Vvod))
            {
                Console.WriteLine("Ввод не корректен!");
            }
            else
            {
                Console.Clear();
                var Razmer = Vvod.Length;
                var SizeX = Razmer * 7;
                var SizeY = 8;
                var x = (Console.WindowWidth / 2) - (SizeX / 2);
                var y = (Console.WindowHeight / 2) - (SizeY / 2);
                foreach (char c in Vvod)
                {
                    switch (c)
                    {
                        case ('0'):
                            {
                                var Save = x;
                                char[,] Cifra =
                                {
                            { '█', '█', '█','█', '█', '█', ' '},
                            { '█', '█', ' ',' ', '█', '█', ' '},
                            { '█', '█', ' ',' ', '█', '█', ' '},
                            { '█', '█', ' ',' ' ,'█', '█', ' '},
                            { '█', '█', ' ',' ' ,'█', '█', ' '},
                            { '█', '█', ' ', ' ','█', '█', ' '},
                            { '█', '█', '█', '█','█', '█', ' '}
                        };
                                for (var i = 0; i < Cifra.GetLength(0); i++, ++y, x = Save)
                                {
                                    for (var j = 0; j < Cifra.GetLength(1); j++, ++x)
                                    {

                                        Console.SetCursorPosition(x, y);
                                        Console.Write(Cifra[i, j]);
                                    }
                                }
                                x += 7;
                                y = (Console.WindowHeight / 2) - (SizeY / 2);
                            }
                            break;
                        case ('1'):
                            {
                                var Save = x;
                                char[,] Cifra =
                                {
                            { ' ', '█','█','█','█', ' ', ' '},
                            { ' ', ' ',' ','█','█', ' ', ' '},
                            { ' ', ' ',' ','█','█', ' ', ' '},
                            { ' ', ' ',' ','█','█', ' ', ' '},
                            { ' ', ' ',' ','█','█', ' ', ' '},
                            { ' ', ' ',' ','█','█', ' ', ' '},
                            { ' ', ' ',' ','█','█', ' ', ' '}
                        };
                                for (var i = 0; i < Cifra.GetLength(0); i++, ++y, x = Save)
                                {
                                    for (var j = 0; j < Cifra.GetLength(1); j++, ++x)
                                    {

                                        Console.SetCursorPosition(x, y);
                                        Console.Write(Cifra[i, j]);
                                    }
                                }
                                x += 7;
                                y = (Console.WindowHeight / 2) - (SizeY / 2);
                            }
                            break;

                        case ('2'):
                            {
                                var Save = x;
                                char[,] Cifra =
                            {
                            { '█', '█', '█','█', '█', '█', ' '},
                            { ' ', ' ', ' ',' ', '█', '█', ' '},
                            { ' ', ' ', ' ',' ', '█', '█', ' '},
                            { '▄', '▄', '█','█' ,'▀', '▀', ' '},
                            { '█', '█', ' ',' ' ,' ', ' ', ' '},
                            { '█', '█', ' ', ' ',' ', ' ', ' '},
                            { '█', '█', '█', '█','█', '█', ' '}
                        };
                                for (var i = 0; i < Cifra.GetLength(0); i++, ++y, x = Save)
                                {
                                    for (var j = 0; j < Cifra.GetLength(1); j++, ++x)
                                    {

                                        Console.SetCursorPosition(x, y);
                                        Console.Write(Cifra[i, j]);
                                    }
                                }
                                x += 7;
                                y = (Console.WindowHeight / 2) - (SizeY / 2);
                            }
                            break;
                        case ('3'):
                            {
                                int Save = x;
                                char[,] Cifra =
                            {
                            { '█', '█', '█','█', '█', '█', ' '},
                            { ' ', ' ', ' ',' ', '█', '█', ' '},
                            { ' ', ' ', ' ',' ', '█', '█', ' '},
                            { ' ', ' ', '█','█' ,' ', ' ', ' '},
                            { ' ', ' ', ' ',' ' ,'█', '█', ' '},
                            { ' ', ' ', ' ', ' ','█', '█', ' '},
                            { '█', '█', '█', '█','█', '█', ' '}
                        };
                                for (var i = 0; i < Cifra.GetLength(0); i++, ++y, x = Save)
                                {
                                    for (var j = 0; j < Cifra.GetLength(1); j++, ++x)
                                    {

                                        Console.SetCursorPosition(x, y);
                                        Console.Write(Cifra[i, j]);
                                    }
                                }
                                x += 7;
                                y = (Console.WindowHeight / 2) - (SizeY / 2);
                            }
                            break;

                        case ('4'):
                            {
                                var Save = x;
                                char[,] Cifra =
                                {
                            { '█', '█', ' ',' ', '█', '█', ' '},
                            { '█', '█', ' ',' ', '█', '█', ' '},
                            { '█', '█', ' ',' ', '█', '█', ' '},
                            { '█', '█', ' ',' ' ,'█', '█', ' '},
                            { '█', '█', '█','█' ,'█', '█', ' '},
                            { ' ', ' ', ' ', ' ','█', '█', ' '},
                            { ' ', ' ', ' ', ' ','█', '█', ' '}
                        };
                                for (var i = 0; i < Cifra.GetLength(0); i++, ++y, x = Save)
                                {
                                    for (var j = 0; j < Cifra.GetLength(1); j++, ++x)
                                    {

                                        Console.SetCursorPosition(x, y);
                                        Console.Write(Cifra[i, j]);
                                    }
                                }
                                x += 7;
                                y = (Console.WindowHeight / 2) - (SizeY / 2);
                            }
                            break;
                        case ('5'):
                            {
                                var Save = x;
                                char[,] Cifra =
                                {
                            { '█', '█', '█','█', '█', '█', ' '},
                            { '█', '█', ' ',' ', ' ', ' ', ' '},
                            { '█', '█', ' ',' ', ' ', ' ', ' '},
                            { '▀', '▀', '▀','▀' ,'▄', '▄', ' '},
                            { ' ', ' ', ' ',' ' ,'█', '█', ' '},
                            { ' ', ' ', ' ', ' ','█', '█', ' '},
                            { '█', '█', '█', '█','█', '█', ' '}
                        };
                                for (var i = 0; i < Cifra.GetLength(0); i++, ++y, x = Save)
                                {
                                    for (var j = 0; j < Cifra.GetLength(1); j++, ++x)
                                    {

                                        Console.SetCursorPosition(x, y);
                                        Console.Write(Cifra[i, j]);
                                    }
                                }
                                x += 7;
                                y = (Console.WindowHeight / 2) - (SizeY / 2);
                            }
                            break;
                        case ('6'):
                            {
                                var Save = x;
                                char[,] Cifra =
                                {
                            { '█', '█', '█','█', ' ', ' ', ' '},
                            { '█', '█', ' ',' ', ' ', ' ', ' '},
                            { '█', '█', ' ',' ', ' ', ' ', ' '},
                            { '█', '█', ' ',' ' ,'▄', '▄', ' '},
                            { '█', '█', ' ',' ' ,'█', '█', ' '},
                            { '█', '█', ' ', ' ','█', '█', ' '},
                            { '█', '█', '█', '█','█', '█', ' '}
                        };
                                for (var i = 0; i < Cifra.GetLength(0); i++, ++y, x = Save)
                                {
                                    for (var j = 0; j < Cifra.GetLength(1); j++, ++x)
                                    {

                                        Console.SetCursorPosition(x, y);
                                        Console.Write(Cifra[i, j]);
                                    }
                                }
                                x += 7;
                                y = (Console.WindowHeight / 2) - (SizeY / 2);
                            }
                            break;
                        case ('7'):
                            {
                                var Save = x;
                                char[,] Cifra =
                                {
                            { '█', '█', '█','█', '█', '█', ' '},
                            { ' ', ' ', ' ',' ', '█', '█', ' '},
                            { ' ', ' ', ' ',' ', '█', '█', ' '},
                            { ' ', ' ', '▄','▄' ,'▀', '▀', ' '},
                            { ' ', ' ', '█','█' ,' ', ' ', ' '},
                            { ' ', ' ', '█','█',' ', ' ', ' '},
                            { ' ', ' ', '█','█',' ', ' ', ' '}
                        };
                                for (var i = 0; i < Cifra.GetLength(0); i++, ++y, x = Save)
                                {
                                    for (var j = 0; j < Cifra.GetLength(1); j++, ++x)
                                    {

                                        Console.SetCursorPosition(x, y);
                                        Console.Write(Cifra[i, j]);
                                    }
                                }
                                x += 7;
                                y = (Console.WindowHeight / 2) - (SizeY / 2);
                            }
                            break;
                        case ('8'):
                            {
                                var Save = x;
                                char[,] Cifra =
                                {
                            { '█', '█', '█','█', '█', '█', ' '},
                            { '█', '█', ' ',' ', '█', '█', ' '},
                            { '█', '█', ' ',' ', '█', '█', ' '},
                            { '█', '█', '█','█' ,'█', '█', ' '},
                            { '█', '█', ' ',' ' ,'█', '█', ' '},
                            { '█', '█', ' ', ' ','█', '█', ' '},
                            { '█', '█', '█', '█','█', '█', ' '}
                        };
                                for (var i = 0; i < Cifra.GetLength(0); i++, ++y, x = Save)
                                {
                                    for (var j = 0; j < Cifra.GetLength(1); j++, ++x)
                                    {

                                        Console.SetCursorPosition(x, y);
                                        Console.Write(Cifra[i, j]);
                                    }
                                }
                                x += 7;
                                y = (Console.WindowHeight / 2) - (SizeY / 2);
                            }
                            break;
                        case ('9'):
                            {
                                var Save = x;
                                char[,] Cifra =
                                {
                            { '█', '█', '█','█', '█', '█', ' '},
                            { '█', '█', ' ',' ', '█', '█', ' '},
                            { '█', '█', ' ',' ', '█', '█', ' '},
                            { '▀', '▀', ' ',' ' ,'█', '█', ' '},
                            { ' ', ' ', ' ',' ' ,'█', '█', ' '},
                            { ' ', ' ', ' ', ' ','█', '█', ' '},
                            { '█', '█', '█', '█','█', '█', ' '}
                        };
                                for (var i = 0; i < Cifra.GetLength(0); i++, ++y, x = Save)
                                {
                                    for (var j = 0; j < Cifra.GetLength(1); j++, ++x)
                                    {

                                        Console.SetCursorPosition(x, y);
                                        Console.Write(Cifra[i, j]);
                                    }
                                }
                                x += 7;
                                y = (Console.WindowHeight / 2) - (SizeY / 2);
                            }
                            break;
                        case (' '):
                            {
                                var Save = x;
                                char[,] Cifra =
                                {
                            { ' ', ' ', ' ',' ', ' ', ' ', ' '},
                            { ' ', ' ', ' ',' ', ' ', ' ', ' '},
                            { ' ', ' ', ' ',' ', ' ', ' ', ' '},
                            { ' ', ' ', ' ',' ', ' ', ' ', ' '},
                            { ' ', ' ', ' ',' ', ' ', ' ', ' '},
                            { ' ', ' ', ' ',' ', ' ', ' ', ' '},
                            { ' ', ' ', ' ',' ', ' ', ' ', ' '}
                        };
                                for (var i = 0; i < Cifra.GetLength(0); i++, ++y, x = Save)
                                {
                                    for (var j = 0; j < Cifra.GetLength(1); j++, ++x)
                                    {

                                        Console.SetCursorPosition(x, y);
                                        Console.Write(Cifra[i, j]);
                                    }
                                }
                                x += 7;
                                y = (Console.WindowHeight / 2) - (SizeY / 2);
                            }
                            break;
                        case ('.'):
                            {
                                var Save = x;
                                char[,] Cifra =
                                {
                            { ' ', ' ', ' ',' ', ' ', ' ', ' '},
                            { ' ', ' ', ' ',' ', ' ', ' ', ' '},
                            { ' ', ' ', ' ',' ', ' ', ' ', ' '},
                            { ' ', ' ', ' ',' ', ' ', ' ', ' '},
                            { ' ', ' ', ' ',' ', ' ', ' ', ' '},
                            { ' ', ' ', '█','█', ' ', ' ', ' '},
                            { ' ', ' ', '█','█', ' ', ' ', ' '},

                        };
                                for (var i = 0; i < Cifra.GetLength(0); i++, ++y, x = Save)
                                {
                                    for (var j = 0; j < Cifra.GetLength(1); j++, ++x)
                                    {

                                        Console.SetCursorPosition(x, y);
                                        Console.Write(Cifra[i, j]);
                                    }
                                }
                                x += 7;
                                y = (Console.WindowHeight / 2) - (SizeY / 2);
                            }
                            break;

                        case ('\\'):
                            {
                                var Save = x;
                                char[,] Cifra =
                                {
                            { '█', ' ', ' ',' ', ' ', ' ', ' '},
                            { ' ', '█', ' ',' ', ' ', ' ', ' '},
                            { ' ', ' ', '█',' ', ' ', ' ', ' '},
                            { ' ', ' ', '▀','▄', ' ', ' ', ' '},
                            { ' ', ' ', ' ','█', ' ', ' ', ' '},
                            { ' ', ' ', ' ',' ', '█', ' ', ' '},
                            { ' ', ' ', ' ',' ', ' ', '█', ' '}
                        };
                                for (var i = 0; i < Cifra.GetLength(0); i++, ++y, x = Save)
                                {
                                    for (var j = 0; j < Cifra.GetLength(1); j++, ++x)
                                    {

                                        Console.SetCursorPosition(x, y);
                                        Console.Write(Cifra[i, j]);
                                    }
                                }
                                x += 7;
                                y = (Console.WindowHeight / 2) - (SizeY / 2);
                            }
                            break;
                    }
                }
                Console.ReadKey();
            }
            Console.WriteLine("\n\n\n\n\n\n\n\n");
        }
    }
}
