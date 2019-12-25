using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSInput : MonoBehaviour
{
    public float speed = 6.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var deltaX = Input.GetAxis( "Horizontal" ) * speed;
        var deltaZ = Input.GetAxis( "Vertical" ) * speed;
        transform.Translate( deltaX, 0, deltaZ);    
    }
}
