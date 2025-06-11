using System.Collections.Generic;
using UnityEngine;

public static class ObjectList
{
    private static List<GameObject> _landList = new List<GameObject>();
    private static List<GameObject> _barricadeList = new List<GameObject>();

    public static void AddToList(GameObject worldObject)
    {
        WorldObject worldObjectComponent = worldObject.GetComponent<WorldObject>();

        if (worldObjectComponent.Type == ObjectType.Land)
        {
            _landList.Add(worldObject);
            Debug.Log($"{worldObjectComponent} add to LandList");
        }
        else if (worldObjectComponent.Type == ObjectType.Barricade)
        {
            _barricadeList.Add(worldObject);
        }
    }
}