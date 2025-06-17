using UnityEngine;

public class BarricadeLiveController : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(Constants.TAG_PLAYER))
        {
            Player player = other.GetComponent<Player>();
            if (player != null)
            {
                player.TakeDamage(Constants.BARRICADE_DAMAGE);
            }
        }
    }
}
