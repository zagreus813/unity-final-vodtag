using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firingpoint : MonoBehaviour
{
    public GameObject bullet;
    public float dis = 3;
    private float clk;
    public AudioSource audioSource;
    public AudioClip shootingAudioClip;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        clk += Time.deltaTime * 20;
        if( clk > dis )
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
            audioSource.PlayOneShot(shootingAudioClip);
            Instantiate(bullet, new Vector2(pos.x, pos.y), Quaternion.identity);
        }
    }
}
