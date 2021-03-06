﻿using System.Web.Mvc;
using AutoMapper;
using LibraryWebApplication.Contracts;
using LibraryWebApplication.Dtos;
using LibraryWebApplication.Models;
using LibraryWebApplication.Parser;
using LibraryWebApplication.Services;

namespace LibraryWebApplication.Controllers
{

    public class AccountController: Controller
    {
        private IUserService userService;

        private Mapper mapper;

        public AccountController()
        {
            this.userService = new UserService();
        }

        public ActionResult Index()
        {
            return View("Login");
        }

        public ActionResult Login(UserDto dto)
        {
            string userName = dto.Username;
            User user = this.userService.GetByName(userName);
            if (user.Password != dto.Password)
            {
                ModelState.AddModelError("Password", "Incorrect password.");
                return View("Login");
            }

            return View("~/Views/BookList/BookList.cshtml");
        }

        public ActionResult Register(UserDto dto)
        {
            
            return View();
        }

        public ActionResult RegisterUser(UserDto dto)
        {
            if (!ModelState.IsValid)
            {
                return View("Register");
            }

            User user = null;
            user = DTOParser.Parse(dto, user);
            this.userService.Add(user);

            return View("Login");
        }


    }
}