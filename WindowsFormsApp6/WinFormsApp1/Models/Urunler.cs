using System;
using System.Collections.Generic;

namespace WinFormsApp1.Models;

public partial class Urunler
{
    public int Id { get; set; }

    public string? UrunAdı { get; set; }

    public decimal? UrunFiyati { get; set; }

    public int Type { get; set; }

    public string? Pic { get; set; }
}
