public class UnitInfantryFactory
{
    public IUnit GetUnit(int health)
    {
        return new Unit("Infantry", health);
    }
}