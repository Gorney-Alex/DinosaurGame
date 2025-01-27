// Gorney-Alex Dinosaur Game Runner

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speedJump = 5f;
    [SerializeField] private AudioClip jumpSound;
    private Rigidbody playerRigidbody;
    private AudioSource audioSource;
    [SerializeField] private ParticleSystem jumpEffect;

    private bool isGrounded = true;
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            JumpPlayer();
        }
    }

    void JumpPlayer()
    {
        playerRigidbody.AddForce(Vector3.up * speedJump, ForceMode.Impulse);
        isGrounded = false;
        jumpEffect.Stop();

        if (jumpSound != null && audioSource != null)
        {
            audioSource.PlayOneShot(jumpSound);
        }
    }

    void OnCollisionEnter(Collision inputLand)
    {
        if (inputLand.gameObject.CompareTag("Land"))
        {
            isGrounded = true;
            jumpEffect.Play();
        } 
    }
}
