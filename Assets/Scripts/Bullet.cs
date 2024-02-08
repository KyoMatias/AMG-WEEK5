using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
/*    [SerializeField] private Transform m_bullet;
    [SerializeField] private Transform m_playerTransform;
    [SerializeField] private Transform m_worldPoint;
    [SerializeField] private float m_time;*/
    [SerializeField] private GameObject EnemyPrefab;
    
    Vector3 Direction;


    void Start()
    {

    }
    void Update()
    {
        if (this == null)
        {
            return;
        }
        transform.Translate(Direction * 10 * Time.deltaTime);

        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject enemy in enemies)
        {
            float distance = (transform.position - enemy.transform.position).magnitude;
            if(distance <= 0.2)
            {
                Destroy(gameObject);
                EnemyFunc kill = enemy.GetComponent<EnemyFunc>();
                kill.KillEnemy();
            }
        }
    }
    

    public void SetDirection(Vector3 Dir)
    {
        Direction = Dir;
    }
    
    
}
