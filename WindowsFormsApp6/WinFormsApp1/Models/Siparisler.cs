using System;
using System.Collections.Generic;

namespace WinFormsApp1.Models;

public partial class Siparisler
{
    public int Id { get; set; }

    public int? UrunId { get; set; }

    public string? MusteriAd { get; set; }

    public int? MusteriTelno { get; set; }

    public decimal? Tutar { get; set; }

    public int? DrinkId { get; set; }

    public string? Adres { get; set; }

    public string? Eposta { get; set; }
}
