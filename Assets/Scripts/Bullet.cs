using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
/*    [SerializeField] private Transform m_bullet;
    [SerializeField] private Transform m_playerTransform;
    [SerializeField] private Transform m_worldPoint;
    [SerializeField] private float m_time;*/


    [SerializeField] private GameObject bullet;
    Vector3 Direction;


    void Start()
    {

    }
    



    void Update()
    {
        transform.Translate(Direction * 10 * Time.deltaTime);
    }

    public void SetDirection(Vector3 Dir)
    {
        Direction = Dir;
    }
}
