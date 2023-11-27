using UnityEngine;

public class Player : MonoBehaviour
{
    // Vetor de velocidade no eixo Y
    Vector2 yVelocity;

    // Altura máxima do pulo
    float maxHeight = 1f;

    // Tempo necessário para atingir a altura máxima do pulo
    float timeToPeak = 0.3f;

    // Velocidade inicial do pulo e gravidade
    float jumpSpeed;
    float gravity;

    // Posição do chão e sinalizador de contato com o chão
    float groundPosition = 0;
    bool isGrounded = false;

    // Método chamado no início
    void Start()
    {
        // Calcular a gravidade e velocidade inicial do pulo com base nos parâmetros fornecidos
        gravity = (2 * maxHeight) / Mathf.Pow(timeToPeak, 2);
        jumpSpeed = gravity * timeToPeak;

        // Armazenar a posição inicial do chão
        groundPosition = transform.position.y;
    }

    // Método chamado a cada quadro
    void Update()
    {
        // Aplicar a gravidade ao vetor de velocidade no eixo Y
        yVelocity += gravity * Time.deltaTime * Vector2.down;

        // Verificar se o jogador atingiu ou está abaixo do chão
        if (transform.position.y <= groundPosition)
        {
            // Reposicionar o jogador no chão, zerar a velocidade no eixo Y e definir o sinalizador de contato com o chão como verdadeiro
            transform.position = new Vector3(transform.position.x, groundPosition, transform.position.z);
            yVelocity = Vector3.zero;
            isGrounded = true;
        }

        // Verificar se a tecla de espaço foi pressionada e o jogador está no chão
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            // Atualizar o sinalizador de contato com o chão para falso e aplicar a velocidade de pulo ao vetor de velocidade no eixo Y
            isGrounded = false;
            yVelocity = jumpSpeed * Vector2.up;
        }

        // Atualizar a posição do jogador com base no vetor de velocidade
        transform.position += (Vector3)yVelocity * Time.deltaTime;
    }
}
