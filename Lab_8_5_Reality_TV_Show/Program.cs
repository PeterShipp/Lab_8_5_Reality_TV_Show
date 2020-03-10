using System;

namespace Lab_8_5_Reality_TV_Show
{
    class Program
    {
        static void Main(string[] args)
        {
            HouseHunters hhContestant = new HouseHunters("Full Stack Web Developer", 100000, 6, 3, 2, "Donnell", "Love", "10/25/1981",
               "111 Elm Street", "Los Angeles", "California", 90001, "888-233-1234", "donnell.love@hotmail.com");

            ParadiseIsland piContestant = new ParadiseIsland("Female", "Godfearing", 2, "Toya", "Thomas", "4/4/1984", "123 Love Rd", "Los Angeles",
                "California", 90001, "988-444-1234", "toya.Thomas@gmail.com");

            AboveDeck adContestant = new AboveDeck(20, "American", "Captian", "Lee", "7/12/1964", "311 Bravo Rd", "Los Angeles",
            "California", 90001, "711-333-1234", "captian@gmail.com");

            hhContestant.Submit();
            hhContestant.Accept();

            piContestant.Submit();
            piContestant.Accept();

            adContestant.Submit();
            adContestant.Accept();
        }
    }
}
