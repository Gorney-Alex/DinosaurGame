using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDataBase
{
    private List<GameObject> _landList = new List<GameObject>();
    private List<GameObject> _barricadeList = new List<GameObject>();

    public void AddLandObject(GameObject obj)
    {
        if (obj == null)
        {
            Debug.LogError("Cannot add null object.");
            return;
        }
        _landList.Add(obj);
    }

    
    public void AddBarricadeObject(GameObject obj)
    {
        if (obj == null)
        {
            Debug.LogError("Cannot add null object.");
            return;
        }
        _barricadeList.Add(obj);
    }
}

