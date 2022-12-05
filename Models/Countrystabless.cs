using System;
using System.Collections.Generic;

namespace backendcountry.Models;

public partial class Countrystabless
{
    public int CountryId { get; set; }

    public string? CaptitalOfcountry { get; set; }

    public string? CountryName { get; set; }

    public string? CountrtyRegion { get; set; }

    public string? CountryFlag { get; set; }

    public int? CountryPopulation { get; set; }

    public string? CountryCurrency { get; set; }
}
