//Alex-Gorney programm

using UnityEngine;

public static class SpawnerObjects
{
    public static void SpawnObject(GameObject objectPrefab, Vector3 spawnPosition, Quaternion spawnRotation)
    {
        GameObject newWorldObject = Object.Instantiate(objectPrefab, spawnPosition, spawnRotation);
        ObjectDataBase.AddToList(newWorldObject);
    }
}
