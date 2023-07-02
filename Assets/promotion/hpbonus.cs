using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hpbonus : MonoBehaviour
{
    public int correntHp = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (correntHp == 0)
        {
            Destroy(gameObject);
        }
    }
    public void kamKardan(int number)
    {
        correntHp -= number;
    }
}
