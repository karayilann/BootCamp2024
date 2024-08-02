using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    Scene startScene;

    private void Awake()
    {
        startScene = SceneManager.GetActiveScene();
    }

    public void GameScene()
    {
        SceneManager.LoadScene(startScene.buildIndex + 1);
    }
    public void QuitScene()
    {
        Application.Quit();
    }

}
