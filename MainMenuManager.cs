using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Lib para gerenciar cenas

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] private string levelName;
    [SerializeField] private GameObject painelMainMenu;
    [SerializeField] private GameObject painelHowToPlay;
    [SerializeField] private GameObject painelCredits;

    public void Play()
    {
        SceneManager.LoadScene(levelName);
    }

    public void HowToPlay()
    {
        painelHowToPlay.SetActive(true);
    }

    public void CloseHowToPlay()
    {
        painelHowToPlay.SetActive(false);
    }

    public void ShowCredits()
    {
        painelMainMenu.SetActive(false);
        painelCredits.SetActive(true);
    }

    public void CloseShowCredits()
    {
        painelCredits.SetActive(false);
        painelMainMenu.SetActive(true);
    }

    public void CloseGame()
    {
        Debug.Log("Sair do Jogo");
        Application.Quit();
    }

    public void RestartGame()
    {
        Debug.Log("Sair do Jogo");
        SceneManager.LoadScene(1);
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
