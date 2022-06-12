using System;
using UnityEngine;

public class PlatformScript : MonoBehaviour
{

    //do not freeze the x-axis


    private float speed;
    private GameManager gameManager;

    private Rigidbody2D platformRB; //this is private
    private float timePassed = 0f;
    private float lifespan = 4f; //the amount of time left before destroyed

    
    void Awake()
    {
        platformRB = GetComponent<Rigidbody2D>();
        // platformRB.transform.localScale = new Vector3(10, 1, 0);
        
    }
    


    void Update()
    {
        speed = FindObjectOfType<GameManager>().getSpeed();
   
        //transform.Translate(new Vector3(-PlayerScript.gameSpeed * Time.deltaTime, 0, 0));
        //speed = displacement / deltaTime, and translation uses displacement
        
        timePassed += Time.deltaTime;
        
        transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
       
        
        if (timePassed > lifespan)
        {
            //Debug.Log("destroy " + this.gameObject);
            Destroy(this.gameObject);
            timePassed = 0f;
        }
        
        // if (PlayerScript.isAlive)
        // {
        //     transform.Translate(Vector2.left * speed * Time.deltaTime);
        //
        //     timePassed += Time.deltaTime;
        //     if (timePassed > lifespan)
        //     {
        //         Debug.Log("destroy " + this.gameObject);
        //         Destroy(this.gameObject);
        //         timePassed = 0f;
        //     }
        // }

    }

}