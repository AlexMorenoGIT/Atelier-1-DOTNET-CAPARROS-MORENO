using Atelier_1.Collectables;

namespace Atelier_1.Tiles;

public abstract class Tile
{
    public abstract bool IsTraversable { get; }
    public abstract ICollectable? Pass();
}