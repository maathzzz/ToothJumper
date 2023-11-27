using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScrolling : MonoBehaviour
{
    public MeshRenderer mr; // Referência ao componente MeshRenderer que exibe o plano de fundo
    public float speed; // Velocidade de rolagem do plano de fundo

    // Método chamado antes do primeiro quadro (frame) da execução
    void Start()
    {
        // Nenhuma inicialização necessária neste caso
    }

    // Método chamado uma vez por quadro (frame)
    void Update()
    {
        // Atualizar a posição da textura do material do MeshRenderer para criar o efeito de rolagem
        mr.material.mainTextureOffset += new Vector2(speed * Time.deltaTime, 0);
    }
}
