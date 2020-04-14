﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProiect2020
{
    public partial class User
    {
        public bool DeleteUser(int userId)
        {
            using (Proiect2020Container context = new Proiect2020Container())
            {
                var user = context.Users.FirstOrDefault(u => u.UserID == userId);
                context.Users.Remove(user);
                context.SaveChanges();
                return true;
            };
        }

        public User UpdateUser(int userId, string firstName, string lastName, string password, string email, string phone)
        {
            using (Proiect2020Container context = new Proiect2020Container())
            {
                var user = context.Users.FirstOrDefault(u => u.UserID == userId);
                user.FirstName = firstName;
                user.LastName = lastName;
                user.Password = password;
                user.Email = email;
                user.Phone = phone;
                context.SaveChanges();
                return user;
            }
        }

        public User GetUserById(int userId)
        {
            using (Proiect2020Container context = new Proiect2020Container())
            {
                var user = context.Users.FirstOrDefault(u => u.UserID == userId);
                return user;
            };
        }

        public List<User> GetAllUsers()
        {
            using (Proiect2020Container context = new Proiect2020Container())
            {
                return context.Users.ToList();
            };
        }
    }
}
