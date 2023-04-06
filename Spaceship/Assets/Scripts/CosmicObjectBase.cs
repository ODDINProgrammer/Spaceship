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

    
}
