namespace Atelier_1;

public class Wall : Tile
{
    public override bool IsTraversable => false;
    public override ICollectable? Pass() => throw new InvalidOperationException("== IL Y A UN MUR ==");
}