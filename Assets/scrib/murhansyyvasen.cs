using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class murhansyyvasen : MonoBehaviour
{

    

    public Animator ouranimator;


    public bool blocked = false;
    public bool k = false;
    public bool l = false;
    public bool potku = false;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            ouranimator.SetTrigger("pahoinpitelyvasen");

            potku = true;
        }

        if (Input.GetButtonDown("Fire2"))
        {
            ouranimator.SetTrigger("jalkapaiva");
            k = true;

           

            

        }

        if (Input.GetButtonDown("Fire3"))
        {
            ouranimator.SetTrigger("potku3");
            l = true;

        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            ouranimator.SetTrigger("block");
            blocked = true;

        }

        if (Input.GetKeyUp(KeyCode.F))
        {
            ouranimator.SetTrigger("block");
            blocked = false;

        }

        if (Input.GetButtonUp("Fire3"))
        {
            ouranimator.SetTrigger("potku3");
            l = false;

        }

        if (Input.GetButtonUp("Fire2"))
        {
            ouranimator.SetTrigger("jalkapaiva");
            k = false;

        }



    
   






    }
}
