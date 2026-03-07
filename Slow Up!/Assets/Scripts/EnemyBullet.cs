using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
{
    if(collision.gameObject.CompareTag("Player"))
    {
        Rigidbody playerRb = collision.gameObject.GetComponent<Rigidbody>();

        if(playerRb != null)
        {
            playerRb.AddForce(transform.forward * 10f, ForceMode.Impulse);
        }
    }

   
}
}
