using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    Player player;
    EnemySpawn enemySpawn;
    GroundMovement groundMovement;

    bool gameOver = false;

    //public Text scoreText;
    //int score;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Player>();
        enemySpawn = FindObjectOfType<EnemySpawn>();
        groundMovement = FindObjectOfType<GroundMovement>();
        //gameOver = false;

    }

    // Update is called once per frame
    void Update()
    {

        if (!gameOver)
        {

            //score += 100;
            //scoreText.text = score.ToString();

            if (Physics2D.OverlapBoxAll(player.transform.position, Vector2.one * 0.3f, 0, LayerMask.GetMask("Enemy")).Length > 0)
            {
                //Debug.Break();

                Points.stopCounter = true;
                gameOver = true;

                enemySpawn.stopSpawn = true;

                groundMovement.speed = 0;
                Enemy[] allEnemys = FindObjectsOfType<Enemy>();
                foreach (Enemy obj in allEnemys)
                    obj.speed = 0;
            }
        } else
        {
            //gameOver = true;
            SceneManager.LoadScene(2);
        }
        
    }
}
