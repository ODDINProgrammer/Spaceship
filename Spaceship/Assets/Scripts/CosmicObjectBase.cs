using UnityEngine;

public class CosmicObjectBase : MonoBehaviour
{
    [Header("Object settings.")]
    [SerializeField] private int _health;
    private int _currentHealth;

    [Header("Speed settings.")]
    [Range(1, 10)][SerializeField] private float _maxSpeed;
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
        _speed = Random.Range(1, _maxSpeed);

        // Setup HP.
        _currentHealth = _health;
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

    protected virtual void TakeDamage()
    {
        int receivedDamage = SpaceshipController.Instance.Damage;
        print($"Received damage {receivedDamage}");

        _currentHealth -= receivedDamage;

        if(_currentHealth <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    protected virtual void MoveObject()
    {
        transform.Translate(Vector3.left * _speed * Time.deltaTime);
    }
}
