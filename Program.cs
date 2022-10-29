using System;

namespace Lab2 {

    class Program {

        static void Main(string[] args)
        {

            string user1 = "David";
            string user2 = "Bob";

            GameAccount account1 = new GameAccount(user1);

            GameFactory factory = new GameFactory();

            account1.WinGame(factory.CreateTrainingGame("Training Game 1"), user1, user2); // training game
            Console.Write("The rating of {0} is ", user1);
            Console.WriteLine(account1.CurrentRating);

            account1.LoseGame(factory.CreateTrainingGame("Training Game 2"), user1, user2);
            Console.Write("The rating of {0} is ", user1);
            Console.WriteLine(account1.CurrentRating);

            account1.WinGame(factory.CreateStandartGame("Standart Game 1", 20), user1, user2); //standart game
            Console.Write("The rating of {0} is ", user1);
            Console.WriteLine(account1.CurrentRating);

            account1.LoseGame(factory.CreateStandartGame("Standart Game 2", 20), user1, user2);
            Console.Write("The rating of {0} is ", user1);
            Console.WriteLine(account1.CurrentRating);

            account1.WinGame(factory.CreateDoubleGame("Double Game 1", 20), user1, user2); // double game
            Console.Write("The rating of {0} is ", user1);
            Console.WriteLine(account1.CurrentRating);

            account1.LoseGame(factory.CreateDoubleGame("Double Game 2", 20), user1, user2);
            Console.Write("The rating of {0} is ", user1);
            Console.WriteLine(account1.CurrentRating);

            Console.WriteLine(account1.GetHistory());

            

            AccountX2 account2 = new AccountX2(user2);

            account2.WinGame(factory.CreateTrainingGame("Training Game 1"), user2, user1); // training game
            Console.Write("The rating of {0} is ", user2);
            Console.WriteLine(account2.CurrentSpecialRating);

            account2.LoseGame(factory.CreateTrainingGame("Training Game 2"), user2, user1);
            Console.Write("The rating of {0} is ", user2);
            Console.WriteLine(account2.CurrentSpecialRating);

            account2.WinGame(factory.CreateStandartGame("Standart Game 1", 20), user2, user1); // standart game
            Console.Write("The rating of {0} is ", user2);
            Console.WriteLine(account2.CurrentSpecialRating);

            account2.LoseGame(factory.CreateStandartGame("Standart Game 2", 20), user2, user1);
            Console.Write("The rating of {0} is ", user2);
            Console.WriteLine(account2.CurrentSpecialRating);

            account2.WinGame(factory.CreateDoubleGame("Double Game 1", 20), user2, user1); // double game
            Console.Write("The rating of {0} is ", user2);
            Console.WriteLine(account2.CurrentSpecialRating);

            account2.LoseGame(factory.CreateDoubleGame("Double Game 2", 20), user2, user1);
            Console.Write("The rating of {0} is ", user2);
            Console.WriteLine(account2.CurrentSpecialRating);

            Console.WriteLine(account2.GetHistory());


        }

    }

}

