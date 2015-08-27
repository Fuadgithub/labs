using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime toDay = new DateTime(2015,7, 25,12, 57,0);
            //Console.WriteLine(toDay);
            //Console.WriteLine(toDay.Date);
            //Console.WriteLine(toDay.Hour); 
            //string[] colors = new string [3];
            //colors[0] = "Red";
            //colors[2] = "Blue";
            //string[] color = { "red", "green", "blue" };
            //Console.WriteLine(colors[3]);
            //double[] waterDepth = { 45, 19, 2, 16.7 };
            //string caption = "System.Array Methods Illustrated";
            // double[] w = new double[20];
            //outPutMsg += "waterDepth Array\n\n";
            //foreach (double wVal in waterDepth)
            //    Console.WriteLine(waterDepth);
            // outPutMsg += wVal + "\n";
            //Console.WriteLine(date.);

            ////Generates Random news from an Array
            //Random rnd = new Random();
            //string[] news =
            //{
            //    "Martians Attack","Seahawks win Superbowl", "NewsNo_3"
            //};

            //int Num = rnd.Next(3);

            //foreach(string nws in news)
            //{
            //    Console.WriteLine(nws);
            //};

            //for (int i = 0; i < news.Length; i++)
            //{
            //    Console.WriteLine(news[i]);
            //}
            // Prints outs numbers b/n  1 and 100 that are 
            //divisible by 7 with out remainder
            //for (int i = 1; i <= 100; i++)
            //{
            //     if( i % 7 ==0)
            //    {
            //        Console.Write(i + "  ");
            //    }

            //}
            //Console.WriteLine(Num);
            //Console.WriteLine(news[Num]);

            //Home Work #1a
            //Random Rnd = new Random();
            //int No = Rnd.Next(3);

            //SoundPlayer Sp1 = new SoundPlayer();
            //SoundPlayer Sp2 = new SoundPlayer();
            //SoundPlayer Sp3 = new SoundPlayer();

            //Sp1.SoundLocation = ("http://www.wavsource.com/snds_2015-07-19_1628654123857389/movie_stars/davis/bargain_not.wav");
            //Sp2.SoundLocation = ("http://www.wavsource.com/snds_2015-07-19_1628654123857389/movie_stars/davis/exclusive_rights.wav");
            //Sp3.SoundLocation = ("http://www.wavsource.com/snds_2015-07-19_1628654123857389/movie_stars/davis/funny_not.wav");

            //if (No == 0)
            //{
            //    Sp1.Play();
            //}
            //else if (No == 1)
            //{
            //    Sp2.Play();
            //}
            //else Sp3.Play();

            //Home work #1b


            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Please type only either what you like or you don't like using'I like' or and 'I don't like phrases'");
            //    string choice = Console.ReadLine();
            //    if (choice.Contains("don't"))
            //    {
            //        Console.WriteLine(choice.Replace("don't", ""));
            //        Console.WriteLine(" ");
            //    }
            //    else if (!(choice.Contains("don't")))
            //    {
            //        Console.WriteLine(choice.Insert(1, "don't"));
            //        Console.WriteLine(" ");
            //    }
            //}

            // Instantiating the product class
            Product Prod1 = new Product();
            Prod1._Price = -5m;     
            Console.WriteLine(Prod1._Price);            
            Console.ReadLine();
        }
    }

    class Product
    {
        public string  Name { get; set; }
        public decimal Price { get; set; }
        public decimal _Price
        {
             get { return Price; }
             set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", " Price can not be negative");
                }
                Price = value;
            }
        }
    }
}
