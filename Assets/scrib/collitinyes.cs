using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collitinyes : MonoBehaviour
{
    public float hultti = 100f;

    public float helat = 0f;

    public Animator Animator;

    public GameObject hulttibaari;



    // Start is called before the first frame update
    void Start()


    {
        hulttibaari = GameObject.Find("Slider");



        hulttibaari.GetComponent<liukuvaui>().SetMaxHealth(helat);
        helat = hultti;
        Debug.Log("aaaaaaaaaaaa" + helat);
        
    }



    void OnCollisionEnter2D(Collision2D collision)
    {

        helat -= 2;
        Debug.Log("joo");

        Debug.Log("anime");
        if (collision.gameObject.tag == "anime")
        {

            helat -= 2;
            Debug.Log("joo");

            Debug.Log("anime");





        }
    }


    void ded() {

        Animator.SetTrigger("die");
        }



    // Update is called once per frame
    void Update()
    {
        if (helat <= 0)
        {
            ded();
            helat = -2;

        }

        hulttibaari.GetComponent<liukuvaui>().SetMaxHealth(helat);







    }
}
