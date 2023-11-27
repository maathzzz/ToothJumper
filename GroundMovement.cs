using UnityEngine;

public class GroundMovement : MonoBehaviour
{
    public Sprite[] groundSprites; // Array de sprites para o ch�o (n�o utilizado no c�digo fornecido)
    public SpriteRenderer[] grounds; // Array de renderizadores de sprites para os elementos do ch�o

    public float speed = 5; // Velocidade de movimento do ch�o

    Vector2 endPosition = new Vector2(-5.91f, -1.85f); // Posi��o final do ch�o
    Vector2 startPosition = new Vector2(5.7857f, -1.85f); // Posi��o inicial do ch�o

    // M�todo chamado antes do primeiro quadro (frame) da execu��o
    void Start()
    {
        // Nenhuma inicializa��o necess�ria neste caso
    }

    // M�todo chamado uma vez por quadro (frame)
    void Update()
    {
        // Iterar sobre os elementos do ch�o
        for (int i = 0; i < grounds.Length; ++i)
        {
            // Mover o elemento do ch�o para a esquerda com base na velocidade e no tempo
            grounds[i].transform.position += Vector3.left * speed * Time.deltaTime;

            // Verificar se o elemento do ch�o atingiu ou ultrapassou a posi��o final
            if (grounds[i].transform.position.x <= endPosition.x)
            {
                // Reposicionar o elemento do ch�o para a posi��o inicial
                grounds[i].transform.position = startPosition;
            }
        }
    }
}
