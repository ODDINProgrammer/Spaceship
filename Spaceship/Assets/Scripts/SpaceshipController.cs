using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(SpaceshipShooting))]
public class SpaceshipController : MonoBehaviour
{
    public static SpaceshipController Instance;

    [Header("Accessors")]
    public SpaceshipShooting _shootingController;

    [Header("Death Logic")]
    [SerializeField] private UnityEvent _onPlayerDeath;

    private void Awake()
    {
        Instance = this;

        GlobalEvents._OnPlayerDeath.AddListener(Die);
    }

    private void Die()
    {
        _onPlayerDeath.Invoke();
        AudioManager.Instance.PlaySound(AudioManager.Instance._ExplosionSFX, 1f);
        ParticlesManager.Instance.RenderParticle(ParticlesManager.Instance.explosion, transform.position);
    }
}
