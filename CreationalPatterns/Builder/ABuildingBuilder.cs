using UnityEngine;
 public abstract class ABuildingBuilder:MonoBehaviour
{
    protected Building Building;

    public Building GetBuilding()
    {
        return Building;
    }

    public void CreateNewBuilding()
    {
        Building = new Building();
    }

    public abstract void SetName();
    public abstract void SetCost();
    public abstract void BuildWalls();
    public abstract void BuildRoof();
    public abstract void BuildWindows();
}
