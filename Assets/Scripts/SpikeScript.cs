using UnityEngine;

public class SpikeScript : MonoBehaviour
{

    //do not freeze the x-axis
    //spike has tag of enemy instead of spike in unity
    
    private Rigidbody2D spikeRb; //this is private
    private float timePassed = 0f;
    private float lifespan = 4f; //the amount of time left before destroyed
    
    void Start()
    {
        spikeRb = GetComponent<Rigidbody2D>();
        spikeRb.transform.localScale = new Vector3(2, 2, 0); //rescales the spike
    }
    
    
    void Update()
    {
        
        spikeRb.velocity = new Vector2(-15f, 0);

        timePassed += Time.deltaTime;
        if (timePassed > lifespan)
        {
            Debug.Log("destroy " + this.gameObject);
            Destroy(this.gameObject);
            timePassed = 0f;
        }
        
        // if (PlayerScript.isAlive)
        // {
        //     spikeRb.velocity = new Vector2(-15f, 0);
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
