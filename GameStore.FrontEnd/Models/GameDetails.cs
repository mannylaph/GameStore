using System;

namespace GameStore.FrontEnd.Models;

public class GameDetails
{
    public int id { get; set; }

    public required string Name { get; set; }

    public  string? GenreID { get; set; }


    public decimal Price { get; set; }

    public DateOnly ReleaseDate { get; set; }

}
