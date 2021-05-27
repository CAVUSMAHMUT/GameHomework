using GameHomework.Abstract;
using GameHomework.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomework.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("Oyunlar eklendi: "+ game.GameName);
        }

        public void Deleted(Game game)
        {
            Console.WriteLine("Oyunlar Silindi: "+ game.GameName);
        }

        public void Update(Game game)
        {
            Console.WriteLine("Oyunlar Güncellendi: "+ game.GameName);
        }
    }
}
