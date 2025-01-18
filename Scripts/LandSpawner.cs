// Gorney-Alex Dinosaur Game Runner

using System.Collections.Generic;
using UnityEngine;

public class LandSpawner : MonoBehaviour
{
    [SerializeField] private GameObject landPrefab;
    [SerializeField] private float speed = 2f;
    [SerializeField] private float time = 2f;

    private float timer;
    private int maxLands = 7;
    private int segmentLength = 10;

    private List<GameObject> objectList = new List<GameObject>();
    private Vector3 nextSpawnLandPosition = new Vector3(0, 0, 0);

    private void Start()
    {
        timer = time;
        for (int i = 0; i < maxLands; i++)
        {
            if (objectList.Count > 0) 
            {
                nextSpawnLandPosition = objectList[objectList.Count - 1].transform.position + new Vector3(0, 0, -segmentLength); 
            }
            else {
                nextSpawnLandPosition += new Vector3(0, 0, -segmentLength);
            }
            GameObject newSegment = Instantiate(landPrefab, nextSpawnLandPosition, Quaternion.Euler(-90f, 0f, 0f));
            objectList.Add(newSegment);
        }
    }

    private void Update()
    {
        SpawnLands();
        MoveLands();
        DestroyOldLands();
    }

    private void SpawnLands()
    {
        if (timer <= 0f)
        {
            
            if (objectList.Count > 0) 
            {
                nextSpawnLandPosition = objectList[objectList.Count - 1].transform.position + new Vector3(0, 0, -segmentLength); 
            }
            else {
                nextSpawnLandPosition += new Vector3(0, 0, -segmentLength);
            }
            GameObject newSegment = Instantiate(landPrefab, nextSpawnLandPosition, Quaternion.Euler(-90f, 0f, 0f));
            objectList.Add(newSegment);
            timer = time;
        }
        timer -= Time.deltaTime;
    }

    private void MoveLands()
    {
        foreach (GameObject segment in objectList)
        {
            segment.transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
    }

    private void DestroyOldLands()
    {
        while (objectList.Count > maxLands + 2)
        {
            Destroy(objectList[0]);
            objectList.RemoveAt(0);
        }
    }

    public float GetTime()
    {
        return time;
    }

    public float GetSpeed()
    {
        return speed;
    }
}
