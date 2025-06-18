//Alex-Gorney programm

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructionWall : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameObject otherObject = other.gameObject;
        Debug.Log(otherObject);
        ObjectDataBase.RemoveInlist(otherObject);
    }
}
