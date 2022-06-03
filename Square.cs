using System;
using System.Collections.Generic;
using System.Text;

namespace Out_My_Phrase // ░░ ▒▒ ▓▓
{
    public class Square
    {
        public static void Out_full_alphabet()
        {
            Square.Out_phrase("abcdefghi");

            Square.Out_phrase("jklmnopqr");

            Square.Out_phrase("stuvwxyz");

            Square.Out_phrase("абвгдеёжзий");

            Square.Out_phrase("клмнопрстуф");

            Square.Out_phrase("хцчшщъыьэюя");

            Square.Out_phrase("0123456789");

            Square.Out_phrase("!.,\";/\\+-*|?':=_");
        }

        public static void Out_phrase(string my_phrase)
        {
            string out_phrase = "";

            char[] phrase_chars = my_phrase.ToCharArray();

            for (int again = 0; again < 7; ++again)
            {
                for (int i = 0; i < phrase_chars.Length; ++i)
                {
                    switch (phrase_chars[i])
                    {
                        case ' ':
                            out_phrase += Space;
                            break;
                        case 'а':
                        case 'А':
                        case 'a':
                        case 'A':
                            out_phrase += A[again];
                            break;
                        case 'в':
                        case 'В':
                        case 'b':
                        case 'B':
                            out_phrase += B[again];
                            break;
                        case 'с':
                        case 'С':
                        case 'c':
                        case 'C':
                            out_phrase += C[again];
                            break;
                        case 'd':
                        case 'D':
                            out_phrase += D[again];
                            break;
                        case 'е':
                        case 'Е':
                        case 'ё':
                        case 'Ё':
                        case 'e':
                        case 'E':
                            out_phrase += E[again];
                            break;
                        case 'f':
                        case 'F':
                            out_phrase += F[again];
                            break;
                        case 'g':
                        case 'G':
                            out_phrase += G[again];
                            break;
                        case 'н':
                        case 'Н':
                        case 'h':
                        case 'H':
                            out_phrase += H[again];
                            break;
                        case 'i':
                        case 'I':
                            out_phrase += I[again];
                            break;
                        case 'j':
                        case 'J':
                            out_phrase += J[again];
                            break;
                        case 'к':
                        case 'К':
                        case 'k':
                        case 'K':
                            out_phrase += K[again];
                            break;
                        case 'l':
                        case 'L':
                            out_phrase += L[again];
                            break;
                        case 'м':
                        case 'М':
                        case 'm':
                        case 'M':
                            out_phrase += M[again];
                            break;
                        case 'n':
                        case 'N':
                            out_phrase += N[again];
                            break;
                        case 'о':
                        case 'О':
                        case 'o':
                        case 'O':
                            out_phrase += O[again];
                            break;
                        case 'р':
                        case 'Р':
                        case 'p':
                        case 'P':
                            out_phrase += P[again];
                            break;
                        case 'q':
                        case 'Q':
                            out_phrase += Q[again];
                            break;
                        case 'r':
                        case 'R':
                            out_phrase += R[again];
                            break;
                        case 's':
                        case 'S':
                            out_phrase += S[again];
                            break;
                        case 'т':
                        case 'Т':
                        case 't':
                        case 'T':
                            out_phrase += T[again];
                            break;
                        case 'u':
                        case 'U':
                            out_phrase += U[again];
                            break;
                        case 'v':
                        case 'V':
                            out_phrase += V[again];
                            break;
                        case 'w':
                        case 'W':
                            out_phrase += W[again];
                            break;
                        case 'х':
                        case 'Х':
                        case 'x':
                        case 'X':
                            out_phrase += X[again];
                            break;
                        case 'у':
                        case 'У':
                        case 'y':
                        case 'Y':
                            out_phrase += Y[again];
                            break;
                        case 'z':
                        case 'Z':
                            out_phrase += Z[again];
                            break;
                        case '6':
                        case 'б':
                        case 'Б':
                            out_phrase += Rus_b[again];
                            break;
                        case 'г':
                        case 'Г':
                            out_phrase += Rus_g[again];
                            break;
                        case 'д':
                        case 'Д':
                            out_phrase += Rus_d[again];
                            break;
                        case 'ж':
                        case 'Ж':
                            out_phrase += Rus_j[again];
                            break;
                        case 'з':
                        case 'З':
                            out_phrase += Rus_z[again];
                            break;
                        case 'и':
                        case 'И':
                            out_phrase += Rus_i[again];
                            break;
                        case 'й':
                        case 'Й':
                            out_phrase += Rus_I[again];
                            break;
                        case 'л':
                        case 'Л':
                            out_phrase += Rus_l[again];
                            break;
                        case 'п':
                        case 'П':
                            out_phrase += Rus_p[again];
                            break;
                        case 'ф':
                        case 'Ф':
                            out_phrase += Rus_f[again];
                            break;
                        case 'ц':
                        case 'Ц':
                            out_phrase += Rus_c[again];
                            break;
                        case 'ч':
                        case 'Ч':
                            out_phrase += Rus_ch[again];
                            break;
                        case 'ш':
                        case 'Ш':
                            out_phrase += Rus_sh[again];
                            break;
                        case 'щ':
                        case 'Щ':
                            out_phrase += Rus_sha[again];
                            break;
                        case 'ъ':
                        case 'Ъ':
                            out_phrase += Rus_tz[again];
                            break;
                        case 'ы':
                        case 'Ы':
                            out_phrase += Rus_ii[again];
                            break;
                        case 'ь':
                        case 'Ь':
                            out_phrase += Rus_mz[again];
                            break;
                        case 'э':
                        case 'Э':
                            out_phrase += Rus_e[again];
                            break;
                        case 'ю':
                        case 'Ю':
                            out_phrase += Rus_u[again];
                            break;
                        case 'я':
                        case 'Я':
                            out_phrase += Rus_ya[again];
                            break;
                        case '1':
                            out_phrase += one[again];
                            break;
                        case '2':
                            out_phrase += two[again];
                            break;
                        case '3':
                            out_phrase += three[again];
                            break;
                        case '4':
                            out_phrase += four[again];
                            break;
                        case '5':
                            out_phrase += five[again];
                            break;
                        case '7':
                            out_phrase += seven[again];
                            break;
                        case '8':
                            out_phrase += eight[again];
                            break;
                        case '9':
                            out_phrase += nine[again];
                            break;
                        case '0':
                            out_phrase += zero[again];
                            break;
                        case '!':
                            out_phrase += ex_point[again];
                            break;
                        case '.':
                            out_phrase += dot[again];
                            break;
                        case ',':
                            out_phrase += comma[again];
                            break;
                        case ';':
                            out_phrase += semicolon[again];
                            break;
                        case '/':
                            out_phrase += slash[again];
                            break;
                        case '\\':
                            out_phrase += reslash[again];
                            break;
                        case '+':
                            out_phrase += plus[again];
                            break;
                        case '-':
                            out_phrase += minus[again];
                            break;
                        case '*':
                            out_phrase += star[again];
                            break;
                        case '|':
                            out_phrase += vertical_bar[again];
                            break;
                        case '?':
                            out_phrase += question[again];
                            break;
                        case '"':
                            out_phrase += quotes[again];
                            break;
                        case '\'':
                            out_phrase += one_quotes[again];
                            break;
                        case ':':
                            out_phrase += double_dot[again];
                            break;
                        case '=':
                            out_phrase += equals[again];
                            break;
                        case '_':
                            out_phrase += underscore[again];
                            break;
                    } 
                }

                out_phrase += End;

                Console.WriteLine(out_phrase);

                out_phrase = "";
            }
        }
        
        // Английские буквы

        private readonly static string[] A = {"░░░░░░░░░░░░",
                                    "░░▓▓▓▓▓▓▓▓▓▓",
                                    "░░▓▓░░░░░░▓▓",
                                    "░░▓▓▓▓▓▓▓▓▓▓",
                                    "░░▓▓░░░░░░▓▓",
                                    "░░▓▓░░░░░░▓▓",
                                    "░░░░░░░░░░░░"
                                    };
        private readonly static string[] B = {"░░░░░░░░░░░░",
                                    "░░▓▓▓▓▓▓▓▓▓▓",
                                    "░░▓▓░░░░░░▓▓",
                                    "░░▓▓▓▓▓▓▓▓░░",
                                    "░░▓▓░░░░░░▓▓",
                                    "░░▓▓▓▓▓▓▓▓▓▓",
                                    "░░░░░░░░░░░░"
                                    };
        private readonly static string[] C = {"░░░░░░░░░░░░",
                                    "░░▓▓▓▓▓▓▓▓▓▓",
                                    "░░▓▓░░░░░░░░",
                                    "░░▓▓░░░░░░░░",
                                    "░░▓▓░░░░░░░░",
                                    "░░▓▓▓▓▓▓▓▓▓▓",
                                    "░░░░░░░░░░░░"
                                    };
        private readonly static string[] D = {"░░░░░░░░░░░░",
                                    "░░▓▓▓▓▓▓▓▓░░",
                                    "░░▓▓░░░░░░▓▓",
                                    "░░▓▓░░░░░░▓▓",
                                    "░░▓▓░░░░░░▓▓",
                                    "░░▓▓▓▓▓▓▓▓░░",
                                    "░░░░░░░░░░░░"
                                    };
        private readonly static string[] E = {"░░░░░░░░░░░░",
                                    "░░▓▓▓▓▓▓▓▓▓▓",
                                    "░░▓▓░░░░░░░░",
                                    "░░▓▓▓▓▓▓▓▓▓▓",
                                    "░░▓▓░░░░░░░░",
                                    "░░▓▓▓▓▓▓▓▓▓▓",
                                    "░░░░░░░░░░░░"
                                    };
        private readonly static string[] F = {"░░░░░░░░░░░░",
                                    "░░▓▓▓▓▓▓▓▓▓▓",
                                    "░░▓▓░░░░░░░░",
                                    "░░▓▓▓▓▓▓░░░░",
                                    "░░▓▓░░░░░░░░",
                                    "░░▓▓░░░░░░░░",
                                    "░░░░░░░░░░░░"
                                    };
        private readonly static string[] G = {"░░░░░░░░░░░░",
                                    "░░▓▓▓▓▓▓▓▓▓▓",
                                    "░░▓▓░░░░░░░░",
                                    "░░▓▓░░▓▓▓▓▓▓",
                                    "░░▓▓░░░░░░▓▓",
                                    "░░▓▓▓▓▓▓▓▓▓▓",
                                    "░░░░░░░░░░░░"
                                    };
        private readonly static string[] H = {"░░░░░░░░░░░░",
                                    "░░▓▓░░░░░░▓▓",
                                    "░░▓▓░░░░░░▓▓",
                                    "░░▓▓▓▓▓▓▓▓▓▓",
                                    "░░▓▓░░░░░░▓▓",
                                    "░░▓▓░░░░░░▓▓",
                                    "░░░░░░░░░░░░"
                                    };
        private readonly static string[] I = {"░░░░░░░░░░░░",
                                    "░░▓▓▓▓▓▓▓▓▓▓",
                                    "░░░░░░▓▓░░░░",
                                    "░░░░░░▓▓░░░░",
                                    "░░░░░░▓▓░░░░",
                                    "░░▓▓▓▓▓▓▓▓▓▓",
                                    "░░░░░░░░░░░░"
                                    };
        private readonly static string[] J = {"░░░░░░░░░░░░",
                                    "░░▓▓▓▓▓▓▓▓▓▓",
                                    "░░░░░░▓▓░░░░",
                                    "░░░░░░▓▓░░░░",
                                    "░░▓▓░░▓▓░░░░",
                                    "░░▓▓▓▓▓▓░░░░",
                                    "░░░░░░░░░░░░"
                                    };
        private readonly static string[] K = {"░░░░░░░░░░░░",
                                    "░░▓▓░░░░░░▓▓",
                                    "░░▓▓░░░░░░▓▓",
                                    "░░▓▓▓▓▓▓▓▓░░",
                                    "░░▓▓░░░░░░▓▓",
                                    "░░▓▓░░░░░░▓▓",
                                    "░░░░░░░░░░░░"
                                    };
        private readonly static string[] L = {"░░░░░░░░░░░░",
                                    "░░▓▓░░░░░░░░",
                                    "░░▓▓░░░░░░░░",
                                    "░░▓▓░░░░░░░░",
                                    "░░▓▓░░░░░░▓▓",
                                    "░░▓▓▓▓▓▓▓▓▓▓",
                                    "░░░░░░░░░░░░"
                                    };
        private readonly static string[] M = {"░░░░░░░░░░░░",
                                    "░░▓▓░░░░░░▓▓",
                                    "░░▓▓▓▓░░▓▓▓▓",
                                    "░░▓▓░░▓▓░░▓▓",
                                    "░░▓▓░░░░░░▓▓",
                                    "░░▓▓░░░░░░▓▓",
                                    "░░░░░░░░░░░░"
                                    };
        private readonly static string[] N = {"░░░░░░░░░░░░",
                                    "░░▓▓░░░░░░▓▓",
                                    "░░▓▓▓▓░░░░▓▓",
                                    "░░▓▓░░▓▓░░▓▓",
                                    "░░▓▓░░░░▓▓▓▓",
                                    "░░▓▓░░░░░░▓▓",
                                    "░░░░░░░░░░░░"
                                    };
        private readonly static string[] O = {"░░░░░░░░░░░░",
                                    "░░▓▓▓▓▓▓▓▓▓▓",
                                    "░░▓▓░░░░░░▓▓",
                                    "░░▓▓░░░░░░▓▓",
                                    "░░▓▓░░░░░░▓▓",
                                    "░░▓▓▓▓▓▓▓▓▓▓",
                                    "░░░░░░░░░░░░"
                                    };
        private readonly static string[] P = {"░░░░░░░░░░░░",
                                    "░░▓▓▓▓▓▓▓▓▓▓",
                                    "░░▓▓░░░░░░▓▓",
                                    "░░▓▓▓▓▓▓▓▓▓▓",
                                    "░░▓▓░░░░░░░░",
                                    "░░▓▓░░░░░░░░",
                                    "░░░░░░░░░░░░"
                                    };
        private readonly static string[] Q = {"░░░░░░░░░░░░",
                                    "░░▓▓▓▓▓▓▓▓▓▓",
                                    "░░▓▓░░░░░░▓▓",
                                    "░░▓▓░░░░░░▓▓",
                                    "░░▓▓░░░░░░▓▓",
                                    "░░▓▓▓▓▓▓▓▓▓▓",
                                    "░░░░░░░░░░▓▓"
                                    };
        private readonly static string[] R = {"░░░░░░░░░░░░",
                                    "░░▓▓▓▓▓▓▓▓▓▓",
                                    "░░▓▓░░░░░░▓▓",
                                    "░░▓▓▓▓▓▓▓▓▓▓",
                                    "░░▓▓░░░░▓▓░░",
                                    "░░▓▓░░░░░░▓▓",
                                    "░░░░░░░░░░░░"
                                    };
        private readonly static string[] S = {"░░░░░░░░░░░░",
                                    "░░░░▓▓▓▓▓▓▓▓",
                                    "░░▓▓░░░░░░░░",
                                    "░░▓▓▓▓▓▓▓▓▓▓",
                                    "░░░░░░░░░░▓▓",
                                    "░░▓▓▓▓▓▓▓▓░░",
                                    "░░░░░░░░░░░░"
                                    };
        private readonly static string[] T = {"░░░░░░░░░░░░",
                                    "░░▓▓▓▓▓▓▓▓▓▓",
                                    "░░░░░░▓▓░░░░",
                                    "░░░░░░▓▓░░░░",
                                    "░░░░░░▓▓░░░░",
                                    "░░░░░░▓▓░░░░",
                                    "░░░░░░░░░░░░"
                                    };
        private readonly static string[] U = {"░░░░░░░░░░░░",
                                    "░░▓▓░░░░░░▓▓",
                                    "░░▓▓░░░░░░▓▓",
                                    "░░▓▓░░░░░░▓▓",
                                    "░░▓▓░░░░░░▓▓",
                                    "░░░░▓▓▓▓▓▓▓▓",
                                    "░░░░░░░░░░░░"
                                    };
        private readonly static string[] V = {"░░░░░░░░░░░░",
                                    "░░▓▓░░░░░░▓▓",
                                    "░░▓▓░░░░░░▓▓",
                                    "░░▓▓░░░░░░▓▓",
                                    "░░▓▓░░░░░░▓▓",
                                    "░░░░▓▓▓▓▓▓░░",
                                    "░░░░░░░░░░░░"
                                    };
        private readonly static string[] W = {"░░░░░░░░░░░░",
                                    "░░▓▓░░░░░░▓▓",
                                    "░░▓▓░░░░░░▓▓",
                                    "░░▓▓░░░░░░▓▓",
                                    "░░▓▓░░▓▓░░▓▓",
                                    "░░░░▓▓▓▓▓▓░░",
                                    "░░░░░░░░░░░░"
                                    };
        private readonly static string[] X = {"░░░░░░░░░░░░",
                                    "░░▓▓░░░░░░▓▓",
                                    "░░▓▓░░░░░░▓▓",
                                    "░░░░▓▓▓▓▓▓░░",
                                    "░░▓▓░░░░░░▓▓",
                                    "░░▓▓░░░░░░▓▓",
                                    "░░░░░░░░░░░░"
                                    };
        private readonly static string[] Y = {"░░░░░░░░░░░░",
                                    "░░▓▓░░░░░░▓▓",
                                    "░░▓▓░░░░░░▓▓",
                                    "░░▓▓▓▓▓▓▓▓▓▓",
                                    "░░░░░░░░░░▓▓",
                                    "░░▓▓▓▓▓▓▓▓▓▓",
                                    "░░░░░░░░░░░░"
                                    };
        private readonly static string[] Z = {"░░░░░░░░░░░░",
                                    "░░▓▓▓▓▓▓▓▓▓▓",
                                    "░░░░░░░░░░▓▓",
                                    "░░░░▓▓▓▓▓▓░░",
                                    "░░▓▓░░░░░░░░",
                                    "░░▓▓▓▓▓▓▓▓▓▓",
                                    "░░░░░░░░░░░░"
                                    };

        // Русские буквы

        private readonly static string[] Rus_b = {"░░░░░░░░░░░░",
                                    "░░▓▓▓▓▓▓▓▓▓▓",
                                    "░░▓▓░░░░░░░░",
                                    "░░▓▓▓▓▓▓▓▓▓▓",
                                    "░░▓▓░░░░░░▓▓",
                                    "░░▓▓▓▓▓▓▓▓▓▓",
                                    "░░░░░░░░░░░░"
                                    };
        private readonly static string[] Rus_g = {"░░░░░░░░░░░░",
                                    "░░▓▓▓▓▓▓▓▓▓▓",
                                    "░░▓▓░░░░░░▓▓",
                                    "░░▓▓░░░░░░░░",
                                    "░░▓▓░░░░░░░░",
                                    "░░▓▓░░░░░░░░",
                                    "░░░░░░░░░░░░"
                                    };
        private readonly static string[] Rus_d = {"░░░░░░░░░░░░",
                                    "░░░░▓▓▓▓▓▓░░",
                                    "░░░░▓▓░░▓▓░░",
                                    "░░░░▓▓░░▓▓░░",
                                    "░░▓▓▓▓▓▓▓▓▓▓",
                                    "░░▓▓░░░░░░▓▓",
                                    "░░░░░░░░░░░░"
                                    };
        private readonly static string[] Rus_j = {"░░░░░░░░░░░░",
                                    "░░▓▓░░▓▓░░▓▓",
                                    "░░▓▓░░▓▓░░▓▓",
                                    "░░░░▓▓▓▓▓▓░░",
                                    "░░▓▓░░▓▓░░▓▓",
                                    "░░▓▓░░▓▓░░▓▓",
                                    "░░░░░░░░░░░░"
                                    };
        private readonly static string[] Rus_z = {"░░░░░░░░░░░░",
                                    "░░▓▓▓▓▓▓▓▓▓▓",
                                    "░░░░░░░░░░▓▓",
                                    "░░▓▓▓▓▓▓▓▓░░",
                                    "░░░░░░░░░░▓▓",
                                    "░░▓▓▓▓▓▓▓▓▓▓",
                                    "░░░░░░░░░░░░"
                                    };
        private readonly static string[] Rus_i = {"░░░░░░░░░░░░",
                                    "░░▓▓░░░░░░▓▓",
                                    "░░▓▓░░░░▓▓▓▓",
                                    "░░▓▓░░▓▓░░▓▓",
                                    "░░▓▓▓▓░░░░▓▓",
                                    "░░▓▓░░░░░░▓▓",
                                    "░░░░░░░░░░░░"
                                    };
        private readonly static string[] Rus_I = {"░░░░░▓▓▓▓░░░",
                                     "░░▓▓░░░░░░▓▓",
                                     "░░▓▓░░░░▓▓▓▓",
                                     "░░▓▓░░▓▓░░▓▓",
                                     "░░▓▓▓▓░░░░▓▓",
                                     "░░▓▓░░░░░░▓▓",
                                     "░░░░░░░░░░░░"
                                    };
        private readonly static string[] Rus_l = {"░░░░░░░░░░░░",
                                     "░░░░░░▓▓▓▓▓▓",
                                     "░░░░▓▓░░░░▓▓",
                                     "░░░░▓▓░░░░▓▓",
                                     "░░░░▓▓░░░░▓▓",
                                     "░░▓▓░░░░░░▓▓",
                                     "░░░░░░░░░░░░"
                                    };
        private readonly static string[] Rus_p = {"░░░░░░░░░░░░",
                                     "░░▓▓▓▓▓▓▓▓▓▓",
                                     "░░▓▓░░░░░░▓▓",
                                     "░░▓▓░░░░░░▓▓",
                                     "░░▓▓░░░░░░▓▓",
                                     "░░▓▓░░░░░░▓▓",
                                     "░░░░░░░░░░░░"
                                    };
        private readonly static string[] Rus_f = {"░░░░░░░░░░░░",
                                     "░░░░░░▓▓░░░░",
                                     "░░▓▓▓▓▓▓▓▓▓▓",
                                     "░░▓▓░░▓▓░░▓▓",
                                     "░░▓▓▓▓▓▓▓▓▓▓",
                                     "░░░░░░▓▓░░░░",
                                     "░░░░░░░░░░░░"
                                    };
        private readonly static string[] Rus_c = {"░░░░░░░░░░░░",
                                    "░░▓▓░░░░░░▓▓",
                                    "░░▓▓░░░░░░▓▓",
                                    "░░▓▓░░░░░░▓▓",
                                    "░░▓▓░░░░░░▓▓",
                                    "░░▓▓▓▓▓▓▓▓▓▓",
                                    "░░░░░░░░░░▓▓"
                                    };
        private readonly static string[] Rus_ch = {"░░░░░░░░░░░░",
                                    "░░▓▓░░░░░░▓▓",
                                    "░░▓▓░░░░░░▓▓",
                                    "░░▓▓░░░░░░▓▓",
                                    "░░▓▓▓▓▓▓▓▓▓▓",
                                    "░░░░░░░░░░▓▓",
                                    "░░░░░░░░░░░░"
                                    };
        private readonly static string[] Rus_sh = {"░░░░░░░░░░░░",
                                    "░░▓▓░░▓▓░░▓▓",
                                    "░░▓▓░░▓▓░░▓▓",
                                    "░░▓▓░░▓▓░░▓▓",
                                    "░░▓▓░░▓▓░░▓▓",
                                    "░░▓▓▓▓▓▓▓▓▓▓",
                                    "░░░░░░░░░░░░"
                                    };
        private readonly static string[] Rus_sha = {"░░░░░░░░░░░░",
                                    "░░▓▓░░▓▓░░▓▓",
                                    "░░▓▓░░▓▓░░▓▓",
                                    "░░▓▓░░▓▓░░▓▓",
                                    "░░▓▓░░▓▓░░▓▓",
                                    "░░▓▓▓▓▓▓▓▓▓▓",
                                    "░░░░░░░░░░▓▓"
                                    };
        private readonly static string[] Rus_tz = {"░░░░░░░░░░░░",
                                    "░░▓▓▓▓░░░░░░",
                                    "░░░░▓▓░░░░░░",
                                    "░░░░▓▓▓▓▓▓▓▓",
                                    "░░░░▓▓░░░░▓▓",
                                    "░░░░▓▓▓▓▓▓▓▓",
                                    "░░░░░░░░░░░░"
                                    };
        private readonly static string[] Rus_ii = {"░░░░░░░░░░░░",
                                     "░░▓▓░░░░░░▓▓",
                                     "░░▓▓░░░░░░▓▓",
                                     "░░▓▓▓▓▓▓░░▓▓",
                                     "░░▓▓░░▓▓░░▓▓",
                                     "░░▓▓▓▓▓▓░░▓▓",
                                     "░░░░░░░░░░░░"
                                    };
        private readonly static string[] Rus_mz = {"░░░░░░░░░░░░",
                                     "░░▓▓░░░░░░░░",
                                     "░░▓▓░░░░░░░░",
                                     "░░▓▓▓▓▓▓▓▓▓▓",
                                     "░░▓▓░░░░░░▓▓",
                                     "░░▓▓▓▓▓▓▓▓▓▓",
                                     "░░░░░░░░░░░░"
                                    };
        private readonly static string[] Rus_e = {"░░░░░░░░░░░░",
                                    "░░▓▓▓▓▓▓▓▓░░",
                                    "░░░░░░░░░░▓▓",
                                    "░░▓▓▓▓▓▓▓▓▓▓",
                                    "░░░░░░░░░░▓▓",
                                    "░░▓▓▓▓▓▓▓▓░░",
                                    "░░░░░░░░░░░░"
                                    };
        private readonly static string[] Rus_u = {"░░░░░░░░░░░░",
                                     "░░▓▓░░▓▓▓▓▓▓",
                                     "░░▓▓░░▓▓░░▓▓",
                                     "░░▓▓▓▓▓▓░░▓▓",
                                     "░░▓▓░░▓▓░░▓▓",
                                     "░░▓▓░░▓▓▓▓▓▓",
                                     "░░░░░░░░░░░░"
                                    };
        private readonly static string[] Rus_ya = {"░░░░░░░░░░░░",
                                     "░░▓▓▓▓▓▓▓▓▓▓",
                                     "░░▓▓░░░░░░▓▓",
                                     "░░▓▓▓▓▓▓▓▓▓▓",
                                     "░░░░▓▓░░░░▓▓",
                                     "░░▓▓░░░░░░▓▓",
                                     "░░░░░░░░░░░░"
                                    };

        // Цифры

        private readonly static string[] one = {"░░░░░░░░░░░░",
                                       "░░░░░░▓▓░░░░",
                                       "░░░░▓▓▓▓░░░░",
                                       "░░░░░░▓▓░░░░",
                                       "░░░░░░▓▓░░░░",
                                       "░░▓▓▓▓▓▓▓▓▓▓",
                                       "░░░░░░░░░░░░"
                                    };
        private readonly static string[] two = {"░░░░░░░░░░░░",
                                       "░░▓▓▓▓▓▓▓▓▓▓",
                                       "░░░░░░░░░░▓▓",
                                       "░░▓▓▓▓▓▓▓▓▓▓",
                                       "░░▓▓░░░░░░░░",
                                       "░░▓▓▓▓▓▓▓▓▓▓",
                                       "░░░░░░░░░░░░"
                                    };
        private readonly static string[] three = {"░░░░░░░░░░░░",
                                       "░░▓▓▓▓▓▓▓▓▓▓",
                                       "░░░░░░░░░░▓▓",
                                       "░░▓▓▓▓▓▓▓▓▓▓",
                                       "░░░░░░░░░░▓▓",
                                       "░░▓▓▓▓▓▓▓▓▓▓",
                                       "░░░░░░░░░░░░"
                                    };
        private readonly static string[] four = {"░░░░░░░░░░░░",
                                       "░░▓▓░░░░░░▓▓",
                                       "░░▓▓░░░░░░▓▓",
                                       "░░▓▓▓▓▓▓▓▓▓▓",
                                       "░░░░░░░░░░▓▓",
                                       "░░░░░░░░░░▓▓",
                                       "░░░░░░░░░░░░"
                                    };
        private readonly static string[] five = {"░░░░░░░░░░░░",
                                       "░░▓▓▓▓▓▓▓▓▓▓",
                                       "░░▓▓░░░░░░░░",
                                       "░░▓▓▓▓▓▓▓▓▓▓",
                                       "░░░░░░░░░░▓▓",
                                       "░░▓▓▓▓▓▓▓▓▓▓",
                                       "░░░░░░░░░░░░"
                                    };
        private readonly static string[] seven = {"░░░░░░░░░░░░",
                                       "░░▓▓▓▓▓▓▓▓▓▓",
                                       "░░░░░░░░░░▓▓",
                                       "░░░░░░░░▓▓░░",
                                       "░░░░░░▓▓░░░░",
                                       "░░░░░░▓▓░░░░",
                                       "░░░░░░░░░░░░"
                                    };
        private readonly static string[] eight = {"░░░░░░░░░░░░",
                                       "░░▓▓▓▓▓▓▓▓▓▓",
                                       "░░▓▓░░░░░░▓▓",
                                       "░░░░▓▓▓▓▓▓░░",
                                       "░░▓▓░░░░░░▓▓",
                                       "░░▓▓▓▓▓▓▓▓▓▓",
                                       "░░░░░░░░░░░░"
                                    };
        private readonly static string[] nine = {"░░░░░░░░░░░░",
                                       "░░▓▓▓▓▓▓▓▓▓▓",
                                       "░░▓▓░░░░░░▓▓",
                                       "░░▓▓▓▓▓▓▓▓▓▓",
                                       "░░░░░░░░░░▓▓",
                                       "░░▓▓▓▓▓▓▓▓▓▓",
                                       "░░░░░░░░░░░░"
                                    };
        private readonly static string[] zero = {"░░░░░░░░░░░░",
                                       "░░▓▓▓▓▓▓▓▓▓▓",
                                       "░░▓▓░░░░░░▓▓",
                                       "░░▓▓▓▓▓▓▓▓▓▓",
                                       "░░▓▓░░░░░░▓▓",
                                       "░░▓▓▓▓▓▓▓▓▓▓",
                                       "░░░░░░░░░░░░"
                                    };

        // Знаки

        private readonly static string[] ex_point = {"░░▓▓",
                                            "░░▓▓",
                                            "░░▓▓",
                                            "░░▓▓",
                                            "░░░░",
                                            "░░▓▓",
                                            "░░░░"
                                            };
        private readonly static string[] dot = {"░░░░",
                                       "░░░░",
                                       "░░░░",
                                       "░░░░",
                                       "░░░░",
                                       "░░▓▓",
                                       "░░░░"
                                            };
        private readonly static string[] comma = {"░░░░",
                                         "░░░░",
                                         "░░░░",
                                         "░░░░",
                                         "░░░░",
                                         "░░▓▓",
                                         "░░▓▓"
                                            };
        private readonly static string[] semicolon = {"░░░░",
                                             "░░░░",
                                             "░░▓▓",
                                             "░░░░",
                                             "░░░░",
                                             "░░▓▓",
                                             "░░▓▓"
                                            };
        private readonly static string[] slash = {    "░░░░░░▓▓",
                                             "░░░░░░▓▓",
                                             "░░░░▓▓░░",
                                             "░░░░▓▓░░",
                                             "░░▓▓░░░░",
                                             "░░▓▓░░░░",
                                             "░░░░░░░░"
                                            };
        private readonly static string[] reslash = {  "░░▓▓░░░░",
                                             "░░▓▓░░░░",
                                             "░░░░▓▓░░",
                                             "░░░░▓▓░░",
                                             "░░░░░░▓▓",
                                             "░░░░░░▓▓",
                                             "░░░░░░░░"
                                            };
        private readonly static string[] plus = {"░░░░░░░░",
                                        "░░░░░░░░",
                                        "░░░░▓▓░░",
                                        "░░▓▓▓▓▓▓",
                                        "░░░░▓▓░░",
                                        "░░░░░░░░",
                                        "░░░░░░░░"
                                            };
        private readonly static string[] minus = {"░░░░░░░░",
                                         "░░░░░░░░",
                                         "░░░░░░░░",
                                         "░░▓▓▓▓▓▓",
                                         "░░░░░░░░",
                                         "░░░░░░░░",
                                         "░░░░░░░░"
                                            };
        private readonly static string[] star = {"░░░░░░░",
                                        "░░░░░░░",
                                        "░░▓░▓░▓",
                                        "░░░▓▓▓░",
                                        "░░▓░▓░▓",
                                        "░░░░░░░",
                                        "░░░░░░░"
                                            };
        private readonly static string[] vertical_bar = {"░░░░▓▓",
                                                "░░░░▓▓",
                                                "░░░░▓▓",
                                                "░░░░▓▓",
                                                "░░░░▓▓",
                                                "░░░░▓▓",
                                                "░░░░░░"
                                            };
        private readonly static string[] question = {"░░░░▓▓▓▓▓▓░░",
                                            "░░▓▓░░░░░░▓▓",
                                            "░░░░░░░░░░▓▓",
                                            "░░░░░░▓▓▓▓░░",
                                            "░░░░░░░░░░░░",
                                            "░░░░░░▓▓░░░░",
                                            "░░░░░░░░░░░░"
                                            };
        private readonly static string[] quotes = {"░░▓▓░░▓▓",
                                          "░░▓▓░░▓▓",
                                          "░░░░░░░░",
                                          "░░░░░░░░",
                                          "░░░░░░░░",
                                          "░░░░░░░░",
                                          "░░░░░░░░"
                                            };
        private readonly static string[] one_quotes = {"░░▓▓",
                                              "░░▓▓",
                                              "░░░░",
                                              "░░░░",
                                              "░░░░",
                                              "░░░░",
                                              "░░░░"
                                            };
        private readonly static string[] double_dot = {"░░░░",
                                              "░░░░",
                                              "░░▓▓",
                                              "░░░░",
                                              "░░░░",
                                              "░░▓▓",
                                              "░░░░"
                                            };
        private readonly static string[] equals = {    "░░░░░░░░",
                                              "░░░░░░░░",
                                              "░░▓▓▓▓▓▓",
                                              "░░░░░░░░",
                                              "░░▓▓▓▓▓▓",
                                              "░░░░░░░░",
                                              "░░░░░░░░"
                                            };
        private readonly static string[] underscore = {"░░░░░░░░",
                                              "░░░░░░░░",
                                              "░░░░░░░░",
                                              "░░░░░░░░",
                                              "░░░░░░░░",
                                              "░░▓▓▓▓▓▓",
                                              "░░░░░░░░"
                                            };

        // Пробел и окончание

        private readonly static string Space = "░░░░";
        private readonly static string End = "░░";
    }
}
