using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopGame : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Barricade"))
        {
            Time.timeScale = 0;
            Debug.Log("Game Stopped");
        }
    }
}
