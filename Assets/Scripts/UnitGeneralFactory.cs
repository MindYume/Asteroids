public class UnitGeneralFactory
{
    public IUnit GetUnit(string type, int health)
    {
        switch(type)
        {
            case "mag":
                UnitMagFactory unitMagFactory = new UnitMagFactory();
                return unitMagFactory.GetUnit(health);
            
            case "infantry":
                UnitInfantryFactory unitInfantryFactory = new UnitInfantryFactory();
                return unitInfantryFactory.GetUnit(health);

            default:
                return new Unit("Mag", health);
        }
    }
}
