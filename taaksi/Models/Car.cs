﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace taaksi.Models;

public partial class Car
{
    public int CarId { get; set; }

    public string Model { get; set; }

    public string Make { get; set; }

    public int? Year { get; set; }

    public string PlateNumber { get; set; }

    public int? CurrentDriverId { get; set; }

    public virtual Driver CurrentDriver { get; set; }

    public virtual ICollection<Mileage> Mileages { get; set; } = new List<Mileage>();

    public virtual ICollection<Trip> Trips { get; set; } = new List<Trip>();
}