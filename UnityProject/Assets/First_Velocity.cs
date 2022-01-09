using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class First_Velocity : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //	rigidbody.velocity = new Vector3 (0.0f,2.0f,0.0f);
        GetComponent<Rigidbody>().velocity = new Vector3(0.0f, 2.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
