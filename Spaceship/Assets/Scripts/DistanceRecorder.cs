using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DistanceRecorder : MonoBehaviour
{
    private void Update()
    {
        if (GameManager.Instance.GameStarted)
        {
            RecordDistance();
        }
    }

    private void RecordDistance()
    {
        GameManager.Instance.Distance += Time.deltaTime;
    }
}
