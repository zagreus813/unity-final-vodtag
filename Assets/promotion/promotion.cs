using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class promotion : MonoBehaviour
{
    public GameObject bonus;
    int damage = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
 
    }
    public void OnTriggerEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "bonus")
        {
            var hp = collision.gameObject.GetComponent<HP>();
            hp.kamKardan(damage);
            Destroy(gameObject);
            int x = Random.Range(1, 4);
            switch (x)
            {
                case 1:
                    var a = collision.gameObject.GetComponent<shoot>();
                    a.increasedamage();
                    damage += 1;
                    break;
                case 2:
                    var b = collision.gameObject.GetComponent<point>();
                    b.bonusshot();
                    break;
                case 3:


                    break;
            }
        }
    }
}
