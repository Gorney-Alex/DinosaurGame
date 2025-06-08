using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    [SerializeField] private GameObject[] _landPrefabs = new GameObject[1];
    [SerializeField] private GameObject[] _barricadePrefabs = new GameObject[1];
    private Vector3 _spawnDirection = new Vector3(0f, 0f, 0f);
    private Quaternion _quaternion = Quaternion.Euler(0, 0, 0);
    public const int _landLength = Constants.LAND_LENGTH;

    public void SpawningLandRoad()
    {
        for (int i = 0; i < 10; i++)
        {
            SpawnerObjects.SpawnObjectLand(_landPrefabs[0], _spawnDirection, _quaternion);
            _spawnDirection.z -= _landLength;
        }
    }

    void Awake()
    {
        Debug.Log("Awake");
        SpawningLandRoad();
    }
}
