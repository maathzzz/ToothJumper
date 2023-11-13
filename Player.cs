using UnityEngine;

public class Player : MonoBehaviour
{

    Vector2 yVelocity;

    float maxHeight = 1f;
    float timeToPeak = 0.3f;

    float jumpSpeed;
    float gravity;

    float groundPosition = 0;
    bool isGrounded = false;

    void Start()
    {

        gravity = (2 * maxHeight) / Mathf.Pow(timeToPeak, 2);
        jumpSpeed = gravity * timeToPeak;

        groundPosition = transform.position.y;
    }

    void Update()
    {

        yVelocity += gravity * Time.deltaTime * Vector2.down;
        if (transform.position.y <= groundPosition)
        {
            transform.position = new Vector3(transform.position.x, groundPosition, transform.position.z);
            yVelocity = Vector3.zero;
            isGrounded = true;
        }

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            isGrounded = false;
            yVelocity = jumpSpeed * Vector2.up;
        }

        transform.position += (Vector3)yVelocity * Time.deltaTime;

    }

}