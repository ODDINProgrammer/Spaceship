using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [Header("Bullet settings")]
    [SerializeField] private float _speed;

    [Tooltip("Enter a number in seconds after which the game object will selfdestroy.")]
    [SerializeField] private float _selfDestroyTimer;

    private void Update()
    {
        MoveBullet();
    }

    private void MoveBullet()
    {
        transform.Translate(Vector3.right * _speed * Time.deltaTime);
    }
}
