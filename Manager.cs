using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Manager : MonoBehaviour
{
    Player player;
    EnemySpawn enemySpawn;
    GroundMovement groundMovement;

    bool gameOver = false;

    public TMP_Text scoreText;
    int score;

    // O método Start é chamado antes do primeiro quadro (frame) da execução
    void Start()
    {
        // Encontrar e atribuir referências aos objetos player, enemySpawn e groundMovement na cena
        player = FindObjectOfType<Player>();
        enemySpawn = FindObjectOfType<EnemySpawn>();
        groundMovement = FindObjectOfType<GroundMovement>();
    }

    // O método Update é chamado uma vez a cada quadro (frame)
    void Update()
    {
        // Verificar se o jogo não acabou
        if (!gameOver)
        {
            // Incrementar a pontuação e atualizar a exibição da pontuação
            score += 1;
            scoreText.text = score.ToString("D5");

            // Verificar colisão com inimigos usando uma caixa ao redor da posição do jogador
            if (Physics2D.OverlapBoxAll(player.transform.position, Vector2.one * 0.3f, 0, LayerMask.GetMask("Enemy")).Length > 0)
            {
                // Se houver colisão com inimigos, definir gameOver como true

                gameOver = true;

                // Parar a geração de inimigos
                enemySpawn.stopSpawn = true;

                // Parar o movimento do chão
                groundMovement.speed = 0;

                // Parar o movimento de todos os inimigos na cena
                Enemy[] allEnemys = FindObjectsOfType<Enemy>();
                foreach (Enemy obj in allEnemys)
                    obj.speed = 0;
            }
        }
        else
        {
            // Se o jogo acabou, definir gameOver como true, salvar a pontuação final e carregar a cena de fim de jogo
            gameOver = true;
            PlayerPrefs.SetInt("finalScore", score);
            SceneManager.LoadScene(2);
        }
    }
}
