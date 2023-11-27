using UnityEngine;

public class Player : MonoBehaviour
{
    // Vetor de velocidade no eixo Y
    Vector2 yVelocity;

    // Altura m�xima do pulo
    float maxHeight = 1f;

    // Tempo necess�rio para atingir a altura m�xima do pulo
    float timeToPeak = 0.3f;

    // Velocidade inicial do pulo e gravidade
    float jumpSpeed;
    float gravity;

    // Posi��o do ch�o e sinalizador de contato com o ch�o
    float groundPosition = 0;
    bool isGrounded = false;

    // M�todo chamado no in�cio
    void Start()
    {
        // Calcular a gravidade e velocidade inicial do pulo com base nos par�metros fornecidos
        gravity = (2 * maxHeight) / Mathf.Pow(timeToPeak, 2);
        jumpSpeed = gravity * timeToPeak;

        // Armazenar a posi��o inicial do ch�o
        groundPosition = transform.position.y;
    }

    // M�todo chamado a cada quadro
    void Update()
    {
        // Aplicar a gravidade ao vetor de velocidade no eixo Y
        yVelocity += gravity * Time.deltaTime * Vector2.down;

        // Verificar se o jogador atingiu ou est� abaixo do ch�o
        if (transform.position.y <= groundPosition)
        {
            // Reposicionar o jogador no ch�o, zerar a velocidade no eixo Y e definir o sinalizador de contato com o ch�o como verdadeiro
            transform.position = new Vector3(transform.position.x, groundPosition, transform.position.z);
            yVelocity = Vector3.zero;
            isGrounded = true;
        }

        // Verificar se a tecla de espa�o foi pressionada e o jogador est� no ch�o
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            // Atualizar o sinalizador de contato com o ch�o para falso e aplicar a velocidade de pulo ao vetor de velocidade no eixo Y
            isGrounded = false;
            yVelocity = jumpSpeed * Vector2.up;
        }

        // Atualizar a posi��o do jogador com base no vetor de velocidade
        transform.position += (Vector3)yVelocity * Time.deltaTime;
    }
}
