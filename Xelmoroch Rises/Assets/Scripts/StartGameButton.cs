using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameButton : MonoBehaviour
{
    public void GoToScene() {
        SceneManager.LoadScene("Tutorial_Scene");
    }
    public void ExitGame() {
        Application.Quit();
    }

    public void MainMenu() {
        SceneManager.LoadScene("MainMenu");
    }
}
