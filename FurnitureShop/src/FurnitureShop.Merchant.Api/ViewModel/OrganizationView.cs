﻿using FurnitureShop.Data.Entities;

namespace FurnitureShop.Merchant.Api.ViewModel;

public class OrganizationView
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? ImageUrl { get; set; }
    public EOrganizationStatus Status { get; set; }
}