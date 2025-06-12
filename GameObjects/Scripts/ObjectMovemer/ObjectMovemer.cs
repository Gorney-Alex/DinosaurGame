using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovemer : MonoBehaviour
{
    private float _speedObject = Constants.SPEEP_OBJECT;
    
    public void MovemerLands()
    {
        foreach (GameObject segment in ObjectDataBase.GetLandFromList())
        {
            segment.transform.Translate(Vector3.forward * _speedObject * Time.deltaTime);
        }
    }
    
    public void Movemerbarricades()
    {
        foreach (GameObject segment in ObjectDataBase.GetBarricadeFromList())
        {
            segment.transform.Translate(Vector3.forward * _speedObject * Time.deltaTime);
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
