//Alex-Gorney programm

using System.Collections.Generic;
using UnityEngine;

public static class ObjectDataBase
{
    private static List<GameObject> _landList = new List<GameObject>();
    private static List<GameObject> _barricadeList = new List<GameObject>();

    public static IReadOnlyList<GameObject> LandList => _landList;
    public static IReadOnlyList<GameObject> BarricadeList => _barricadeList;

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
            Debug.Log($"{worldObjectComponent} add to BarricadeList");
        }
    }

    public static void RemoveInlist(GameObject worldObject)
    {
        WorldObject worldObjectComponent = worldObject.GetComponent<WorldObject>();

        if (worldObjectComponent.Type == ObjectType.Land)
        {
            _landList.Remove(worldObject);
            Debug.Log($"{worldObjectComponent} remove in LandList");
        }
        else if (worldObjectComponent.Type == ObjectType.Barricade)
        {
            _barricadeList.Remove(worldObject);
            Debug.Log($"{worldObjectComponent} remove in BarricadeList");
        }

        Object.Destroy(worldObject);
    }
}