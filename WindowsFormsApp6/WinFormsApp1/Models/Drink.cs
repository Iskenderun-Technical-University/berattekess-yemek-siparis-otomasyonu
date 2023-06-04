using System;
using System.Collections.Generic;

namespace WinFormsApp1.Models;

public partial class Drink
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public decimal? Fiyati { get; set; }

    public string? Resim { get; set; }
}
