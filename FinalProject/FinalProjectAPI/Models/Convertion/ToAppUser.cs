using FinalProjectAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectAPI.Models.Convertion
{
    public static class ToAppUser
    {
        public static AppUser FromRegisterModel(RegisterModel model)
        {
            return new AppUser
            {
                Email = model.Email,
                Name = model.Name,
                Surname = model.Surname,
                Address = model.Address,
                PhoneNumber = model.PhoneNumber,
                UserName = model.Name + "_" + model.Surname,
            };

        }
    }
}
