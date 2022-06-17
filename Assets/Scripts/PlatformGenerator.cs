using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : GeneratorAbstract
    //this extends GeneratorAbstract class^
{
    private float interval = 1f;
    private float timePassed = 0f;
    private Vector3 spawnVector;

    //drag extra platform prefabs into this array field in the Unity GUI
    [SerializeField]
    private Transform[] platformArray = new Transform[7];


    private void Update()
    {
        timePassed += Time.deltaTime;

        if (timePassed > interval)
        {
            platformGeneration();
            timePassed = 0f;
        }

        print(platformArray[1]);
         print(platformArray[2]);
          print(platformArray[3]);
           print(platformArray[4]);
            print(platformArray[5]); 
             print(platformArray[6]);

         
        
        
        // if (PlayerScript.isAlive)
        // {
        //     timePassed += Time.deltaTime;
        //
        //     if (timePassed > interval)
        //     {
        //         platformGeneration();
        //         timePassed = 0f;
        //     }
        // }

    }

    private void platformGeneration()
        //a method that handles platform prefabs
    {
        //randomly selects the platform to spawn
        int randInt = UnityEngine.Random.Range(0, platformArray.Length - 1);
        
        //why is it returning 0???
        //Debug.Log(platformArray.Length);
        //Debug.Log(randInt);

        spawnVector = new Vector3(20f, UnityEngine.Random.Range(20f, 25f), 0);
        RandomSpawn(0.8, platformArray[1], spawnVector);
        //1st value is probability. It is a parent class' method
    }
}