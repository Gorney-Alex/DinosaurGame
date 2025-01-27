using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PointsForGame : MonoBehaviour
{

    private int points = 0;
    [SerializeField] TextMeshProUGUI  texyPoints;

    void Start()
    {
        texyPoints.text = $"Points: {points}";
    }

    void OnTriggerEnter(Collider inputpoint)
    {
        if (inputpoint.gameObject.CompareTag("Points"))
        {
            points += 10;
            texyPoints.text = $"Points: {points}";
        } 
    }

    public int GetPoints()
    {
        return points;
    }
}
