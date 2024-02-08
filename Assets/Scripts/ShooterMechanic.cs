using System;
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

    private delegate void FireWeapon();
    private static FireWeapon Fire;
    
    public delegate bool AmmoOut(bool status);
    public static AmmoOut EmptyMag;

    void Start()
    {
        Gamemode.PlayerMode?.Invoke();
    }

    void Awake()
    {
        Fire = FireFunction;
    }


    private void Subscribe()
    {
        Fire += FireFunction;
    }

    private void Unsubscribe()
    {
        Fire -= FireFunction;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Fire?.Invoke();
        }
        

    }
    
    void FireFunction()
    {
        int count = AmmoManager.currentAmmoCount;
        if (count > 0)
        {
            AmmoManager.useAmmo?.Invoke();
            GameObject cloneBullet = Instantiate(Bullet, m_bulletRoot.position, Quaternion.identity);
            Bullet bullet = cloneBullet.GetComponent<Bullet>();
            bullet.SetDirection(transform.forward);

        }
        else if (count == 0)
        {
            StartCoroutine(ReloadGun());
        }
    }

    public bool IsOut(bool status)
    {
        return status;
    }

    IEnumerator ReloadGun()
    {
        Debug.Log("Reloading Gun");
        yield return new WaitForSeconds(2.0f);
        AmmoManager.AddAmmo(30);
    }
    


}