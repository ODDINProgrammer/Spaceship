using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshChanger : MonoBehaviour
{
    [SerializeField] private MeshFilter _renderer;
    [SerializeField] private List<Mesh> _meshes;

    private void Awake()
    {
        SetRandomMesh();
    }

    private void SetRandomMesh()
    {
        int index = Random.Range(0, _meshes.Count);
        _renderer.sharedMesh = _meshes[index];
    }
}
