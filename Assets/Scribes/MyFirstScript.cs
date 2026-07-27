using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int i = 3;
        i += 5;
        i -= 2;
        i /= 3;
        bool b = (i <= 2) && (i == 2);

        Debug.Log(b);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
