using UnityEngine;
public class HouseBuilder : ABuildingBuilder
{
    public override void SetName()
    {
        Building.Name = "House";
    }

    public override void SetCost()
    {
        Building.Cost = 10000;
    }

    public override void BuildWalls()
    {
        Building.Walls = Instantiate(Resources.Load<GameObject>("Builder/Wall"));//HouseWalls
    }

    public override void BuildRoof()
    {
        Building.Roof = Instantiate(Resources.Load<GameObject>("Builder/Roof"));//HouseRoof
    }

    public override void BuildWindows()
    {
        Building.Windows = Instantiate(Resources.Load<GameObject>("Builder/Window"));//HouseWindows
    }
}

