using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerInputReader : MonoBehaviour
{
    private void Update()
    {
        if (GameManager.Instance.IsGameOver)
        {
            ReadInput();
        }
    }

    private void ReadInput()
    {
        print("Pressing space");
        if(Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }   
    }
}
