using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speedJump = 5f;
    private Rigidbody playerRigidbody;
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            JumpPlayer();
        }
    }

    void JumpPlayer()
    {
        playerRigidbody.AddForce(Vector3.up * speedJump, ForceMode.Impulse);
    }
}
