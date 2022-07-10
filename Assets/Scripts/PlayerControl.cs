using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField]private float moveSpeed;
    [SerializeField] private float jumpHeight;
    [SerializeField] private float AirMoveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            if (rb.velocity.x != -moveSpeed)
            {
                rb.AddForce(new Vector2(-moveSpeed * Time.deltaTime, 0));
            }
        }
                else if (Input.GetKey(KeyCode.A))
                {
                    if (rb.velocity.x != -AirMoveSpeed)
                    {
                        rb.AddForce(new Vector2(-AirMoveSpeed, 0));
                    }
                }

        if (Input.GetKey(KeyCode.D))
        {
            if (rb.velocity.x != moveSpeed)
            {
                rb.AddForce(new Vector2(moveSpeed * Time.deltaTime, 0));
            }
        }
                else if (Input.GetKey(KeyCode.D))
                {
                    if (rb.velocity.x != AirMoveSpeed)
                    {
                        rb.AddForce(new Vector2(AirMoveSpeed, 0));
                    }
                }
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(new Vector2(0, jumpHeight), ForceMode2D.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector2(0, jumpHeight), ForceMode2D.Impulse);
        }
    }
}
