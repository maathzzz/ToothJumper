using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public Sprite[] enemySprites; // Array de sprites para os inimigos
    public GameObject cactusPrefabRef; // Referência ao prefab do inimigo (cacto)

    float interval = 1;  // em segundos - intervalo de tempo entre os spawns
    float instantiateTime = 0; // Tempo de instanciamento do próximo inimigo
    float intervalVariation = 0.5f; // Variação no intervalo de tempo entre os spawns

    public bool stopSpawn = false; // Sinalizador para interromper o spawn de inimigos

    void Start()
    {
        // Nenhuma inicialização necessária neste caso
    }

    // Método chamado uma vez por quadro (frame)
    void Update()
    {
        // Verificar se é hora de instanciar um novo inimigo e se o spawn não está interrompido
        if (Time.time > instantiateTime && !stopSpawn)
        {
            // Instanciar um novo objeto inimigo (cacto) na posição inicial
            GameObject obj = Instantiate(cactusPrefabRef, new Vector3(5, -1.3f), Quaternion.identity);

            // Alterar o sprite do inimigo para um sprite aleatório do array
            obj.GetComponent<SpriteRenderer>().sprite = enemySprites[Random.Range(0, enemySprites.Length)];

            // Adicionar um BoxCollider2D ao objeto inimigo
            obj.AddComponent<BoxCollider2D>();

            // Atualizar o tempo de instanciamento para o próximo spawn com variação no intervalo
            instantiateTime = Time.time + Random.Range(interval - intervalVariation, interval + intervalVariation);
        }
    }
}
