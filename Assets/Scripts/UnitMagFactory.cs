public class UnitMagFactory
{
    public IUnit GetUnit(int health)
    {
        return new Unit("Mag", health);
    }
}
