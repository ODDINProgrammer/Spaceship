using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CosmicObjectMover : MonoBehaviour
{
    [Header("Speed settings.")]
    [Range(3, 10)][SerializeField] private float _maxSpeed;
    private float _speed;

    private void Awake()
    {
        // Change speed.
        _speed = Random.Range(3, _maxSpeed);
    }

    private void Update()
    {
        MoveObject();
    }

    protected virtual void MoveObject()
    {
        transform.Translate(Vector3.left * _speed * Time.deltaTime);
    }
}
