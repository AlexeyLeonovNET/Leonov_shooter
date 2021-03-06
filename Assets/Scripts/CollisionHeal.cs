using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHeal : MonoBehaviour
{
    
    public int collisionHeal = 10;
    public string collisionTag;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == collisionTag)
        {
            Health health = collision.gameObject.GetComponent<Health>();
            health.SetHealth(collisionHeal);
            Destroy(gameObject);
        }
    }
}
