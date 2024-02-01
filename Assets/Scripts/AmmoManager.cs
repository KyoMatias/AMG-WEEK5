using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AmmoManager : MonoBehaviour
{
    public int MaxAmmoCount;
    private static int currentAmmoCount;
    public int ammo;

    public delegate void Bullet();

    public static Bullet useAmmo;
    [SerializeField] private TextMeshProUGUI ammoUI;
    
    // Start is called before the first frame update
    void Awake()
    {
        currentAmmoCount = ammo;
        useAmmo += Fired;
    }

    // Update is called once per frame
    void Update()
    {
        CheckAmmo();
        Debug.Log($"The Current Ammo Count is: {UseAmmo(0)}");
        ammoUI.text = currentAmmoCount.ToString();

    }

    void CheckAmmo()
    {
        
        bool OutOfAmmo;
        
        if (currentAmmoCount <= MaxAmmoCount)
        {
            OutOfAmmo = false;
            //Invoke a function here to make player's gun able to shoot.
        }
        
        else if (currentAmmoCount == 0)
        {
            OutOfAmmo= true;
            //Invoke a function here to stop the player from shooting
            //- and add a yield return new Waitforseconds() variable for reload.
        }
    }
    
    
    public int UseAmmo(int fired)
    {
        currentAmmoCount -= fired; // Update the currentAmmoCount variable
        return currentAmmoCount;
    }

    void Fired()
    {
        UseAmmo(1);
    }
    
}
