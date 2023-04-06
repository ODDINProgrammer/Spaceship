using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CosmicObjectCollisionControllerBase : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        switch (other.gameObject.tag)
        {
            case "Player":
                Destroy(other.gameObject);
                break;

            case "Bullet":
                Destroy(other.gameObject);
                TakeDamage();
                break;
        }
    }

    public abstract void TakeDamage();
    }
