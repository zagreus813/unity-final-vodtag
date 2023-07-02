using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP3 : MonoBehaviour
{
    public int correntHp3 = 16;
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
        if (correntHp3 <= 0)
        {
            var x = Instantiate(planet, new Vector2(pos.x + 0.5f, pos.y), Quaternion.identity);
            x.name = "level2";
            var y = Instantiate(planet1, new Vector2(pos.x - 0.5f, pos.y), Quaternion.identity);
            y.name = "level2";
            Destroy(gameObject);

        }
    }
    public void kamKardan(int number)
    {
        correntHp3 -= number;
    }
    
    


}
