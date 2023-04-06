using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [Header("Bullet settings")]
    [SerializeField] private float _speed;

    [Tooltip("Enter a number in seconds after which the game object will selfdestroy.")]
    [SerializeField] private float _selfDestroyTimer;

    [SerializeField] private ObjectType.Type _objectType;
    public ObjectType.Type GetObjectType { private set; get; }

    private void OnEnable()
    {
        StartCoroutine(DelayedDeath(_selfDestroyTimer));
    }

    private void Update()
    {
        MoveBullet();
    }

    private void MoveBullet()
    {
        transform.Translate(Vector3.right * _speed * Time.deltaTime);
    }

    private IEnumerator DelayedDeath(float _seconds)
    {
        yield return new WaitForSeconds(_seconds);
        Destroy(gameObject);
    }

}
