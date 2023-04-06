using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipShooting : MonoBehaviour
{
    [Header("Shooting settings")]
    [SerializeField] protected int _damage;
    [SerializeField] private GameObject _bullet;        // Bullet prefab.
    [SerializeField] private Transform _shootPoint;     // Bullet spawn point.
    [Tooltip("Changes interval between shots.")]
    [SerializeField] private float _shootingInterval;
    private float _shootingTimer;


    public int Damage => _damage;

    private void Update()
    {
        _shootingTimer += Time.deltaTime;

        if(_shootingTimer >= _shootingInterval && Input.GetKey(KeyCode.Space))
        {
            Shoot();
        }

    }

    private void Shoot()
    {
        Instantiate(_bullet, _shootPoint.position, Quaternion.identity);

        AudioManager.Instance.PlaySound(AudioManager.Instance._BlasterSFX, 0.5f);

        _shootingTimer = 0;
    }
}
