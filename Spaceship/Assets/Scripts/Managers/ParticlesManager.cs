using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticlesManager : MonoBehaviour
{
    public static ParticlesManager Instance;

    [Header("Particles.")]
    public GameObject explosion;
    public GameObject meteoriteExplosion;

    private void Awake()
    {
        Instance = this;
    }

    public void RenderParticle(GameObject _particle, Vector3 _whereToRender)
    {
        Instantiate(_particle, _whereToRender, Quaternion.identity, transform);
    }

}
