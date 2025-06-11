using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovemer : MonoBehaviour
{
    public void MovemerLands()
    {
        foreach (GameObject segment in ObjectList.GetLandList())
        {
            segment.transform.Translate(Vector3.forward * 3 * Time.deltaTime);
        }
    }
    
    public void Movemerbarricades()
    {
        foreach (GameObject segment in ObjectList.GetBarricadeList())
        {
            segment.transform.Translate(Vector3.forward * 3 * Time.deltaTime);
        }
    }

    public void MovemerWorldObjects()
    {
        MovemerLands();
        Movemerbarricades();
    }
    void Update()
    {
        MovemerWorldObjects();
    }
}
