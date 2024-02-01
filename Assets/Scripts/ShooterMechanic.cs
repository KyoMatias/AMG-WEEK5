using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ShooterMechanic : MonoBehaviour
{
     public GameObject Bullet;
    [SerializeField] private Transform m_bulletRoot;
    [SerializeField] private Transform m_playerTransform;
    

    float currentTime;

    void Start()
    {
        Gamemode.PlayerMode?.Invoke();
        
    }

    void Awake()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            AmmoManager.useAmmo?.Invoke();
            FireFunction();
        }

    }

    void FireFunction()
    {
        GameObject cloneBullet = Instantiate(Bullet, m_bulletRoot.position, Quaternion.identity);
        Bullet bullet = cloneBullet.GetComponent<Bullet>();
        bullet.SetDirection(transform.forward);
    }
    


}