using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBarricade : MonoBehaviour
{
    [SerializeField] private GameObject barricadePrefab;

    private List<GameObject> barricadeList = new List<GameObject>();
    private Vector3 nextSpawnBarricadePosition = new Vector3(0, 1.4f, 0); // Устанавливаем начальную ось Y

    private int maxBarricades = 5;

    private float barricadeLength = 10f;
    private float speed;
    private float time;
    private float timer;

    void Start()
    {
        GameObject getSpeedLandSpawner = GameObject.Find("Creatorland");
        LandSpawner speedLands = getSpeedLandSpawner.GetComponent<LandSpawner>();
        speed = speedLands.GetSpeed();
        time = speedLands.GetTime();
        timer = time;
    }

    void Update()
    {
        NextSpawnBarricade();
        MoveBarricades();
        DestroyOldBarricades();
    }

    void NextSpawnBarricade()
    {
        if (timer <= 0f)
        {
            if (barricadeList.Count > 0) 
            {
                nextSpawnBarricadePosition = barricadeList[barricadeList.Count - 1].transform.position + new Vector3(0, 0 , -barricadeLength); 
            }
            else 
            {
                nextSpawnBarricadePosition += new Vector3(0, 0, -barricadeLength);
            }

            // Устанавливаем ось Y равной 1.4
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

            // Устанавливаем ось Y равной 1.4
            Vector3 currentPosition = segment.transform.position;
            segment.transform.position = new Vector3(currentPosition.x, 1.4f, currentPosition.z);
        }
    }

    private void DestroyOldBarricades()
    {
        while (barricadeList.Count > maxBarricades)
        {
            Destroy(barricadeList[0]);
            barricadeList.RemoveAt(0);
        }
    }
}
