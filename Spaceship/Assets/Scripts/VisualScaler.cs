using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisualScaler : MonoBehaviour
{
    [Header("Scale settings.")]
    [SerializeField] private int _maxScaleMultiplier;

    private void OnEnable()
    {
        // Change size for variaty.
        int scaleMultiplier = Random.Range(1, _maxScaleMultiplier);
        transform.localScale *= scaleMultiplier;
    }
}
