using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScrolling : MonoBehaviour
{
    public MeshRenderer mr; // Refer�ncia ao componente MeshRenderer que exibe o plano de fundo
    public float speed; // Velocidade de rolagem do plano de fundo

    // M�todo chamado antes do primeiro quadro (frame) da execu��o
    void Start()
    {
        // Nenhuma inicializa��o necess�ria neste caso
    }

    // M�todo chamado uma vez por quadro (frame)
    void Update()
    {
        // Atualizar a posi��o da textura do material do MeshRenderer para criar o efeito de rolagem
        mr.material.mainTextureOffset += new Vector2(speed * Time.deltaTime, 0);
    }
}
