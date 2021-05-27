using GameHomework.Concrete;
using GameHomework.Entities;
using System;

namespace GameHomework
{
    public class Program
    {
        static void Main(string[] args)
        {
            UserManager userManager = new UserManager(new UserCheckManager());
            userManager.Save(new User { DateOfBirth= new DateTime(1992,1,15), FirstName="Mahmut", LastName="Çavuş", NationalityId="26764184176"});

            userManager.Update(new User { FirstName="Hasan", LastName="Aydın" });
            userManager.Deleted(new User { FirstName="Halil", LastName="Işık"});

            Console.WriteLine("*****************************************************");

            GameManager gameManager = new GameManager();
            gameManager.Add(new Game { GameName="FIFA22", UnitPrice=480, GameCategory="SPOR" });
            gameManager.Deleted(new Game { GameName="PES22"});
            gameManager.Update(new Game { GameName="GEARS OF WAR" });

            Console.WriteLine("*****************************************************");

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(new Campaign {CampaignName="Sepette%10 indiirm" });
            campaignManager.Deleted(new Campaign { });
            campaignManager.Update(new Campaign { });

            Console.WriteLine("*****************************************************");

            Console.ReadLine();

        }
    }
}
