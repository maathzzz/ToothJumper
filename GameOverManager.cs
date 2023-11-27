using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Biblioteca para gerenciamento de cenas
using TMPro;

public class GameOverManager : MonoBehaviour
{
    [SerializeField] private string levelName; // Nome da cena para reiniciar o jogo

    public TMP_Text gameOverScore; // Texto para exibir a pontuação final do jogo
    public TMP_Text bestScoreEver; // Texto para exibir a melhor pontuação de todos os tempos
    int finalScore; // Pontuação final do jogador
    int bestScore = 0; // Melhor pontuação registrada

    void Start()
    {
        // Obter a pontuação final do jogador armazenada nas preferências do jogador
        finalScore = PlayerPrefs.GetInt("finalScore");

        // Atualizar a melhor pontuação se a pontuação final for maior
        if (finalScore > bestScore)
        {
            bestScore = finalScore;
        }

        // Exibir a pontuação final e a melhor pontuação nos textos correspondentes
        gameOverScore.text = finalScore.ToString("D5");
        bestScoreEver.text = bestScore.ToString("D5");
    }

    // Método chamado quando o botão de reinício é pressionado
    public void RestartGame()
    {
        // Carregar a cena do jogo para reiniciar o jogo
        SceneManager.LoadScene(levelName);
    }

    // Método chamado quando o botão para voltar ao menu principal é pressionado
    public void BackToMainMenu()
    {
        // Carregar a cena do menu principal
        SceneManager.LoadScene(0);
    }
}
