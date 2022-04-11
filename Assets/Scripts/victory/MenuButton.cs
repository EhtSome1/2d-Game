using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuButton : MonoBehaviour
{
    void NewGame()
    {
        SceneManager.LoadScene("MainMenu");
    }

    void Start()
    {
        NewGame();
    }
}
