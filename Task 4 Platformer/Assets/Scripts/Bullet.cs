using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float bulletSpeed =20f;
    public Rigidbody2D rb;

    void Start()
    {
        rb.velocity = transform.right * bulletSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //use .ganeObject.tag because just using .tag doesn't work for OnCollisionEnter2D
        if (collision.gameObject.tag == "PlayerOne")
        {
            //Debug.Log("Hit Player One");
            FindObjectOfType<Game_Manager>().HurtPlayerOne();
        }
        else if (collision.gameObject.tag == "PlayerTwo")
        {
            FindObjectOfType<Game_Manager>().HurtPlayerTwo();
        }
        Destroy(this.gameObject);
    }

    private void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}
