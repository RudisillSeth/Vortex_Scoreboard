using System;
using System.Configuration;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Input;

namespace ScoreBoard2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            string title;
            string nameScoreTitan;
            string nameScoreLegend;
            string nameScoreChamp;
            string rank;
            string input;
            int inNum;

            string sAttr;
            string sAttr2;
            string sAttr3;
            string sAttr4;

            sAttr = ConfigurationManager.AppSettings.Get("Key0");
            List<string> titles = sAttr.Split(',').ToList();

            sAttr2 = ConfigurationManager.AppSettings.Get("Key1");
            List<string> titanS = sAttr2.Split(',').ToList();

            sAttr3 = ConfigurationManager.AppSettings.Get("Key2");
            List<string> legendS = sAttr3.Split(',').ToList();

            sAttr4 = ConfigurationManager.AppSettings.Get("Key3");
            List<string> champS = sAttr4.Split(',').ToList();

            //converts titles into console art titles
            string[] a = new string[8] { "     ______  ", "    /      | ", "   /  /|   | ", "  /  /_|   | ", " /   __    | ", "/   /  |   | ", "|   |  |   | ", "|___|  |___| " };
            string[] b = new string[8] { "  ___________  ", " /  ______   | ", "/  /      |  | ", "|  |______/  / ", "|   ______  /  ", "|  /      |  | ", "|  |______/  / ", "|___________/  " };
            string[] c = new string[8] { "  ___________  ", " /   ____    | ", "/   /    |   | ", "|   |    |___| ", "|   |     ___  ", "|   |    |   | ", "|   |____/   / ", "|___________/  " };
            string[] d = new string[8] { " ________   ", @"|   ___  \  ", @"|  |   \  \ ", "|  |   |  | ", "|  |   |  | ", "|  |   |  | ", "|  |___/  / ", "|________/  " };
            string[] e = new string[8] { "  __________  ", " /          | ", "/    _______/ ", "|   |_____    ", "|    _____|   ", "|   |_______  ", "|           | ", "|___________/ " };
            string[] f = new string[8] { "  __________  ", " /          | ", "/    _______/ ", "|   |_____    ", "|    _____|   ", "|   |         ", "|   |         ", "|___|         " };
            string[] g = new string[8] { "  __________  ", " /          | ", "/     ______| ", "|   |  _____  ", "|   | |_    | ", "|   |___|   | ", "|           / ", "|__________/  " };
            string[] h = new string[8] { "  __     ___  ", " /  |   |   | ", "/   |___|   | ", "|    ___    | ", "|   |   |   | ", "|   |   |   | ", "|   |   |   / ", "|___|   |__/  " };
            string[] i = new string[8] { " ____________  ", "/            | ", "|____    ____/ ", "     |  |      ", "     |  |      ", " ____|  |____  ", "/            | ", "|____________| " };
            string[] j = new string[8] { "  ___________", "/            |", "|________    |", "         |   |", " ___     |   |", "/   |    |   |", "|   |____/   /", "|___________/" };
            string[] k = new string[8] { "  ___    ___  ", " /   |  /   | ", "/    | /    / ", "|    |/    /  ", "|         |   ", @"|    |\    \  ", @"|    | \    \ ", @"|____|  \___| " };
            string[] l = new string[8] { " ___        ", "|   |       ", "|   |       ", "|   |       ", "|   |       ", "|   |_____  ", "|         | ", "|_________| ", };
            string[] m = new string[8] { " ____    ____  ", "/    |__/    | ", "|            | ", "|   /|__/|   | ", "|   |    |   | ", "|   |    |   | ", "|   |    |   | ", "|___/    |___/ " };
            string[] n = new string[8] { " ___    ___  ", "/   |  /   | ", "|   | /    | ", "|   |/     | ", "|          | ", "|     /|   | ", "|    / |   | ", "|___/  |___| " };
            string[] o = new string[8] { "  ________  ", " /  ___   | ", "/  /   |  | ", "|  |   |  | ", "|  |   |  | ", "|  |   |  | ", "|  |___/  / ", "|________/  " };
            string[] p = new string[8] { "  __________  ", " /  _____   | ", "/  /     |  | ", "|  |_____/  / ", "|   _______/  ", "|  |          ", "|  |          ", "|__/          " };
            string[] q = new string[8] { "  ________    ", " /  ___   |   ", "/  /   |  |   ", "|  |  _|__|_  ", "|  | /______/ ", "|  |   |  |   ", "|  |___/  /   ", "|________/    " };
            string[] r = new string[8] { "  ________  ", " /  ___   | ", "/  /   |  | ", "|  |___/  / ", "|        /  ", @"|        \  ", @"|   |\    \ ", @"|___| \___| " };
            string[] s = new string[8] { "  __________  ", " /          | ", "/    _______/ ", "|   |_______  ", @"|_______    \ ", "  ______|   | ", "/           / ", "|__________/  " };
            string[] t = new string[8] { " ____________  ", "/            | ", "|___     ____/ ", "    |   |      ", "    |   |      ", "    |   |      ", "    |   |      ", "    |___|      " };
            string[] u = new string[8] { " ___     ___  ", "/   |   |   | ", "|   |   |   | ", "|   |   |   | ", "|   |   |   | ", "|   |   |   | ", @"|   \___/   | ", @"\___________/ " };
            string[] v = new string[8] { " ____    ____  ", "/    |  /    | ", "|    |  |    | ", "|    |  /    / ", "|    | /    /  ", "|    |/    /   ", "|         /    ", "|________/     " };
            string[] w = new string[8] { " ____      ____  ", "/    |    /    | ", "|    |    |    | ", "|    |    |    | ", "|    | __ |    | ", "|    |/  |/    | ", "|     ____     | ", "|____/    |____/ " };
            string[] x = new string[8] { " ____    ____    ", " |    |  |    |  ", @" \    \  /    /  ", @"  \    \/    /   ", @"  /    /\    \   ", @" /    /  \    \  ", @"/    /    \    \ ", "|____|    |____| " };
            string[] y = new string[8] { " ____    _____", @"\    \  /    /", @" \    \/    / ", @"  \        /  ", @"   \      /   ", "    |    |    ", "    |    |    ", "    |____|    " };
            string[] z = new string[8] { " __________  ", "/          | ", "|___      _| ", "    /    /   ", "   /    /    ", " _/    /___  ", "|          | ", "|__________/ " };
            string[] dash = new string[8] { "           ", "           ", " ________  ", "/________/ ", "           ", "           ", "           ", "           " };
            string[] comma = new string[8] { " _____  ", "|     / ", "|    /  ", "|___/   ", "        ", "        ", "        ", "        " };
            string[] space = new string[8] { "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   " };

            // converts names into console art names
            string[] a2 = new string[4] { "  //|| ", " //_|| ", "//--|| ", "||  || " };
            string[] b2 = new string[4] { @"||\\ ", "||// ", @"||\\ ", "||// " };
            string[] c2 = new string[4] { @" //\\ ", "//    ", @"\\    ", @" \\// " };
            string[] d2 = new string[4] { @"|| \\ ", "|| || ", "|| || ", @"|| // " };
            string[] e2 = new string[4] { "||==== ", "||____ ", "||     ", "||==== " };
            string[] f2 = new string[4] { "//==== ", "||____ ", "||     ", "||     " };
            string[] g2 = new string[4] { @" //\\  ", "// ___ ", @"\\ ||  ", @" \\//  " };
            string[] h2 = new string[4] { "||   || ", "||___|| ", "||---|| ", "||   || " };
            string[] i2 = new string[4] { "===||=== ", "   ||    ", "   ||    ", "===||=== " };
            string[] j2 = new string[4] { "===|| ", "   || ", "|| || ", @"\\ // " };
            string[] k2 = new string[4] { "|| // ", "||//  ", @"||\\  ", @"|| \\ " };
            string[] l2 = new string[4] { "||      ", "||      ", "||      ", "||===== " };
            string[] m2 = new string[4] { @"||\\  //|| ", @"|| \\// || ", "||      || ", "||      || " };
            string[] n2 = new string[4] { @"||\\  || ", @"|| || || ", "|| || || ", @"||  \\|| " };
            string[] o2 = new string[4] { @"//===\\ ", "||   || ", "||   || ", @"\\===// " };
            string[] p2 = new string[4] { @"|| \\ ", "|| || ", "|| // ", "||    " };
            string[] q2 = new string[4] { @"//===\\  ", "||   ||  ", "||   === ", @"\\===//  " };
            string[] r2 = new string[4] { @"||\\  ", "||//  ", @"||\\  ", @"|| \\ " };
            string[] s2 = new string[4] { @"//===\\ ", "||___   ", "     || ", @"\\===// " };
            string[] t2 = new string[4] { "===||=== ", "   ||    ", "   ||    ", "   ||    " };
            string[] u2 = new string[4] { "||   || ", "||   || ", "||   || ", @"\\===// " };
            string[] v2 = new string[4] { "||  || ", "||  || ", @"\\  // ", @" \\//  " };
            string[] w2 = new string[4] { "||    || ", "||    || ", "|| || || ", @"\\//\\// " };
            string[] x2 = new string[4] { @"\\  // ", @" \\//  ", @" //\\  ", @"//  \\ " };
            string[] y2 = new string[4] { @"\\  // ", @" \\//  ", "  ||   ", "  ||   " };
            string[] z2 = new string[4] { "====// ", "   //  ", "  //   ", " //==== " };
            string[] mark = new string[4] { @"//\\ ", "  // ", " //  ", " @   " };
            string[] stop = new string[4] { "   ", "   ", "   ", "|| " };
            string[] space2 = new string[4] { "   ", "   ", "   ", "   " };
            string[] doubleSpace = new string[4] { "         ", "         ", "         ", "         " };

            //converts numbers into console art numbers
            string[] one = new string[4] { "|| ", "|| ", "|| ", "|| " };
            string[] two = new string[4] { @"====\\ ", "  __|| ", "||     ", @"\\==== " };
            string[] three = new string[4] { @"====\\ ", "____|| ", "    || ", "====// " };
            string[] four = new string[4] { "||   || ", "||___|| ", "     || ", "     || " };
            string[] five = new string[4] { "//==== ", "||__   ", "    || ", @"====// " };
            string[] six = new string[4] { "||       ", "||____   ", "||    || ", @"\\====// " };
            string[] seven = new string[4] { @"====\\ ", "    || ", "    || ", "    || " };
            string[] eight = new string[4] { @"//====\\ ", "||____|| ", "||    || ", @"\\====// " };
            string[] nine = new string[4] { @"//====\\ ", "||____|| ", "      || ", "      || " };
            string[] zero = new string[4] { @"//====\\ ", "||    || ", "||    || ", @"\\====// " };
            string[] comma2 = new string[4] { "   ", "   ", "   ", "// " };

            Console.WriteLine("Would you like to find a game? y or n");
            input = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(input) || int.TryParse(input, out inNum))
            {
                Console.WriteLine("Invalid input, please use y or n");
                input = Console.ReadLine();
            }

            if (input == "y")
            {
                start:
                Console.WriteLine("What game would you like to look up?");
                input = Console.ReadLine();
                Console.Write("\r\n");
                while (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Nothing was entered, please try again.");
                    input = Console.ReadLine();
                }
                int listPos = titles.IndexOf(input);
                Console.WriteLine(titles[listPos] + "\r\n" + titanS[listPos] + "\r\n" + legendS[listPos] + "\r\n" + champS[listPos] + "\r\n");
                Console.WriteLine("Would you like to find another game? Y for yes N for no.");
                input = Console.ReadLine();
                if (input == "y")
                {
                    goto start;
                }
                if (input == "n")
                {
                    Console.WriteLine("Goodbye");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
            }
            if (input == "n")
            {
                Console.WriteLine("Goodbye");
                Thread.Sleep(1000);
                Console.Clear();
            }

            while (true)
            {
                for (int huh = 0; huh < titles.Count; huh++)
                {
                    title = titles[huh];
                    char[] titleArray = convert(title);
                    //This converts the title into the title art
                    for (int yx = 0; yx < 8; yx++)
                    {
                        for (int xy = 0; xy < titleArray.Length; xy++)
                        {
                            if (titleArray[xy] == 'a')
                            {
                                Console.Write(a[yx]);
                            }
                            else if (titleArray[xy] == 'b')
                            {
                                Console.Write(b[yx]);
                            }
                            else if (titleArray[xy] == 'c')
                            {
                                Console.Write(c[yx]);
                            }
                            else if (titleArray[xy] == 'e')
                            {
                                Console.Write(e[yx]);
                            }
                            else if (titleArray[xy] == 'd')
                            {
                                Console.Write(d[yx]);
                            }
                            else if (titleArray[xy] == 'f')
                            {
                                Console.Write(f[yx]);
                            }
                            else if (titleArray[xy] == 'g')
                            {
                                Console.Write(g[yx]);
                            }
                            else if (titleArray[xy] == 'h')
                            {
                                Console.Write(h[yx]);
                            }
                            else if (titleArray[xy] == 'i')
                            {
                                Console.Write(i[yx]);
                            }
                            else if (titleArray[xy] == 'j')
                            {
                                Console.Write(j[yx]);
                            }
                            else if (titleArray[xy] == 'k')
                            {
                                Console.Write(k[yx]);
                            }
                            else if (titleArray[xy] == 'l')
                            {
                                Console.Write(l[yx]);
                            }
                            else if (titleArray[xy] == 'm')
                            {
                                Console.Write(m[yx]);
                            }
                            else if (titleArray[xy] == 'n')
                            {
                                Console.Write(n[yx]);
                            }
                            else if (titleArray[xy] == 'o')
                            {
                                Console.Write(o[yx]);
                            }
                            else if (titleArray[xy] == 'p')
                            {
                                Console.Write(p[yx]);
                            }
                            else if (titleArray[xy] == 'q')
                            {
                                Console.Write(q[yx]);
                            }
                            else if (titleArray[xy] == 'r')
                            {
                                Console.Write(r[yx]);
                            }
                            else if (titleArray[xy] == 's')
                            {
                                Console.Write(s[yx]);
                            }
                            else if (titleArray[xy] == 't')
                            {
                                Console.Write(t[yx]);
                            }
                            else if (titleArray[xy] == 'u')
                            {
                                Console.Write(u[yx]);
                            }
                            else if (titleArray[xy] == 'v')
                            {
                                Console.Write(v[yx]);
                            }
                            else if (titleArray[xy] == 'w')
                            {
                                Console.Write(w[yx]);
                            }
                            else if (titleArray[xy] == 'x')
                            {
                                Console.Write(x[yx]);
                            }
                            else if (titleArray[xy] == 'y')
                            {
                                Console.Write(y[yx]);
                            }
                            else if (titleArray[xy] == 'z')
                            {
                                Console.Write(z[yx]);
                            }
                            else if (titleArray[xy] == '-')
                            {
                                Console.Write(dash[yx]);
                            }
                            else if (titleArray[xy] == ',')
                            {
                                Console.Write(comma[yx]);
                            }
                            else if (titleArray[xy] == ' ')
                            {
                                Console.Write(space[yx]);
                            }
                        }
                        Console.Write("\r\n");
                    }
                    Console.Write("\r\nAuthored by Seth Rudisill\r\n");
                    Console.WriteLine("\r\n-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    Thread.Sleep(3000);

                    //this converts the name and score into the character art
                    nameScoreTitan = titanS[huh];
                    char[] titan = convert(nameScoreTitan);
                    rank = "titan";
                    char[] Titan = convert(rank);

                    for (int ba = 0; ba < 4; ba++)
                    {
                        for (int ab = 0; ab < Titan.Length; ab++)
                        {
                            if (Titan[ab] == 'a')
                            {
                                Console.Write(a2[ba]);
                            }
                            else if (Titan[ab] == 'i')
                            {
                                Console.Write(i2[ba]);
                            }
                            else if (Titan[ab] == 'n')
                            {
                                Console.Write(n2[ba]);
                            }
                            else if (Titan[ab] == 't')
                            {
                                Console.Write(t2[ba]);
                            }
                        }
                        Console.Write("\r\n");
                    }
                    Console.Write("\r\n");

                    for (int yx = 0; yx < 4; yx++)
                    {
                        for (int xy = 0; xy < titan.Length; xy++)
                        {
                            if (titan[xy] == 'a')
                            {
                                Console.Write(a2[yx]);
                            }
                            else if (titan[xy] == 'b')
                            {
                                Console.Write(b2[yx]);
                            }
                            else if (titan[xy] == 'c')
                            {
                                Console.Write(c2[yx]);
                            }
                            else if (titan[xy] == 'd')
                            {
                                Console.Write(d2[yx]);
                            }
                            else if (titan[xy] == 'e')
                            {
                                Console.Write(e2[yx]);
                            }
                            else if (titan[xy] == 'f')
                            {
                                Console.Write(f2[yx]);
                            }
                            else if (titan[xy] == 'g')
                            {
                                Console.Write(g2[yx]);
                            }
                            else if (titan[xy] == 'h')
                            {
                                Console.Write(h2[yx]);
                            }
                            else if (titan[xy] == 'i')
                            {
                                Console.Write(i2[yx]);
                            }
                            else if (titan[xy] == 'j')
                            {
                                Console.Write(j2[yx]);
                            }
                            else if (titan[xy] == 'k')
                            {
                                Console.Write(k2[yx]);
                            }
                            else if (titan[xy] == 'l')
                            {
                                Console.Write(l2[yx]);
                            }
                            else if (titan[xy] == 'm')
                            {
                                Console.Write(m2[yx]);
                            }
                            else if (titan[xy] == 'n')
                            {
                                Console.Write(n2[yx]);
                            }
                            else if (titan[xy] == 'o')
                            {
                                Console.Write(o2[yx]);
                            }
                            else if (titan[xy] == 'p')
                            {
                                Console.Write(p2[yx]);
                            }
                            else if (titan[xy] == 'q')
                            {
                                Console.Write(q2[yx]);
                            }
                            else if (titan[xy] == 'r')
                            {
                                Console.Write(r2[yx]);
                            }
                            else if (titan[xy] == 's')
                            {
                                Console.Write(s2[yx]);
                            }
                            else if (titan[xy] == 't')
                            {
                                Console.Write(t2[yx]);
                            }
                            else if (titan[xy] == 'u')
                            {
                                Console.Write(u2[yx]);
                            }
                            else if (titan[xy] == 'v')
                            {
                                Console.Write(v2[yx]);
                            }
                            else if (titan[xy] == 'w')
                            {
                                Console.Write(w2[yx]);
                            }
                            else if (titan[xy] == 'x')
                            {
                                Console.Write(x2[yx]);
                            }
                            else if (titan[xy] == 'y')
                            {
                                Console.Write(y2[yx]);
                            }
                            else if (titan[xy] == 'z')
                            {
                                Console.Write(z2[yx]);
                            }
                            else if (titan[xy] == ' ')
                            {
                                Console.Write(space2[yx]);
                            }
                            else if (titan[xy] == '/')
                            {
                                Console.Write(doubleSpace[yx]);
                            }
                            else if (titan[xy] == '1')
                            {
                                Console.Write(one[yx]);
                            }
                            else if (titan[xy] == '2')
                            {
                                Console.Write(two[yx]);
                            }
                            else if (titan[xy] == '3')
                            {
                                Console.Write(three[yx]);
                            }
                            else if (titan[xy] == '4')
                            {
                                Console.Write(four[yx]);
                            }
                            else if (titan[xy] == '5')
                            {
                                Console.Write(five[yx]);
                            }
                            else if (titan[xy] == '6')
                            {
                                Console.Write(six[yx]);
                            }
                            else if (titan[xy] == '7')
                            {
                                Console.Write(seven[yx]);
                            }
                            else if (titan[xy] == '8')
                            {
                                Console.Write(eight[yx]);
                            }
                            else if (titan[xy] == '9')
                            {
                                Console.Write(nine[yx]);
                            }
                            else if (titan[xy] == '0')
                            {
                                Console.Write(zero[yx]);
                            }
                            else if (titan[xy] == ',')
                            {
                                Console.Write(comma2[yx]);
                            }
                            else if (titan[xy] == '.')
                            {
                                Console.Write(stop[yx]);
                            }
                            else if (titan[xy] == '?')
                            {
                                Console.Write(mark[yx]);
                            }
                        }
                        Console.Write("\r\n");
                    }
                    Console.WriteLine("\r\n-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    Thread.Sleep(3000);

                    nameScoreLegend = legendS[huh];
                    char[] legend = convert(nameScoreLegend);
                    rank = "legend";
                    char[] Legend = convert(rank);

                    for (int bc = 0; bc < 4; bc++)
                    {
                        for (int cb = 0; cb < Legend.Length; cb++)
                        {
                            if (Legend[cb] == 'd')
                            {
                                Console.Write(d2[bc]);
                            }
                            else if (Legend[cb] == 'e')
                            {
                                Console.Write(e2[bc]);
                            }
                            else if (Legend[cb] == 'g')
                            {
                                Console.Write(g2[bc]);
                            }
                            else if (Legend[cb] == 'l')
                            {
                                Console.Write(l2[bc]);
                            }
                            else if (Legend[cb] == 'n')
                            {
                                Console.Write(n2[bc]);
                            }
                        }
                        Console.Write("\r\n");
                    }
                    Console.Write("\r\n");

                    for (int yx = 0; yx < 4; yx++)
                    {
                        for (int xy = 0; xy < legend.Length; xy++)
                        {
                            if (legend[xy] == 'a')
                            {
                                Console.Write(a2[yx]);
                            }
                            else if (legend[xy] == 'b')
                            {
                                Console.Write(b2[yx]);
                            }
                            else if (legend[xy] == 'c')
                            {
                                Console.Write(c2[yx]);
                            }
                            else if (legend[xy] == 'd')
                            {
                                Console.Write(d2[yx]);
                            }
                            else if (legend[xy] == 'e')
                            {
                                Console.Write(e2[yx]);
                            }
                            else if (legend[xy] == 'f')
                            {
                                Console.Write(f2[yx]);
                            }
                            else if (legend[xy] == 'g')
                            {
                                Console.Write(g2[yx]);
                            }
                            else if (legend[xy] == 'h')
                            {
                                Console.Write(h2[yx]);
                            }
                            else if (legend[xy] == 'i')
                            {
                                Console.Write(i2[yx]);
                            }
                            else if (legend[xy] == 'j')
                            {
                                Console.Write(j2[yx]);
                            }
                            else if (legend[xy] == 'k')
                            {
                                Console.Write(k2[yx]);
                            }
                            else if (legend[xy] == 'l')
                            {
                                Console.Write(l2[yx]);
                            }
                            else if (legend[xy] == 'm')
                            {
                                Console.Write(m2[yx]);
                            }
                            else if (legend[xy] == 'n')
                            {
                                Console.Write(n2[yx]);
                            }
                            else if (legend[xy] == 'o')
                            {
                                Console.Write(o2[yx]);
                            }
                            else if (legend[xy] == 'p')
                            {
                                Console.Write(p2[yx]);
                            }
                            else if (legend[xy] == 'q')
                            {
                                Console.Write(q2[yx]);
                            }
                            else if (legend[xy] == 'r')
                            {
                                Console.Write(r2[yx]);
                            }
                            else if (legend[xy] == 's')
                            {
                                Console.Write(s2[yx]);
                            }
                            else if (legend[xy] == 't')
                            {
                                Console.Write(t2[yx]);
                            }
                            else if (legend[xy] == 'u')
                            {
                                Console.Write(u2[yx]);
                            }
                            else if (legend[xy] == 'v')
                            {
                                Console.Write(v2[yx]);
                            }
                            else if (legend[xy] == 'w')
                            {
                                Console.Write(w2[yx]);
                            }
                            else if (legend[xy] == 'x')
                            {
                                Console.Write(x2[yx]);
                            }
                            else if (legend[xy] == 'y')
                            {
                                Console.Write(y2[yx]);
                            }
                            else if (legend[xy] == 'z')
                            {
                                Console.Write(z2[yx]);
                            }
                            else if (legend[xy] == ' ')
                            {
                                Console.Write(space2[yx]);
                            }
                            else if (legend[xy] == '/')
                            {
                                Console.Write(doubleSpace[yx]);
                            }
                            else if (legend[xy] == '1')
                            {
                                Console.Write(one[yx]);
                            }
                            else if (legend[xy] == '2')
                            {
                                Console.Write(two[yx]);
                            }
                            else if (legend[xy] == '3')
                            {
                                Console.Write(three[yx]);
                            }
                            else if (legend[xy] == '4')
                            {
                                Console.Write(four[yx]);
                            }
                            else if (legend[xy] == '5')
                            {
                                Console.Write(five[yx]);
                            }
                            else if (legend[xy] == '6')
                            {
                                Console.Write(six[yx]);
                            }
                            else if (legend[xy] == '7')
                            {
                                Console.Write(seven[yx]);
                            }
                            else if (legend[xy] == '8')
                            {
                                Console.Write(eight[yx]);
                            }
                            else if (legend[xy] == '9')
                            {
                                Console.Write(nine[yx]);
                            }
                            else if (legend[xy] == '0')
                            {
                                Console.Write(zero[yx]);
                            }
                            else if (legend[xy] == ',')
                            {
                                Console.Write(comma2[yx]);
                            }
                            else if (legend[xy] == '.')
                            {
                                Console.Write(stop[yx]);
                            }
                            else if (legend[xy] == '?')
                            {
                                Console.Write(mark[yx]);
                            }
                        }
                        Console.Write("\r\n");
                    }
                    Console.WriteLine("\r\n-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    Thread.Sleep(3000);

                    nameScoreChamp = champS[huh];
                    char[] champ = convert(nameScoreChamp);
                    rank = "champion";
                    char[] Champ = convert(rank);

                    for (int cd = 0; cd < 4; cd++)
                    {
                        for (int dc = 0; dc < Champ.Length; dc++)
                        {
                            if (Champ[dc] == 'a')
                            {
                                Console.Write(a2[cd]);
                            }
                            else if (Champ[dc] == 'c')
                            {
                                Console.Write(c2[cd]);
                            }
                            else if (Champ[dc] == 'h')
                            {
                                Console.Write(h2[cd]);
                            }
                            else if (Champ[dc] == 'i')
                            {
                                Console.Write(i2[cd]);
                            }
                            else if (Champ[dc] == 'm')
                            {
                                Console.Write(m2[cd]);
                            }
                            else if (Champ[dc] == 'n')
                            {
                                Console.Write(n2[cd]);
                            }
                            else if (Champ[dc] == 'o')
                            {
                                Console.Write(o2[cd]);
                            }
                            else if (Champ[dc] == 'p')
                            {
                                Console.Write(p2[cd]);
                            }
                        }
                        Console.Write("\r\n");
                    }
                    Console.Write("\r\n");

                    for (int yx = 0; yx < 4; yx++)
                    {
                        for (int xy = 0; xy < champ.Length; xy++)
                        {
                            if (champ[xy] == 'a')
                            {
                                Console.Write(a2[yx]);
                            }
                            else if (champ[xy] == 'b')
                            {
                                Console.Write(b2[yx]);
                            }
                            else if (champ[xy] == 'c')
                            {
                                Console.Write(c2[yx]);
                            }
                            else if (champ[xy] == 'd')
                            {
                                Console.Write(d2[yx]);
                            }
                            else if (champ[xy] == 'e')
                            {
                                Console.Write(e2[yx]);
                            }
                            else if (champ[xy] == 'f')
                            {
                                Console.Write(f2[yx]);
                            }
                            else if (champ[xy] == 'g')
                            {
                                Console.Write(g2[yx]);
                            }
                            else if (champ[xy] == 'h')
                            {
                                Console.Write(h2[yx]);
                            }
                            else if (champ[xy] == 'i')
                            {
                                Console.Write(i2[yx]);
                            }
                            else if (champ[xy] == 'j')
                            {
                                Console.Write(j2[yx]);
                            }
                            else if (champ[xy] == 'k')
                            {
                                Console.Write(k2[yx]);
                            }
                            else if (champ[xy] == 'l')
                            {
                                Console.Write(l2[yx]);
                            }
                            else if (champ[xy] == 'm')
                            {
                                Console.Write(m2[yx]);
                            }
                            else if (champ[xy] == 'n')
                            {
                                Console.Write(n2[yx]);
                            }
                            else if (champ[xy] == 'o')
                            {
                                Console.Write(o2[yx]);
                            }
                            else if (champ[xy] == 'p')
                            {
                                Console.Write(p2[yx]);
                            }
                            else if (champ[xy] == 'q')
                            {
                                Console.Write(q2[yx]);
                            }
                            else if (champ[xy] == 'r')
                            {
                                Console.Write(r2[yx]);
                            }
                            else if (champ[xy] == 's')
                            {
                                Console.Write(s2[yx]);
                            }
                            else if (champ[xy] == 't')
                            {
                                Console.Write(t2[yx]);
                            }
                            else if (champ[xy] == 'u')
                            {
                                Console.Write(u2[yx]);
                            }
                            else if (champ[xy] == 'v')
                            {
                                Console.Write(v2[yx]);
                            }
                            else if (champ[xy] == 'w')
                            {
                                Console.Write(w2[yx]);
                            }
                            else if (champ[xy] == 'x')
                            {
                                Console.Write(x2[yx]);
                            }
                            else if (champ[xy] == 'y')
                            {
                                Console.Write(y2[yx]);
                            }
                            else if (champ[xy] == 'z')
                            {
                                Console.Write(z2[yx]);
                            }
                            else if (champ[xy] == ' ')
                            {
                                Console.Write(space2[yx]);
                            }
                            else if (champ[xy] == '/')
                            {
                                Console.Write(doubleSpace[yx]);
                            }
                            else if (champ[xy] == '1')
                            {
                                Console.Write(one[yx]);
                            }
                            else if (champ[xy] == '2')
                            {
                                Console.Write(two[yx]);
                            }
                            else if (champ[xy] == '3')
                            {
                                Console.Write(three[yx]);
                            }
                            else if (champ[xy] == '4')
                            {
                                Console.Write(four[yx]);
                            }
                            else if (champ[xy] == '5')
                            {
                                Console.Write(five[yx]);
                            }
                            else if (champ[xy] == '6')
                            {
                                Console.Write(six[yx]);
                            }
                            else if (champ[xy] == '7')
                            {
                                Console.Write(seven[yx]);
                            }
                            else if (champ[xy] == '8')
                            {
                                Console.Write(eight[yx]);
                            }
                            else if (champ[xy] == '9')
                            {
                                Console.Write(nine[yx]);
                            }
                            else if (champ[xy] == '0')
                            {
                                Console.Write(zero[yx]);
                            }
                            else if (champ[xy] == ',')
                            {
                                Console.Write(comma2[yx]);
                            }
                            else if (champ[xy] == '.')
                            {
                                Console.Write(stop[yx]);
                            }
                            else if (champ[xy] == '?')
                            {
                                Console.Write(mark[yx]);
                            }
                        }
                        Console.Write("\r\n");
                    }
                    Console.WriteLine("\r\n-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    Thread.Sleep(5000);
                    Console.Clear();
                }
            }
        }
        public static char[] convert(string incoming)
        {
            char[] stringArray = incoming.ToCharArray();
            return stringArray;
        }
    }
}
