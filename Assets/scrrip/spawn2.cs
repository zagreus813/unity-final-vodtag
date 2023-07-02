using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn2 : MonoBehaviour
{
    public Rigidbody2D rigid;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector2(Random.Range(-2, 2), 6f);
        var position = new Vector2(Random.Range(-2, 2), Random.Range(-0.4f, 0));
        rigid.AddForce(position * 2, ForceMode2D.Impulse);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
