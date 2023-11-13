using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Lib para gerenciar cenas

public class GameOverManager : MonoBehaviour
{
    [SerializeField] private string levelName;

    public void RestartGame()
    {
        SceneManager.LoadScene(levelName);
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
