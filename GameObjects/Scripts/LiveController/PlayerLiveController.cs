using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLiveController : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(Constants.TAG_BARRICADE))
        {
            Player player = other.GetComponent<Player>();
            if (player != null)
            {
                player.TakeDamage(Constants.BARRICADE_DAMAGE);
            }
        }
    }
}
