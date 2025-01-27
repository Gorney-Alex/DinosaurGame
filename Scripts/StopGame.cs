// Gorney-Alex Dinosaur Game Runner


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopGame : MonoBehaviour
{
    private AudioSource audioSource;
    private bool gameIsEnded = false;

private void Start()
{
    audioSource = GetComponent<AudioSource>();
}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Barricade"))
        {
            gameIsEnded = true;
            audioSource.Stop();
        }
    }

    public bool GetGameIsEnded()
    {
        return gameIsEnded;
    }
}
