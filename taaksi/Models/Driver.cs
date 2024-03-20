﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace taaksi.Models;

public partial class Driver
{
    public int DriverId { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string PhoneNumber { get; set; }

    public string LicenseNumber { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<Car> Cars { get; set; } = new List<Car>();

    public virtual ICollection<DriverRating> DriverRatings { get; set; } = new List<DriverRating>();

    public virtual ICollection<Trip> Trips { get; set; } = new List<Trip>();
}