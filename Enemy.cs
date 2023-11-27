using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 4; // Velocidade de movimento do inimigo

    // M�todo chamado antes do primeiro quadro (frame) da execu��o
    void Start()
    {
        // Nenhuma inicializa��o necess�ria neste caso
    }

    // M�todo chamado uma vez por quadro (frame)
    void Update()
    {
        // Mover o inimigo para a esquerda com base na velocidade e no tempo
        transform.position += Vector3.left * speed * Time.deltaTime;

        // Verificar se o inimigo atingiu ou ultrapassou a posi��o x de -5
        if (transform.position.x <= -5)
        {
            // Destruir o objeto do inimigo quando estiver fora da tela
            Destroy(gameObject);
        }
    }
}
