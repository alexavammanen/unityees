using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kolikenliike : MonoBehaviour
{
    public float Speed = 10f;

    public GameObject meteor;

    public float hultti = 100f;

    public float helat = 0f;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "anime")
        {
            helat -= 2;
            Debug.Log("joo");


            Debug.Log("ApplyDamage");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        helat = hultti;
        

    }

    // Update is called once per frame
    void Update()
    {
        if (helat <= 0)
        {
            Destroy(gameObject);
            helat = -2;

        }


        transform.position = Vector2.MoveTowards(transform.position, meteor.transform.position, Speed * Time.deltaTime);
        transform.up = meteor.transform.position - transform.position;




    }
}
