using UnityEngine;

public class BuildingDirector : MonoBehaviour
{
    private ABuildingBuilder _buildingBuilder;

    public void SetBuildingBuilder(ABuildingBuilder buildingBuilder)
    {
        _buildingBuilder = buildingBuilder;
    }

    public void BuildBuilding()
    {
        _buildingBuilder.CreateNewBuilding();
        _buildingBuilder.SetName();
        _buildingBuilder.SetCost();
        _buildingBuilder.BuildWalls();
        _buildingBuilder.BuildRoof();
        _buildingBuilder.BuildWindows();
    }

    public Building GetBuilding()
    {
        return _buildingBuilder.GetBuilding();
    }
}
