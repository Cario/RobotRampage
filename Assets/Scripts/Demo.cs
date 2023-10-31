using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Demo : MonoBehaviour
{
    void Start() 
    { 
        //create a Dictionary with a String key and int value pairs
        Dictionary<string, int> cityPopulation = new Dictionary<string, int>();
        cityPopulation.Add("Toyko", 38000000);
        cityPopulation.Add("Dehli", 25700000);
        cityPopulation.Add("Shanghai", 23700000);
        cityPopulation.Add("San Paulo", 21100000);
        cityPopulation.Add("Mexico City", 21000000);

        //Read all the data
        Console.WriteLine("City Population");
        foreach(KeyValuePair<string, int> city in cityPopulation)
        {
            UnityEngine.Debug.Log("City: " + city.Key + ", Population: " + city.Value);
        }

        UnityEngine.Debug.Log("Total Number of Cities: " + cityPopulation.Count);
    }
}
