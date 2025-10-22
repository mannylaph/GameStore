using System;
using GameStore.FrontEnd.Models;

namespace GameStore.FrontEnd.Clients;

public class GenresClient
{
    private readonly Genre[] genres =
    [
        new(){
            id = 1,
Name = "Fighting"
        },
    new(){
            id = 2,
Name = "Role Playing"
        },
    new(){
            id = 3,
Name = "Sports"
        },
    new(){
            id = 5,
Name = "Racing"
        },
    new(){
            id = 6,
Name = "Kids and Family"
        }

    ];


    public Genre[] GetGenres => genres;

}
