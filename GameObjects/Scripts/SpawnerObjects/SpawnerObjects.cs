using UnityEngine;

public class SpawnerObjects : MonoBehaviour
{
    public static void SpawnObjectLand(GameObject objectPrefab, Vector3 spawnPosition, Quaternion spawnRotation)
    {
        GameObject newWorldObject = Instantiate(objectPrefab, spawnPosition, spawnRotation);
        ObjectDataBase.AddObject(newWorldObject);
    }

    public static void SpawnObjectBarricade(GameObject objectPrefab, Vector3 spawnPosition, Quaternion spawnRotation)
    {
        GameObject newWorldObject = Instantiate(objectPrefab, spawnPosition, spawnRotation);
        ObjectBarricadeData.AddObject(newWorldObject);
    }
}
