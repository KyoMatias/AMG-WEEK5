using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ShooterMechanic : MonoBehaviour
{
    [SerializeField] private Transform m_bullet;
    [SerializeField] private Transform m_playerTransform;
    [SerializeField] private Transform m_worldPoint;
    [SerializeField] private float m_time;

    private bool is_shot;

    float currentTime;

    void Start()
    {
        m_time = 3;
        Gamemode.PlayerMode?.Invoke();
    }

    void Awake()
    {
        is_shot = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) && !is_shot)
        {
            StartCoroutine(ShootBullet());
            is_shot = true;
        }

        if (is_shot && Input.GetKeyUp(KeyCode.Return))
        {
            is_shot = false;
        }
    }

    IEnumerator ShootBullet()
    {
        currentTime = 0;

        while (currentTime / m_time < 1)
        {
            currentTime += Time.deltaTime;
            var PercentTime = currentTime / m_time;

            var bulletSeg =  BezierCurve.LinearLerp(m_playerTransform.position, m_worldPoint.position, PercentTime);

            m_bullet.position = bulletSeg;
            Debug.Log("BULLET SHOT");

            yield return null;
        }

        is_shot = false;
    }
}