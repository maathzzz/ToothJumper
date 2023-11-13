using UnityEngine;

public class GroundMovement : MonoBehaviour
{

    public Sprite[] groundSprites;

    public SpriteRenderer[] grounds;

    public float speed = 3;

    Vector2 endPosition = new Vector2(-5.593f, -1.85f);
    Vector2 startPosition = new Vector2(6.214f, -1.85f);

    void Start()
    {

    }

    void Update()
    {

        for (int i = 0; i < grounds.Length; ++i)
        {
            grounds[i].transform.position += Vector3.left * speed * Time.deltaTime;
            if (grounds[i].transform.position.x <= endPosition.x)
            {
                grounds[i].transform.position = startPosition;
                //grounds[i].sprite = groundSprites[Random.Range(0, groundSprites.Length)];
            }
        }

    }


}