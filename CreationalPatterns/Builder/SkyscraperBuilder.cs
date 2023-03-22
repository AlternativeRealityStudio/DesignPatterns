using UnityEngine;

public class SkyscraperBuilder : ABuildingBuilder
{
    public override void SetName()
    {
        Building.Name = "Skyscraper";
    }

    public override void SetCost()
    {
        Building.Cost = 1000000;
    }

    public override void BuildWalls()
    {
        Building.Walls = Instantiate(Resources.Load<GameObject>("Builder/WallS"));//SkyscraperWalls
    }

    public override void BuildRoof()
    {
        Building.Roof = Instantiate(Resources.Load<GameObject>("Builder/RoofS"));//SkyscraperRoof
    }

    public override void BuildWindows()
    {
        Building.Windows = Instantiate(Resources.Load<GameObject>("Builder/WindowS"));//SkyscraperWindows
    }
}