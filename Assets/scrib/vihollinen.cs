using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vihollinen : MonoBehaviour
{

    public Transform target;
    public float distance;
    // Speed in units per sec.
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        distance = Vector3.Distance(target.transform.position, transform.position);

        if (distance < 3)
        {
            speed = -1;
        }
        else
        {
            speed = 1;
        }


        distance = Vector3.Distance(target.transform.position, transform.position);
        //if (target.transform.position.x < transform.position.x)
       
        //else
        


        






        // The step size is equal to speed times frame time.
        float step = speed * Time.deltaTime;

        // Move our position a step closer to the target.
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
    }
}
