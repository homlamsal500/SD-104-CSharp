
/*
Project:    Lab 2 Calculate Batting Average
Date:        to/da/y
Author:     You the big new programmer
Notes:      This program reads in a baseball player's name,
            number of hits and number of at bats.
            The player's batting average is calculated and displayed
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable declaration
            string strPlayerName;
            int nHits, nAtBats;
            double dblBattingAvrage;


            //prompt for name recive 
            Console.WriteLine("~this programe calculate abaseball player's batting avrage~");
            Console.WriteLine("<------------>");
            Console.WriteLine("");//we will learn other ways to do this on console programs
            Console.WriteLine("Enter the player's name ");
            strPlayerName = Console.ReadLine();
            Console.WriteLine(strPlayerName);
            Console.ReadLine();

            //prompt for name and recive
            Console.WriteLine("~This programe calcitates a baseball player's batting average~");
            Console.WriteLine("<----------------------------->");
            Console.WriteLine("");//we will learn other ways to do this in console programs
            Console.WriteLine("Enter the playes's name: ");
            strPlayerName = Console.ReadLine();

            //prompt for name and receive 
            Console.WriteLine("~This programe calcitates a baseball player's batting average~");
            Console.WriteLine("<----------------------------->");
            Console.WriteLine("");//we will learn other ways to do this in console programs
            Console.WriteLine("Enter the playes's name: ");
            strPlayerName = Console.ReadLine();

            //prompt for hits
            Console.WriteLine("Enter the player's # of hits: ");
            nHits = Convert.ToInt32(Console.ReadLine());

            //prompt for hits, walks and at bats
            Console.WriteLine("Enter the player's # of hits: ");
            nHits = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the player's # of at bats: ");
            nHits = Convert.ToInt32(Console.ReadLine());


            //prompt for hits, walks and at bats
            Console.WriteLine("Enter the player's # of hits: ");
            nHits = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the player's # of at bats: ");
            nAtBats = Convert.ToInt32(Console.ReadLine());
           
            //calculation

            dblBattingAvrage = nHits / nAtBats;


            Console.WriteLine("Enter the player's # of at bats: ");
            nAtBats = Convert.ToInt32(Console.ReadLine());

            //calculation
            dblBattingAvrage = nHits / nAtBats;

            Console.WriteLine(strPlayerName + "'s batting avarege is " + dblBattingAvrage);
            Console.ReadLine();



        }
        }
}
