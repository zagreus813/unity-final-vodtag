using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP2 : MonoBehaviour
{
    public int correntHp2 = 8;
    public GameObject planet;
    public GameObject planet1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var pos = transform.position;
        if (correntHp2 == 0)
        {
            var x = Instantiate(planet, new Vector2(pos.x+0.5f, pos.y), Quaternion.identity);
            x.name = "level1(1)";
            var y = Instantiate(planet1, new Vector2(pos.x-0.5f, pos.y), Quaternion.identity);
            y.name = "level1(1)";
            Destroy(gameObject);

        }
    }
    public void kamKardan(int number)
    {
        correntHp2 -= number;
    }
    
}
