using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Biblioteca para gerenciamento de cenas
using TMPro;

public class GameOverManager : MonoBehaviour
{
    [SerializeField] private string levelName; // Nome da cena para reiniciar o jogo

    public TMP_Text gameOverScore; // Texto para exibir a pontua��o final do jogo
    public TMP_Text bestScoreEver; // Texto para exibir a melhor pontua��o de todos os tempos
    int finalScore; // Pontua��o final do jogador
    int bestScore = 0; // Melhor pontua��o registrada

    void Start()
    {
        // Obter a pontua��o final do jogador armazenada nas prefer�ncias do jogador
        finalScore = PlayerPrefs.GetInt("finalScore");

        // Atualizar a melhor pontua��o se a pontua��o final for maior
        if (finalScore > bestScore)
        {
            bestScore = finalScore;
        }

        // Exibir a pontua��o final e a melhor pontua��o nos textos correspondentes
        gameOverScore.text = finalScore.ToString("D5");
        bestScoreEver.text = bestScore.ToString("D5");
    }

    // M�todo chamado quando o bot�o de rein�cio � pressionado
    public void RestartGame()
    {
        // Carregar a cena do jogo para reiniciar o jogo
        SceneManager.LoadScene(levelName);
    }

    // M�todo chamado quando o bot�o para voltar ao menu principal � pressionado
    public void BackToMainMenu()
    {
        // Carregar a cena do menu principal
        SceneManager.LoadScene(0);
    }
}
