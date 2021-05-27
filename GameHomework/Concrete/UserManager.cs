using GameHomework.Abstract;
using GameHomework.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomework.Concrete
{
    public class UserManager : IUserService
    {
        private IUserCheckService _userCheckService;
        public UserManager(IUserCheckService userCheckService)
        {
            _userCheckService = userCheckService;
        }
        public void Save(User user)
        {
            if (_userCheckService.CheckIfRealPerson(user))
            {
                Console.WriteLine("KAYIT BAŞARILI: " + user.FirstName+" "+user.LastName);
            }
            else
            {
                throw new Exception("Kayıt Başarısız. Bilgilerinizi kontrol edin.");
            }
        }

        public void Update(User user)
        {
            Console.WriteLine("Kullanıcı güncellendi: "+user.FirstName);
        }
        public void Deleted(User user)
        {
            Console.WriteLine("Kullanıcı silindi: " + user.FirstName);
        }
    }
}
