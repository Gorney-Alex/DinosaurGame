using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsForGame : MonoBehaviour
{
    private int points = 0;
    private float time = 2;
    private float timer;
    void Start()
    {
        timer = time;
    }

    void Update()
    {
        if(timer <= 0)
        {
            Debug.Log($"Points: {points}");
            timer = time;
        }
        timer -= Time.deltaTime;
    }

    void OnTriggerEnter(Collider inputpoint)
    {
        if (inputpoint.gameObject.CompareTag("Points"))
        {
            points++;
        } 
    }
}
