using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    [SerializeField] private GameObject[] _landPrefabs = new GameObject[1];
    [SerializeField] private GameObject[] _barricadePrefabs = new GameObject[1];
    private Vector3 _spawnLandDirection = new Vector3(0f, 0f, 0f);
    private Vector3 _spawnBarricadeDirection = new Vector3(0f, 0f, 0f);
    private Quaternion _quaternion = Quaternion.Euler(0, 0, 0);
    public const int _landLength = Constants.LAND_LENGTH;

    public void SpawningLandRoad()
    {
        for (int i = 0; i < 10; i++)
        {
            SpawnerObjects.SpawnObject(_landPrefabs[0], _spawnLandDirection, _quaternion);
            _spawnLandDirection.z -= _landLength;
        }
    }

    public void SpawningBarricades()
    {
        for (int i = 0; i < 10; i++)
        {
            SpawnerObjects.SpawnObject(_barricadePrefabs[0], _spawnBarricadeDirection, _quaternion);
            _spawnBarricadeDirection.z -= _landLength;
        }
    }

    void Awake()
    {
        Debug.Log("Awake");
        SpawningLandRoad();
        SpawningBarricades();
    }
}
