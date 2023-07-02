using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
    public float sens = 1.0f;
    Vector2 position;
    float width;
    // Start is called before the first frame update
    void Start()
    {
        width = (float)Screen.width / 2.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            var touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                Vector2 pos = touch.position;
                pos.x = (pos.x - width) / width;
                position = new Vector2(pos.x * sens, transform.position.y);
                transform.position = position;
            }
        }
    }
}
