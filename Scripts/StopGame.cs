using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopGame : MonoBehaviour
{
    private bool gameIsEnded = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Barricade"))
        {
            gameIsEnded = true;
        }
    }

    public bool GetGameIsEnded()
    {
        return gameIsEnded;
    }
}
