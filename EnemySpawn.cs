using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public Sprite[] enemySprites; // Array de sprites para os inimigos
    public GameObject cactusPrefabRef; // Refer�ncia ao prefab do inimigo (cacto)

    float interval = 1;  // em segundos - intervalo de tempo entre os spawns
    float instantiateTime = 0; // Tempo de instanciamento do pr�ximo inimigo
    float intervalVariation = 0.5f; // Varia��o no intervalo de tempo entre os spawns

    public bool stopSpawn = false; // Sinalizador para interromper o spawn de inimigos

    void Start()
    {
        // Nenhuma inicializa��o necess�ria neste caso
    }

    // M�todo chamado uma vez por quadro (frame)
    void Update()
    {
        // Verificar se � hora de instanciar um novo inimigo e se o spawn n�o est� interrompido
        if (Time.time > instantiateTime && !stopSpawn)
        {
            // Instanciar um novo objeto inimigo (cacto) na posi��o inicial
            GameObject obj = Instantiate(cactusPrefabRef, new Vector3(5, -1.3f), Quaternion.identity);

            // Alterar o sprite do inimigo para um sprite aleat�rio do array
            obj.GetComponent<SpriteRenderer>().sprite = enemySprites[Random.Range(0, enemySprites.Length)];

            // Adicionar um BoxCollider2D ao objeto inimigo
            obj.AddComponent<BoxCollider2D>();

            // Atualizar o tempo de instanciamento para o pr�ximo spawn com varia��o no intervalo
            instantiateTime = Time.time + Random.Range(interval - intervalVariation, interval + intervalVariation);
        }
    }
}
