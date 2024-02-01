using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ShooterMechanic : MonoBehaviour
{
     private Transform m_bullet;
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
        if(Input.GetButtonDown("Fire1"))
        {
             Ray ray;
               //ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        }
    }


}