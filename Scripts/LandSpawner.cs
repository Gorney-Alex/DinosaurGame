using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandSpawner : MonoBehaviour
{
    [SerializeField] private GameObject landPrefab;
    [SerializeField] private float time = 1.5f;

    private float timer;
    private int maxLands = 4;
    private int segmentLength = 10;

    private List<GameObject> objectList = new List<GameObject>();
    private Vector3 nextSpawnLandPosition = new Vector3(0, 0, -10);

    void Start()
    {
        for (int i = 0; i < maxLands; i++)
        {
            SpawnLands();
        }
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > time)
        {
            DeletLands();
            timer = 0f;
        }
    }

    void SpawnLands()
    {
        GameObject newSegment = Instantiate(landPrefab, nextSpawnLandPosition, Quaternion.Euler(-90f, 0f, 0f));
        objectList.Add(newSegment);
        nextSpawnLandPosition += new Vector3(0, 0, -segmentLength);
    }

    void DeletLands()
    {
        if (objectList.Count > maxLands)
        {
            Destroy(objectList[0]);
            objectList.RemoveAt(0);
        }
        SpawnLands();
    }
}
