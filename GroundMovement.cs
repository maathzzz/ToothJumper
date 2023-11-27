using UnityEngine;

public class GroundMovement : MonoBehaviour
{
    public Sprite[] groundSprites; // Array de sprites para o chão (não utilizado no código fornecido)
    public SpriteRenderer[] grounds; // Array de renderizadores de sprites para os elementos do chão

    public float speed = 5; // Velocidade de movimento do chão

    Vector2 endPosition = new Vector2(-5.91f, -1.85f); // Posição final do chão
    Vector2 startPosition = new Vector2(5.7857f, -1.85f); // Posição inicial do chão

    // Método chamado antes do primeiro quadro (frame) da execução
    void Start()
    {
        // Nenhuma inicialização necessária neste caso
    }

    // Método chamado uma vez por quadro (frame)
    void Update()
    {
        // Iterar sobre os elementos do chão
        for (int i = 0; i < grounds.Length; ++i)
        {
            // Mover o elemento do chão para a esquerda com base na velocidade e no tempo
            grounds[i].transform.position += Vector3.left * speed * Time.deltaTime;

            // Verificar se o elemento do chão atingiu ou ultrapassou a posição final
            if (grounds[i].transform.position.x <= endPosition.x)
            {
                // Reposicionar o elemento do chão para a posição inicial
                grounds[i].transform.position = startPosition;
            }
        }
    }
}
