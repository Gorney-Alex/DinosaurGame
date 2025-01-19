using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsForGame : MonoBehaviour
{
    private int points = 0;

    void OnTriggerEnter(Collider inputpoint)
    {
        if (inputpoint.gameObject.CompareTag("Points"))
        {
            points += 10;
            Debug.Log($"Points: {points}");
        } 
    }
}
