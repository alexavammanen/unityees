using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class liiikuhidas2 : MonoBehaviour
{
    private float speed = 19f;
    public float hmovementti = 100f;
    public float ymovementti = 5;
    public Rigidbody2D MyRigidbody2D;
    public bool isGrounded = false;
 
   
    

    public Animator ouranimator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        



        hmovementti = Input.GetAxis("Horizontal");

        ouranimator.SetFloat("kavely", Mathf.Abs(hmovementti));

        if (isGrounded == true)
        {

            if (Input.GetKeyDown(KeyCode.Space))  //makes player jump
            {
                ouranimator.SetTrigger("hyp");
                MyRigidbody2D.AddForce(new Vector2(0, ymovementti), ForceMode2D.Impulse);
            }
        }

        MyRigidbody2D.velocity = new Vector2(hmovementti * speed, MyRigidbody2D.velocity.y);
        if (hmovementti == 1)
        {
            transform.Rotate(Vector3.up * -180);
        }
        if (hmovementti == -1)
        {
            transform.Rotate(Vector3.up * 180);
        }

    }


    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground")
        {
            ouranimator.SetBool("onkomaa", true);
            isGrounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground")
        {
            ouranimator.SetBool("onkomaa", false);
            isGrounded = false;
        }
    }

    private void OnCollisionEnter(Collision c)
    {
        c.transform.parent = gameObject.transform;
    }







}
