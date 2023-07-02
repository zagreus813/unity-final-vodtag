using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class petshoot : MonoBehaviour
{
    public float firerate = 5f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var pos = transform.position;
        transform.Translate((transform.up * firerate * Time.deltaTime));
        if (transform.position.y > 5 && gameObject.name == "clonedbullet1")
        {
            Destroy(gameObject);
        }
    }
}
