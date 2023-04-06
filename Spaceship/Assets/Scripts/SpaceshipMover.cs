using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipMover : MonoBehaviour
{
    [Header("Spaceship settings")]
    [SerializeField] private float _speed;  // Makes ship move faster.

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        // Move up.
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * _speed * Time.deltaTime);
        }

        // Move down.
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * _speed * Time.deltaTime);
        }
    }
}
