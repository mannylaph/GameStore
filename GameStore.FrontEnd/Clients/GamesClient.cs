using System;
using GameStore.FrontEnd.Models;

namespace GameStore.FrontEnd.Clients;

public class GamesClient
{

    private readonly List<GameSummary> games =
   [
   new(){
    id = 1,
    Name = "Demo Rash",
    Genre = "Motor Bike",
    Price = 29.11M,
    ReleaseDate = new DateOnly(2000,07,21)},

    new(){
    id = 2,
    Name = "FIFA 23",
    Genre = "Soccer",
    Price = 49.15M,
    ReleaseDate = new DateOnly(2023,08,01)},


    new(){
    id = 3,
    Name = "Final Fantasy",
    Genre = "Role Playing",
    Price = 209.31M,
    ReleaseDate = new DateOnly(2024,07,11)},

    new(){
    id = 4,
    Name = "Street Fighter",
    Genre = "Fighting",
    Price = 29.31M,
    ReleaseDate = new DateOnly(1992,09,30)
   }
   ];

    public GameSummary[] GetGames() => [.. games];

}
