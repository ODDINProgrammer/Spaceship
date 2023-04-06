using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CosmicObjectCollisionControllerBase))]
public class Meteorite : CosmicObjectBase, IDamageable
{
    [SerializeField] private CosmicObjectCollisionControllerBase _collisionController;

    private void Awake()
    {
        _collisionController = GetComponent<CosmicObjectCollisionControllerBase>();
    }

    void IDamageable.TakeDamage()
    {
        _collisionController.TakeDamage();
    }
}
