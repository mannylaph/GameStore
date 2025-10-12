using System;

namespace GameStore.FrontEnd.Models;

public class GameSummary
{
    public int id { get; set; }

    public required string Name { get; set; }

    public required string Genre { get; set; }


    public decimal Price { get; set; }

    public DateOnly ReleaseDate { get; set; }

}
