using GameHomework.Abstract;
using GameHomework.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomework.Adapters
{
    public class MernisServiceAdapter : IUserCheckService
    {
        public bool CheckIfRealPerson(User user)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(Convert.ToInt64(user.NationalityId), user.FirstName.ToUpper(), user.LastName.ToUpper(), user.DateOfBirth.Year);
        }
    }
}
