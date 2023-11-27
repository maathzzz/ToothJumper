using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Biblioteca para gerenciamento de cenas

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] private string levelName; // Nome da cena para iniciar o jogo
    [SerializeField] private GameObject painelMainMenu; // Painel do menu principal
    [SerializeField] private GameObject painelHowToPlay; // Painel de instru��es de jogo
    [SerializeField] private GameObject painelCredits; // Painel de cr�ditos

    // M�todo chamado quando o bot�o de "Jogar" � pressionado
    public void Play()
    {
        // Carregar a cena do jogo
        SceneManager.LoadScene(levelName);
    }

    // M�todo chamado quando o bot�o de "Como Jogar" � pressionado
    public void HowToPlay()
    {
        // Ativar o painel de instru��es de jogo
        painelHowToPlay.SetActive(true);
    }

    // M�todo chamado quando o bot�o de fechar as instru��es de jogo � pressionado
    public void CloseHowToPlay()
    {
        // Desativar o painel de instru��es de jogo
        painelHowToPlay.SetActive(false);
    }

    // M�todo chamado quando o bot�o de "Cr�ditos" � pressionado
    public void ShowCredits()
    {
        // Desativar o painel do menu principal e ativar o painel de cr�ditos
        painelMainMenu.SetActive(false);
        painelCredits.SetActive(true);
    }

    // M�todo chamado quando o bot�o de fechar os cr�ditos � pressionado
    public void CloseShowCredits()
    {
        // Desativar o painel de cr�ditos e ativar o painel do menu principal
        painelCredits.SetActive(false);
        painelMainMenu.SetActive(true);
    }

    // M�todo chamado quando o bot�o de "Sair do Jogo" � pressionado
    public void CloseGame()
    {
        // Imprimir uma mensagem de log e encerrar o aplicativo
        Debug.Log("Sair do Jogo");
        Application.Quit();
    }

    // M�todo chamado quando o bot�o de "Reiniciar Jogo" � pressionado
    public void RestartGame()
    {
        // Imprimir uma mensagem de log e recarregar a cena do jogo
        Debug.Log("Reiniciar Jogo");
        SceneManager.LoadScene(1);
    }

    // M�todo chamado quando o bot�o de "Voltar para o Menu Principal" � pressionado
    public void BackToMainMenu()
    {
        // Carregar a cena do menu principal
        SceneManager.LoadScene(0);
    }
}
