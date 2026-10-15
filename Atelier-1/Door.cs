namespace Atelier_1;

public class Door : Tile
{
    private readonly Key _key = new();
    private bool _isKeyTaken;
    private bool _isOpen;

    public override bool IsTraversable => _isOpen;

    public override ICollectable? Pass()
    {
        return _isOpen ? null : throw new InvalidOperationException("== PORTE FERMEE ==");
    }

    // Empêche d'ouvrir la porte sans avoir réellement récupéré sa clé : door.Open(door.Key)
    public Key TakeKey()
    {
        if (_isKeyTaken)
        {
            throw new InvalidOperationException("== CLE DEJA PRISE ==");
        }

        _isKeyTaken = true;
        return _key;
    }

    public void Open(Key key)
    {
        CheckKey(key);
        _isOpen = true;
    }

    public void Close(Key key)
    {
        CheckKey(key);
        _isOpen = false;
    }

    private void CheckKey(Key key)
    {
        if (!ReferenceEquals(key, _key))
        {
            throw new ArgumentException("== MAUVAISE CLE ! ==");
        }
    }
}
