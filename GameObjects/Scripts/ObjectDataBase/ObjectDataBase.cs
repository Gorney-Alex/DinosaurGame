using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ObjectDataBase<T> : MonoBehaviour
{
    static private List<T> _objectList = new List<T>();

    static public void AddObject(T newObject)
    {
        if (newObject == null)
        {
            Debug.LogError("Cannot add a null object to the database.");
            return;
        }

        _objectList.Add(newObject);
    }

    static public void RemoveObject()
    {
        if (_objectList.Count == 0)
        {
            Debug.LogError("Cannot remove an object from an empty database.");
            return;
        }

        _objectList.RemoveAt(0);
    }
}
