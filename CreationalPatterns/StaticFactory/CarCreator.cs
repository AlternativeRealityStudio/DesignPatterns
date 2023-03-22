using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCreator : MonoBehaviour
{ 

    void Start()
    {
        Car sportsCar = Car.CreateSportsCar();
        sportsCar.PrintCarDetails();
        Car sedan = Car.CreateSedan();
        sedan.PrintCarDetails();
        Car suv = Car.CreateSUV();
        suv.PrintCarDetails();
    }
 
}
