// Gorney-Alex Dinosaur Game Runner

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheWall : MonoBehaviour
{
    private LandSpawner landSpawner;

    private SpawnBarricade barricadeSpawner;

    private void Start()
    {
        landSpawner = FindObjectOfType<LandSpawner>();
        barricadeSpawner = FindObjectOfType<SpawnBarricade>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Land"))
        {
            Destroy(other.gameObject);

            if (landSpawner != null)
            {
                landSpawner.RemoveObject(other.gameObject);
            }
        }

        if (other.CompareTag("Barricade"))
        {
            Destroy(other.gameObject);

            if (barricadeSpawner != null)
            {
                barricadeSpawner.RemoveBarricade(other.gameObject);
            }
        }
    }
}
