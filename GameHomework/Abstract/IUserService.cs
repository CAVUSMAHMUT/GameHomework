using GameHomework.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomework.Abstract
{
    public interface IUserService
    {
        void Save(User user);
        void Deleted(User user);
        void Update(User user);
    }
}
