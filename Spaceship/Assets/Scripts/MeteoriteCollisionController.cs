using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteoriteCollisionController : CosmicObjectCollisionControllerBase
{
    private CosmicObjectBase _meteorite;

    private void Awake()
    {
        _meteorite = GetComponent<Meteorite>();    
    }

    override public void TakeDamage() 
    {
        print("Damage registred!!!");
        int receivedDamage = SpaceshipController.Instance._shootingController.Damage;

        _meteorite.Health -= receivedDamage;

        if(_meteorite.Health <= 0)
        {
            AudioManager.Instance.PlaySound(AudioManager.Instance._ExplosionSFX, 1f);
            ParticlesManager.Instance.RenderParticle(ParticlesManager.Instance.meteoriteExplosion, transform.position);
            Destroy(gameObject);
        }
    }
}
