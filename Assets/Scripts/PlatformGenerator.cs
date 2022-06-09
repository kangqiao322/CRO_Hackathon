using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random=UnityEngine.Random;

public class PlatformGenerator : GeneratorAbstract //this extends GeneratorAbstract class
{
    //interval is mananing the time inbewteen spawns
    private float interval;

    private float timePassed = 0f;
    
    private Vector3 spawnVector;
    

    //make it public and drag the prefab into this field in the unity GUI
    [SerializeField] public Transform platform;

    private void Update()
    {
        timePassed += Time.deltaTime;

        if (timePassed > interval)
        {
            interval = Random.Range(1f, 2f);
            spawnVector = new Vector3(20f, UnityEngine.Random.Range(20f, 25f));
            RandomSpawn(1, platform, spawnVector);
            timePassed = 0f;
        }

    }

}
