using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    public float speed;
    public float jumpForce;

    private float moveInput;

    private Rigidbody2D rb;

    private bool facingRight = true;

    private bool _isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;

    private int _extraJumps;
    public int extraJumpValue;

    public string jumpButton = "Jump_P1";
    public string horizontalCtrl = "Horizontal_P1";

    public Transform playerPrefab;
    public Transform spawnPoint;


    public void RespawnPlayer()
    {
        transform.position = spawnPoint.position;
    }

    void Start()
    {
        _extraJumps = extraJumpValue;
        rb = GetComponent<Rigidbody2D>();
        RespawnPlayer();
    }



    void FixedUpdate()
    {
        _isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);

        moveInput = Input.GetAxisRaw(horizontalCtrl);
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
        if (facingRight == false && moveInput > 0)
        {
            Flip();
        }
        else if (facingRight == true && moveInput < 0)
        {
            Flip();
        }
    }

    void Update()
    {
        if (_isGrounded == true)
        {
            _extraJumps = extraJumpValue;
        }

        if (Input.GetButtonDown(jumpButton) && _extraJumps > 0)
        {
            rb.velocity = Vector2.up * jumpForce;
            _extraJumps--;
        }
        else if (Input.GetButtonDown(jumpButton) && _extraJumps == 0 && _isGrounded == true)
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        transform.Rotate(0f, 180f, 0f);
    }

}
