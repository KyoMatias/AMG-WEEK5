using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private Transform m_bullet;
    [SerializeField] private Transform m_playerTransform;
    [SerializeField] private Transform m_worldPoint;
    [SerializeField] private float m_time;


    [SerializeField] private GameObject bullet;
    private bool is_shot;
    float currentTime;

    public delegate void Shoot();
    public static Shoot bulletshoot;


    void Start()
    {

    }
    



    void Update()
    {
    
    }
}
