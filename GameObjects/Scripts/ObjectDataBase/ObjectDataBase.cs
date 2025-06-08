using System.Collections.Generic;
using UnityEngine;

public class ObjectList<T> where T : WorldObject
{
    protected List<T> _objects = new List<T>();

    public virtual void AddObjectToList(T obj)
    {
        _objects.Add(obj);
    }

    public List<T> GetAll() => _objects;

    public void ClearList()
    {
        _objects.Clear();
    }
}