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

    private float _spawnTime = 2f;

    public void SpawningLandRoad()
    {
        if (ObjectDataBase.landListCount > 0)
        {
            _spawnLandDirection = ObjectDataBase.landListlastObject.transform.position + new Vector3(0f, 0f, -_landLength);
        }
        else
        {
            _spawnLandDirection.z -= _landLength;
        }
        SpawnerObjects.SpawnObject(_landPrefabs[0], _spawnLandDirection, _quaternion);
    }

    public void SpawningBarricades()
    {
        if (ObjectDataBase.BarricadeListCount > 0)
        {
            _spawnLandDirection = ObjectDataBase.BarricadeListLastObject.transform.position + new Vector3(0f, 0f, -_landLength);
        }
        else
        {
            _spawnLandDirection.z -= _landLength;
        }
        SpawnerObjects.SpawnObject(_landPrefabs[0], _spawnLandDirection, _quaternion);
    }

    private void Start()
    {
        StartCoroutine(TimeForSpawnLands());
    }

    IEnumerator TimeForSpawnLands()
    {
        while (true)
        {
            SpawningLandRoad();
            yield return new WaitForSeconds(_spawnTime);
        }
    }
}
