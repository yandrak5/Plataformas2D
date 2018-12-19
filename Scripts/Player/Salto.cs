using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salto : MonoBehaviour
{

    Rigidbody2D rb;
    Animator anim;
    float jump;
    bool Saltos;
	//bool saltobueno1;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        jump = 5f;
        //saltobueno1 = false;
        Saltos = false;
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
        anim.SetBool("saltobueno1", true);

        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            anim.SetBool("saltobueno1", false);

        }

        //if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began && rb.velocity.y == 0)

            if (Input.GetKeyDown(KeyCode.Space))
            {
            rb.velocity = new Vector2(rb.velocity.x, 10);
            // anim.SetBool("saltobueno1", true);
            //rb.AddForce(Vector2.up * jump, ForceMode2D.Impulse);
            anim.SetBool("saltobueno1", true);
                    }
                 
    }
    //          if (Input.GetTouch(Touch))
    void OnCollisionExit2D(Collision2D b)
    {
        if (b.transform.tag == "suelo")
        {
            print("Suelo");
            Saltos = true;
        }
    }
    void OnCollisionEnter2D(Collision2D c)
    {
        
        if (c.transform.tag == "suelo")
        {
            if (Saltos == true)
            {
                anim.SetBool("saltobueno1", false);
                Saltos = false;
            }
            //if (Input.GetKey(KeyCode.Space) && rb.velocity.y == 0){
            //saltobueno1 = true;
            //else saltobueno1 = false;

            //if (saltobueno1 == false)
            //	anim.SetBool("saltobueno1", false);
            //if (saltobueno1 == true);
            //anim.SetBool("saltobueno1", true);
            //{
            // rb.velocity = new Vector2(rb.velocity.x,7);
            //rb.AddForce(Vector2.up * jump, ForceMode2D.Impulse);
            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began && rb.velocity.y == 0)  {
				rb.velocity = new Vector2(rb.velocity.x,10);
                // anim.SetBool("saltobueno1", true);
                //rb.AddForce(Vector2.up * jump, ForceMode2D.Impulse);
                //anim.SetBool("saltobueno1", true);

            }

        }
    }
}



    
