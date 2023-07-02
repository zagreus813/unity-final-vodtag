using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class petfiringpoint : MonoBehaviour
{
    public GameObject bullet1;
    public float dis = 3;
    private float clk;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        clk += Time.deltaTime * 20;
        if (clk > dis)
        {
            func();
            clk -= dis;
        }
    }
    void func()
    {
        var pos = transform.position;
        if (Input.touchCount > 0)
        {
            var n = Instantiate(bullet1, new Vector2(pos.x, pos.y), Quaternion.identity);
            n.name = "clonedbullet1";
        }
    }
}