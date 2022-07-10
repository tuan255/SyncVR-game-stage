using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class next : MonoBehaviour
{
    public void nextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        nextScene();
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
