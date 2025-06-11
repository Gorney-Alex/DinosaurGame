using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovemer : MonoBehaviour
{
    public void MovemerLands()
    {
        foreach (GameObject segment in ObjectDataBase.GetLandFromList())
        {
            segment.transform.Translate(Vector3.forward * 3 * Time.deltaTime);
        }
    }
    
    public void Movemerbarricades()
    {
        foreach (GameObject segment in ObjectDataBase.GetBarricadeFromList())
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
