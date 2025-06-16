using UnityEngine;

public class PlayerMovement
{
    private float ForceJump = Constants.JUMP_FORCE;

    private Rigidbody _playerRigidbody;

    public PlayerMovement(Rigidbody playerRigidbody)
    {
        _playerRigidbody = playerRigidbody;
    }

    public void Jump()
    {
        _playerRigidbody.AddForce(Vector3.up * ForceJump, ForceMode.Impulse);
    }
}
