using System.Collections.Generic;
using UnityEngine;

public class LandSpawner : MonoBehaviour
{
    [SerializeField] private GameObject landPrefab;
    [SerializeField] private float speed = 1.5f;

    private Vector3 forwardLands = new Vector3(0, 0, 0);
    private Vector3 moveLand = new Vector3(0f, 0f, 1f);
    private List<GameObject> landsPrefabs = new List<GameObject>();

    private float timer = 0;
    private int maxLands = 5;
    private float landLength = 10;

    private GameObject parentObject;

    private void Start()
    {
        parentObject = new GameObject("MainLands");

        timer = speed;
        for (int i = 0; i < maxLands; i++)
        {
            SpawnLandOnce();
        }
    }

    private void Update()
    {
        SpawnLands();
        MoveLand();
        DestroyOldLands();
    }

    private void ResetLevel()
    {
        while (landsPrefabs.Count > 0)
        {
            Destroy(landsPrefabs[0]);
            landsPrefabs.RemoveAt(0);
        }

        for (int i = 0; i < maxLands; i++)
        {
            SpawnLands();
        }
    }

    private void SpawnLandOnce()
    {
        GameObject newSegment = Instantiate(landPrefab, forwardLands, Quaternion.Euler(-90f, 0, 0), parentObject.transform);
        landsPrefabs.Add(newSegment);
        forwardLands += new Vector3(0, 0, -landLength);
    }

    private void SpawnLands()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            GameObject newSegment = Instantiate(landPrefab, forwardLands, Quaternion.Euler(-90f, 0, 0), parentObject.transform);
            landsPrefabs.Add(newSegment);
            forwardLands += new Vector3(0, 0, -landLength);
            timer = speed;
        }
    }

    private void MoveLand()
    {
        parentObject.transform.Translate(moveLand * speed * Time.deltaTime);
    }

    private void DestroyOldLands()
    {
        while (landsPrefabs.Count > maxLands)
        {
            Destroy(landsPrefabs[0]);
            landsPrefabs.RemoveAt(0);
        }
    }
}
