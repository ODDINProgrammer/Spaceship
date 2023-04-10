using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class GlobalEvents : MonoBehaviour 
{
    public static UnityEvent _onPlayerDeath = new UnityEvent();

}
