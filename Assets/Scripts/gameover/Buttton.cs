using UnityEngine.SceneManagement;
using UnityEngine;

public class Buttton : MonoBehaviour
{
    void NewGame()
    {
        SceneManager.LoadScene("game");
    }

    void Start()
    {
        NewGame();
    }
}
