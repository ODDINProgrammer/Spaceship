using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruction : MonoBehaviour
{
    [Tooltip("Enter a number in seconds after which the game object will selfdestroy.")]
    [SerializeField] private float _selfDestroyTimer;

    private void Start()
    {
        StartCoroutine(SelfDestroy(_selfDestroyTimer));
    }

    private IEnumerator SelfDestroy(float _seconds)
    {
        yield return new WaitForSeconds(_seconds);
        Destroy(gameObject);
    }
}
