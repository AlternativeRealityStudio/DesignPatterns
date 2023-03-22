using UnityEngine;

public class Car : MonoBehaviour
{

    private string make;
    private string model;
    private int topSpeed;

    private Car(string make, string model, int topSpeed)
    {
        this.make = make;
        this.model = model;
        this.topSpeed = topSpeed;
    }

    public static Car CreateSportsCar()
    {
        GameObject carGameObject = new GameObject("Sports Car");
        Car car = carGameObject.AddComponent<Car>();
        car.make = "Ferrari";
        car.model = "XXX";
        car.topSpeed = 330;
        return car;
    }

    public static Car CreateSedan()
    {
        GameObject carGameObject = new GameObject("Sedan");
        Car car = carGameObject.AddComponent<Car>();
        car.make = "Toyota";
        car.model = "XXX";
        car.topSpeed = 210;
        return car;
    }

    public static Car CreateSUV()
    {
        GameObject carGameObject = new GameObject("SUV");
        Car car = carGameObject.AddComponent<Car>();
        car.make = "Ford";
        car.model = "XXX";
        car.topSpeed = 180;
        return car;
    } 
    public void PrintCarDetails()
    {
        Debug.Log("Make: " + make + ", Model: " + model + ", Top Speed: " + topSpeed);
    }
}
