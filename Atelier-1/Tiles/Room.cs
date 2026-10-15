using Atelier_1.Collectables;

namespace Atelier_1.Tiles;

public sealed class Room : Tile
{
    private ICollectable? _collectable;
    
    public Room(ICollectable? collectable = null)
    {
        _collectable = collectable;
    }
    
    public override bool IsTraversable => true;

    public override ICollectable? Pass()
    {
        var collectable = _collectable;
        _collectable = null;
        return collectable;
    }
}