using System.Collections;
using UnityEngine;

public class CosmicObjectBase : MonoBehaviour
{
    [Header("Object settings.")]
    [SerializeField] private int _health;
    private int _currentHealth;

    [Tooltip("Enter a number in seconds after which the game object will selfdestroy.")]
    [SerializeField] private float _selfDestroyTimer;

    [Header("Speed settings.")]
    [Range(3, 10)][SerializeField] private float _maxSpeed;
    private float _speed;

    [Header("Scale settings.")]
    [SerializeField] private int _maxScaleMultiplier;

    [SerializeField] private ObjectType.Type _objectType;
    public ObjectType.Type GetObjectType { private set; get; }


    private void OnEnable()
    {
        // Change size for variaty.
        int scaleMultiplier = Random.Range(1, _maxScaleMultiplier);
        transform.localScale *= scaleMultiplier;

        // Change speed.
        _speed = Random.Range(3, _maxSpeed);

        _currentHealth = _health;

        StartCoroutine(SelfDestroy(_selfDestroyTimer));
    }


    private void Update()
    {
        MoveObject();
    }


    private void OnTriggerEnter(Collider other)
    {
        
        switch(other.gameObject.tag)
        {
            case "Player":
                Destroy(other.gameObject);
                break;

            case "Bullet":
                Destroy(other.gameObject);
                TakeDamage();
                break;
        }
    }


    private IEnumerator SelfDestroy(float _seconds)
    {
        yield return new WaitForSeconds(_seconds);
        Destroy(gameObject);
    }


    protected virtual void TakeDamage()
    {
        int receivedDamage = SpaceshipController.Instance.Damage;

        _currentHealth -= receivedDamage;

        if(_currentHealth <= 0)
        {
            AudioManager.Instance.PlaySound(AudioManager.Instance._ExplosionSFX, 1f);
            Destroy(this.gameObject);
        }
    }


    protected virtual void MoveObject()
    {
        transform.Translate(Vector3.left * _speed * Time.deltaTime);
    }
}
