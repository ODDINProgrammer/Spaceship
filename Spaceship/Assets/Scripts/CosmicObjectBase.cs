using System.Collections;
using UnityEngine;

public class CosmicObjectBase : MonoBehaviour
{
    [Header("Object settings.")]
    [SerializeField] protected int _health;

    public int Health 
    { 
        get { return _health; }
        set { _health = value; }
    }

    //[Header("Scale settings.")]
    //[SerializeField] private int _maxScaleMultiplier;

    //private void OnEnable()
    //{
    //    // Change size for variaty.
    //    int scaleMultiplier = Random.Range(1, _maxScaleMultiplier);
    //    transform.localScale *= scaleMultiplier;

    //    _currentHealth = _health;
    //}


    //}
}
