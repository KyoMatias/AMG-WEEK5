using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AmmoManager : MonoBehaviour
{
    public int MaxAmmoCount;
    public static int currentAmmoCount;
    public int ammo;
    private bool OutOfAmmo;
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
        ammoUI.text = currentAmmoCount.ToString();

    }

    void CheckAmmo()
    {
        
        if (currentAmmoCount == 0)
        {
            OutOfAmmo= true;
            //- and add a yield return new Waitforseconds() variable for reload.
        }

        OutOfAmmo = false;
        
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

    public static int AddAmmo(int Ammo)
    {
        currentAmmoCount = Ammo;
        return currentAmmoCount;
    }
    
}
