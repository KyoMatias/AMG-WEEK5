using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFunc : MonoBehaviour
{
    
    [SerializeField] private Transform m_point1;
    [SerializeField] private float m_time;
    float m_currentTime;

    public delegate void Subscribe();

    public static Subscribe yes;
    
    

    private void Start()
    {
        yes += moveToPlayer;
        gameObject.SetActive(false);
        m_currentTime = 0;
    }


    public void KillEnemy()
    {
        Destroy(gameObject);
    }

    public void moveToPlayer()
    {
        gameObject.SetActive(true);   
        m_currentTime += Time.deltaTime;
        var vectorTime = m_currentTime / m_time;

        var path = LinearLerp(transform.position, m_point1.position, vectorTime);

        transform.position = path;
    }
    
    
    private static Vector3 LinearLerp(Vector3 p0, Vector3 p1, float t)
    {
        // Clamp the input parameter 't' to be between 0 and 1
        float clampedTime = Mathf.Clamp01(t);

        // Calculate the return vector using the linear interpolation formula
        Vector3 returnVector = p0 * (1 - clampedTime) + p1 * clampedTime ;

        return returnVector; // Sets the Vector
    }
}
