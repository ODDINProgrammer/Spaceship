using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipController : MonoBehaviour
{
    public static SpaceshipController Instance;

    [Header("Spaceship settings")]
    [SerializeField] private float _speed;              // Makes ship move faster.
    
    [SerializeField] private int _damage;
    public int Damage => _damage;

    [Header("Shooting settings")]
    [SerializeField] private GameObject _bullet;        // Bullet prefab.
    [SerializeField] private Transform _shootPoint;     // Bullet spawn point.

    [Tooltip("Changes interval between shots.")]
    [SerializeField] private float _shootingInterval;
    private float _shootingTimer;

    [SerializeField] private ObjectType.Type _objectType;
    public ObjectType.Type GetObjectType { private set; get; }

    private void Awake()
    {
        Instance = this;
    }

    private void Update()
    {
        if (_shootingTimer < _shootingInterval)
            _shootingTimer += Time.deltaTime;

        CheckInput();
    }

    private void OnDestroy()
    {
        AudioManager.Instance.PlaySound(AudioManager.Instance._ExplosionSFX, 1f);
        ParticlesManager.Instance.RenderParticle(ParticlesManager.Instance.explosion, transform.position);
    }

    private void CheckInput()
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

        // Shooting projectile.
        if (Input.GetKey(KeyCode.Space) && _shootingTimer >= _shootingInterval)
        {
            Instantiate(_bullet, _shootPoint.position, Quaternion.identity);

            AudioManager.Instance.PlaySound(AudioManager.Instance._BlasterSFX, 0.5f);

            _shootingTimer = 0;
        }
    }

}
