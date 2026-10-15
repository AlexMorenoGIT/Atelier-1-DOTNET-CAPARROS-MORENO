using Atelier_1.Tiles;

namespace Atelier_1;

public class Labyrinth
{
    private readonly Tile[,] _tiles;

    public int Width { get; }
    public int Height { get; }

    public Labyrinth(string map)
    {
        string[] lines = map.Split('\n');

        Height = lines.Length;
        Width = lines[0].Length;

        _tiles = new Tile[Width, Height];

        for (int y = 0; y < Height; y++)
        {
            for (int x = 0; x < Width; x++)
            {
                _tiles[x, y] = lines[y][x] switch
                {
                    '+' or '-' or '|' => new Wall(),
                    ' ' => new Room(),
                    'k' => new Room(),
                    '/' => new Door(),
                    var c => throw new ArgumentException($"Caractère inconnu : '{c}'")
                };
            }
        }
    }
}
