using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 0.5f;
    private Vector3 moveVector = new Vector3 (0, 0, -1);

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        rb.MovePosition(rb.position + moveVector * speed * Time.deltaTime);
    }

}
