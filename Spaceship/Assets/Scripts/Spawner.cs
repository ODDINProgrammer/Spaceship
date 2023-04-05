using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("Objects to spawn")]
    [SerializeField] private List<GameObject> _objects;

    [SerializeField] private float _spawnInterval;
    private float _timer;

    [SerializeField] private int _maxAmountPerSpawn;

    [Tooltip("Controlls range of Y positions for objects.")]
    [SerializeField] private int _maxYDelta;

    private void Update()
    {
        _timer += Time.deltaTime;

        if(_timer >= _spawnInterval)
        {
            Spawn();
            _timer = 0f;
        }
        
    }

    private void Spawn()
    {
        // Decide how much objects will be spawned.
        int randomAmount = Random.Range(1, _maxAmountPerSpawn);
        print($"{randomAmount} will be spawned this time.");

        // Generate objects.
        for(int i = 0; i < randomAmount; i++)
        {
            // Pick random Y position. 
            int posY = Random.Range(-_maxYDelta, _maxYDelta);
            Vector3 objectPos = new Vector3(0, posY, 0) + transform.position;

            Instantiate(_objects[0], objectPos, Quaternion.identity, transform);
        }
    }

}
