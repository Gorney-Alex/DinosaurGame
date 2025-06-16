using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerMovement _playerMovement;
    private Rigidbody _playerRigidbody;

    private bool _isGrounded = true;

    private void Awake()
    {
        _playerRigidbody = GetComponent<Rigidbody>();
        _playerMovement = new PlayerMovement(_playerRigidbody);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _isGrounded)
        {
            _playerMovement.Jump();
            _isGrounded = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(Constants.TAG_LAND))
        {
            _isGrounded = true;
        }
    }
}
