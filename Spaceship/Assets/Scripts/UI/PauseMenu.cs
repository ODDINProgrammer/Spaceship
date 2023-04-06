using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject _pauseMenu;

    private void OnEnable()
    {
        GameManager.Instance.ChangePauseState(true);
    }

    private void OnDisable()
    {
        GameManager.Instance.ChangePauseState(false);
    }

    public void OpenPauseMenu()
    {
        _pauseMenu.SetActive(true);
    } 
    
    public void ClosePauseMenu()
    {
        _pauseMenu.SetActive(false);
    }
}
