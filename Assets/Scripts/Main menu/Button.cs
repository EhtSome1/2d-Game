using UnityEngine.SceneManagement;
using UnityEngine;

public class Button : MonoBehaviour
{
    public bool game = false;

    void NewGmae()
    {
        SceneManager.LoadScene("game");
    }

    void Start()
    {
        NewGmae();
    }
}
