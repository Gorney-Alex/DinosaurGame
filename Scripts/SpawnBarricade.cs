// Gorney-Alex Dinosaur Game Runner

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBarricade : MonoBehaviour
{
    [SerializeField] private GameObject barricadePrefab;

    private List<GameObject> barricadeList = new List<GameObject>();
    private Vector3 nextSpawnBarricadePosition = new Vector3(0, 1.4f, 0);
    private int maxBarricade = 5;
    
    private float speed;
    private float time;
    private float timer;
    LandSpawner speedLands;

    void Start()
    {
        GameObject getSpeedLandSpawner = GameObject.Find("Creatorland");
        speedLands = getSpeedLandSpawner.GetComponent<LandSpawner>();
        time = speedLands.GetTime();
        timer = time;
    }

    void Update()
    {
        speed = speedLands.GetSpeed();
        NextSpawnBarricade();
        MoveBarricades();
        RemoveBarricade(barricadePrefab);
    }

    void NextSpawnBarricade()
    {
        if (timer <= 0f && barricadeList.Count <= maxBarricade)
        {
            int randomIndexLength = Random.Range(10, 20);
            if (barricadeList.Count > 0) 
            {
                nextSpawnBarricadePosition = barricadeList[barricadeList.Count - 1].transform.position + new Vector3(0, 0 , -randomIndexLength); 
            }
            else 
            {
                nextSpawnBarricadePosition += new Vector3(0, 0, -randomIndexLength);
            }

            nextSpawnBarricadePosition.y = 1.4f;
            GameObject newSegment = Instantiate(barricadePrefab, nextSpawnBarricadePosition, Quaternion.Euler(-90f, 0f, 0f));
            barricadeList.Add(newSegment);
            timer = time;
        }
        timer -= Time.deltaTime;
    }

    private void MoveBarricades()
    {
        foreach (GameObject segment in barricadeList)
        {
            segment.transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
    }

    public void RemoveBarricade(GameObject obj)
    {
        if (barricadeList.Contains(obj))
        {
            barricadeList.RemoveAt(0);
        }
    }
}
