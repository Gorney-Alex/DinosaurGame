using System.Collections.Generic;
using UnityEngine;

public static class ObjectDataBase
{
    private static List<GameObject> _landList = new List<GameObject>();
    private static List<GameObject> _barricadeList = new List<GameObject>();

    public static IReadOnlyList<GameObject> GetLandFromList() => _landList.AsReadOnly();
    public static IReadOnlyList<GameObject> GetBarricadeFromList() => _barricadeList.AsReadOnly();

    public static int landListCount => _landList.Count;
    public static int BarricadeListCount => _barricadeList.Count;

    public static GameObject landListlastObject => _landList[_landList.Count - 1];
    public static GameObject BarricadeListLastObject => _barricadeList[_barricadeList.Count - 1];

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
}