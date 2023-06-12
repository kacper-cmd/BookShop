﻿using ClothesShop.Data.Data;
using ClothesShop.Data.Data.Shop;
using ClothesShop.PortalWWW.Models;
using ClothesShop.PortalWWW.Services.Common;
using Microsoft.EntityFrameworkCore;
using System.Web.Helpers;

namespace ClothesShop.PortalWWW.Services
{
    public class AccountService : IAccountService
    {
        private List<User> _users;
        private readonly ClothesShopContext _context;

        public AccountService(ClothesShopContext context)
        {
            _context = context;
            //_users =  _context.User.ToList();
          
        }

        //public User Login(string username, string password)
        //{
        //    return _users.SingleOrDefault(x => x.Username == username && x.Password == password);
        //}
       
        public LoginResult Login(string username, string password)
        {
            try
            {
                //var user = _context.User.SingleOrDefault(x => x.Username == username && x.Password == password);
                var user = _context.User.FirstOrDefault(x => x.Username == username);

                if (user != null && VerifyPassword(password, user.Password))
                {
                    return new LoginResult
                    {
                        IsSuccessful = true,
                        ErrorMessage = "Login successful",
                        User = user
                    };

                }
                else
                {
                    return new LoginResult
                    {
                        IsSuccessful = false,
                        ErrorMessage = "Invalid username or password",
                        User = null
                    };
                }

            }
            catch(Exception e)
            {
                return new LoginResult
                {
                    IsSuccessful = false,
                    ErrorMessage = "An error occurred during login",
                    User = null
                };
            }
        }

        private bool VerifyPassword(string enteredPassword, string storedPassword)
        {

            return Crypto.VerifyHashedPassword(storedPassword, enteredPassword);
           // return enteredPassword == storedPassword;

        }

        public LoginResult Register(string username, string password, string email)
        {
            try
            {
                var hashedPassword = Crypto.HashPassword(password);
                var user = new User
                {
                    Username = username,
                    Password = hashedPassword,
                    Email = email
                };
                _context.User.Add(user);
                _context.SaveChanges();

                return new LoginResult
                {
                    IsSuccessful = true,
                    User = user
                };
            }
            catch (Exception ex)
            {
                return new LoginResult
                {
                    IsSuccessful = false,
                    User = null
                };
            }
        }

    }
}
