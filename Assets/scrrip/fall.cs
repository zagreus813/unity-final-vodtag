using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fall : MonoBehaviour
{
    public GameObject b;
    private float time;
    public static int numberOfBall = 1;
    // Start is called before the first frame update
    void Start()
    {
        time = 6;

    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        if (time <= 0 && numberOfBall < 6)
        {
            var newLevel1 = Instantiate(b, new Vector2(0, 6), Quaternion.identity);
            newLevel1.name = "level1";
            time = Random.Range(8, 16);
            numberOfBall++;
        }
    }
}
