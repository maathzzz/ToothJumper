using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public Sprite[] enemySprites;
    public GameObject cactusPrefabRef;

    float interval = 1;  // em segundos
    float instantiateTime = 0;
    float intervalVariation = 0.5f;

    public bool stopSpawn = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > instantiateTime && !stopSpawn )
        {
            GameObject obj = Instantiate(cactusPrefabRef, new Vector3(5, -1.3f), Quaternion.identity);
            // alterando os sprites dos obstáculos
            obj.GetComponent<SpriteRenderer>().sprite = enemySprites[Random.Range(0, enemySprites.Length)];
            obj.AddComponent<BoxCollider2D>();

            instantiateTime = Time.time + Random.Range(interval - intervalVariation, interval + intervalVariation);
        }   
    }
}
