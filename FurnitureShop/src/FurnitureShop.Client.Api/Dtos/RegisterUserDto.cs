﻿using System.ComponentModel.DataAnnotations;

namespace FurnitureShop.Client.Api.Dtos;

public class RegisterUserDto
{

    public string? UserName { get; set; }


    public string? FirstName { get; set; }

    public string? LastName { get; set; }


    public string? Password { get; set; }


    public string? Email { get; set; }

    public IFormFile? Avatar { get; set; }

}