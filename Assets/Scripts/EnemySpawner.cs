using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemySpawner : MonoBehaviour
{
    public EnemyFunc enemy;
    static bool startGame;

    public delegate void Initilalize(bool value);

    public static event Initilalize start;
    private void Awake()
    {
        start = ChangeStatus;
    }

    void Start()
    {
        gameObject.SetActive(false);
        startGame = false;
    }
    
    
    void ChangeStatus (bool value)
    {
        gameObject.SetActive(true);
        startGame = value;
    }

    private void Update()
    {
        if (startGame)
        {
            
            DebugSpawn();
        }
    }

    void DebugSpawn()
    {
        
        for (var i = 0; i < 10; ++i)
        {
          SpawnEnemy();
        }
    }

    void SpawnEnemy()
    {
        var RandomPosition = new Vector3(Random.Range(-30f, 30.0f), 0,Random.Range(-30f, 30.0f) );
        Instantiate(enemy, RandomPosition,Quaternion.Euler(-90, 0,0));
    }
}
