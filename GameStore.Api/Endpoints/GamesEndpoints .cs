using GameStore.Api.Dtos;

namespace GameStore.Api.Endpoints;

public static class GamesEndpoints
{
    private static readonly List<GameDto> games = [
    new (
        1,
        "Street Fighter II",
        "FIghting",
        19.99M,
        new DateOnly(1992, 7, 15)),
    new (
        2,
        "Final Fantasy XIV",
        "Roleplaying",
        59.99M,
        new DateOnly(2010, 9, 30)),
    new (
        3,
        "FIFA 23",
        "Sports",
        69.99M,
        new DateOnly(2022, 9, 27))
    ];
}
