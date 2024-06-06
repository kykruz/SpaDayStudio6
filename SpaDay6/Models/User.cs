﻿namespace SpaDay6;

public class User
{
    public string UserName {get; set;}

    public string Email {get; set;}

    public string Password {get; set;}

    public User() {}
    public User(string username, string email, string password) : this()
    {
        UserName = username;
        Email = email;
        Password = password;
        
    }
}
