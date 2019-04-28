using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunRise : MonoBehaviour
{
    public float Sunrise = 0;
    public float speed = 10;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Sunrise == 360)
        {
            Sunrise = 0;
        }
        Sunrise = Sunrise + 60 * Time.deltaTime;
        gameObject.transform.rotation = Quaternion.Euler(0, 0, Sunrise);
        gameObject.transform.Translate(0, speed * Time.deltaTime,0);


    }
}
