using Atelier_1.Collectables;

namespace Atelier_1.Tiles;

public sealed class Wall : Tile
{
    public override bool IsTraversable => false;
    public override ICollectable? Pass() => throw new InvalidOperationException("== IL Y A UN MUR ==");
}