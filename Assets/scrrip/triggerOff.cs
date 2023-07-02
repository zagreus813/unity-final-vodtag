using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerOff : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        GameObject ball = GameObject.FindGameObjectWithTag("ball");
        Physics2D.IgnoreCollision(ball.GetComponent<CircleCollider2D>(), GetComponent<CircleCollider2D>());
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ball"))
        {
            Physics2D.IgnoreCollision(collision.gameObject.GetComponent<CircleCollider2D>(), GetComponent<CircleCollider2D>());

        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ball"))
        {
            Physics2D.IgnoreCollision(collision.gameObject.GetComponent<CircleCollider2D>(), GetComponent<CircleCollider2D>());

        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ball"))
        {
            Physics2D.IgnoreCollision(collision.gameObject.GetComponent<CircleCollider2D>(), GetComponent<CircleCollider2D>());

        }
    }
}
