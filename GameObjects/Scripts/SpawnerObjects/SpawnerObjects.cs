using UnityEngine;

public class SpawnerObjects : MonoBehaviour
{
    public static void SpawnObject(GameObject objectPrefab, Vector3 spawnPosition, Quaternion spawnRotation)
    {
        GameObject newWorldObject = Instantiate(objectPrefab, spawnPosition, spawnRotation);
        ObjectDataBase.AddToList(newWorldObject);
    }
}
