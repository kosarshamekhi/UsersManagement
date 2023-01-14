﻿using Microsoft.EntityFrameworkCore;
using UsersManagement.Model.Notes.Entities;
using UsersManagement.Model.Users;

namespace UsersManagement.DAL.DbContexts;

public static class ModelBuilderExtensions
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(
        new User
        {
            FirstName = "Ali",
            LastName = "Hoseyni",
            Email = "AliHoseyni@gmail.com",
            Age = 20,
            Website = "",
            Notes = new List<Note>
            {
                new Note { Content = " Salam ", DateCreated = DateTime.Now, DateModified = DateTime.Now, Views = 5, Published = true },
                new Note { Content = "My Name is Kosar", DateCreated = DateTime.Now, DateModified = DateTime.Now, Views = 5, Published = true }
            }
        }
        );

        modelBuilder.Entity<User>().HasData(
        new User
        {
            FirstName = "zahra",
            LastName = "Rahimi",
            Email = "zahraRahimi@gmail.com",
            Age = 34,
            Website = "",
            Notes = new List<Note>
            {
                new Note { Content = "Hiiiiiii", DateCreated = DateTime.Now, DateModified = DateTime.Now, Views = 5, Published = true },
                new Note { Content = "My Name is Zahraaaaaaaa", DateCreated = DateTime.Now, DateModified = DateTime.Now, Views = 5, Published = true }
            }
        }
        );

        modelBuilder.Entity<User>().HasData(
        new User
        {
            FirstName = "Mehdi",
            LastName = "Rezayi",
            Email = "Mehdi.Rezayi@gmail.com",
            Age = 44,
            Website = "",
            Notes = new List<Note>
            {
                new Note { Content = "Hiiiiiii Mary", DateCreated = DateTime.Now, DateModified = DateTime.Now, Views = 5, Published = true },
                new Note { Content = "My Name is Mehdi", DateCreated = DateTime.Now, DateModified = DateTime.Now, Views = 5, Published = true }
            }
        }
        );
    }
}
