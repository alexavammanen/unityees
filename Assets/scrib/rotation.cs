using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{

    public int yes = 1; 

        
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Q))
        {
            yes = (yes - 1);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
           yes =(yes + 1);
        }
        transform.Rotate(Vector3.forward * yes);

    }




}
