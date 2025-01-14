using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopGameMoment : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Barricade"))
        {
            Time.timeScale = 0;
            Debug.Log("Game Stopped");
        }
    }

}
