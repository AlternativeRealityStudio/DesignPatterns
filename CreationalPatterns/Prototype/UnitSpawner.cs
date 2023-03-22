using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitSpawner : MonoBehaviour
{
    [SerializeField] private Unit infantryPrototype;
    [SerializeField] private Unit cavalryPrototype;
    [SerializeField] private int numberOfInfantryToSpawn = 5;
    [SerializeField] private int numberOfCavalryToSpawn = 5;

    private IUnitFactory unitFactory;

    private void Awake()
    {
        unitFactory = GetComponent<UnitFactory>();
    }

    private void Start()
    {
        SpawnUnits(infantryPrototype, numberOfInfantryToSpawn);
        SpawnUnits(cavalryPrototype, numberOfCavalryToSpawn);
    }

    private void SpawnUnits(Unit prototype, int numberOfUnits)
    {
        for (int i = 0; i < numberOfUnits; i++)
        {
            Unit newUnit = unitFactory.CreateUnit(prototype);
            newUnit.transform.position = new Vector3(Random.Range(-10f, 10f), 1f, Random.Range(-10f, 10f));
            newUnit.gameObject.SetActive(true);
        }
    }
}
