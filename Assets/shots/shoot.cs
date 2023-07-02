using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    int damage = 1;
    public float firerate = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        var pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        var pos = transform.position;
        pos.y = (pos.y + 0.2f) * firerate;
        transform.position = new Vector2(pos.x, pos.y);
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "level1")
        {
            var hp = collision.gameObject.GetComponent<HP>();
            hp.kamKardan(damage);
            Destroy(gameObject);
        }
        if (collision.gameObject.name == "level2")
        {
            var hp2 = collision.gameObject.GetComponent<HP2>();
            hp2.kamKardan(damage);
            Destroy(gameObject);
        }
        if (collision.gameObject.name == "level3")
        {
            var hp3 = collision.gameObject.GetComponent<HP3>();
            hp3.kamKardan(damage);
            Destroy(gameObject);
        }
    }
}
