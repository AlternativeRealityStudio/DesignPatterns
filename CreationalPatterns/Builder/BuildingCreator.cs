using UnityEngine;

public class BuildingCreator : MonoBehaviour
{
    private BuildingDirector _buildingDirector;
    public GameObject BuildingPrefab;

    void Start()
    {
        _buildingDirector = gameObject.AddComponent<BuildingDirector>();

        CreateHouse();  
        CreateSkyscraper(); 

    }

    public void CreateHouse()
    {
        HouseBuilder houseBuilder = gameObject.AddComponent<HouseBuilder>();
        _buildingDirector.SetBuildingBuilder(houseBuilder);
        _buildingDirector.BuildBuilding();
        InstantiateBuilding();
    }

    public void CreateSkyscraper()
    {
        SkyscraperBuilder skyscraperBuilder = gameObject.AddComponent<SkyscraperBuilder>();
        _buildingDirector.SetBuildingBuilder(skyscraperBuilder);
        _buildingDirector.BuildBuilding();
        InstantiateBuilding();
    }

    private void InstantiateBuilding()
    {
        Building building = _buildingDirector.GetBuilding();
    }
}
