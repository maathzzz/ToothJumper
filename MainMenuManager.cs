using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Biblioteca para gerenciamento de cenas

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] private string levelName; // Nome da cena para iniciar o jogo
    [SerializeField] private GameObject painelMainMenu; // Painel do menu principal
    [SerializeField] private GameObject painelHowToPlay; // Painel de instruções de jogo
    [SerializeField] private GameObject painelCredits; // Painel de créditos

    // Método chamado quando o botão de "Jogar" é pressionado
    public void Play()
    {
        // Carregar a cena do jogo
        SceneManager.LoadScene(levelName);
    }

    // Método chamado quando o botão de "Como Jogar" é pressionado
    public void HowToPlay()
    {
        // Ativar o painel de instruções de jogo
        painelHowToPlay.SetActive(true);
    }

    // Método chamado quando o botão de fechar as instruções de jogo é pressionado
    public void CloseHowToPlay()
    {
        // Desativar o painel de instruções de jogo
        painelHowToPlay.SetActive(false);
    }

    // Método chamado quando o botão de "Créditos" é pressionado
    public void ShowCredits()
    {
        // Desativar o painel do menu principal e ativar o painel de créditos
        painelMainMenu.SetActive(false);
        painelCredits.SetActive(true);
    }

    // Método chamado quando o botão de fechar os créditos é pressionado
    public void CloseShowCredits()
    {
        // Desativar o painel de créditos e ativar o painel do menu principal
        painelCredits.SetActive(false);
        painelMainMenu.SetActive(true);
    }

    // Método chamado quando o botão de "Sair do Jogo" é pressionado
    public void CloseGame()
    {
        // Imprimir uma mensagem de log e encerrar o aplicativo
        Debug.Log("Sair do Jogo");
        Application.Quit();
    }

    // Método chamado quando o botão de "Reiniciar Jogo" é pressionado
    public void RestartGame()
    {
        // Imprimir uma mensagem de log e recarregar a cena do jogo
        Debug.Log("Reiniciar Jogo");
        SceneManager.LoadScene(1);
    }

    // Método chamado quando o botão de "Voltar para o Menu Principal" é pressionado
    public void BackToMainMenu()
    {
        // Carregar a cena do menu principal
        SceneManager.LoadScene(0);
    }
}
