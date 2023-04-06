using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpaceshipShooting))]
public class SpaceshipController : MonoBehaviour
{
    public static SpaceshipController Instance;

    [Header("Accessors")]
    public SpaceshipShooting _shootingController;

    private void Awake()
    {
        Instance = this;
    }

    private void OnDestroy()
    {
        AudioManager.Instance.PlaySound(AudioManager.Instance._ExplosionSFX, 1f);
        ParticlesManager.Instance.RenderParticle(ParticlesManager.Instance.explosion, transform.position);
    }
}
