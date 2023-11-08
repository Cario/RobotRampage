using System.Collections;
using System.Collections.Generic;
//using System.Diagnostics;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    [SerializeField]
    GameUI gameUI;

    [SerializeField]
    private int pistolAmmo = 20;
    [SerializeField]
    private int shotgunAmmo = 10;
    [SerializeField]
    private int assaultRifleAmmo = 50;

    public Dictionary<string, int> tagToAmmo;

    void Awake()
    {
        tagToAmmo = new Dictionary<string, int>
        {
            { Constants.Pistol, pistolAmmo},
            { Constants.Shotgun, shotgunAmmo},
            { Constants.AssaultRifle, assaultRifleAmmo},
        };
    }

    public void AddAmmo(string tag, int ammo)  //Checks for tag from dictionary
    {
        if (!tagToAmmo.ContainsKey(tag))
        {
            Debug.LogError("Unrecognized gun type passed: " + tag);
        }

        tagToAmmo[tag] += ammo;               //Adds ammo to the int within tag
    }

    public bool HasAmmo(string tag)
    {
        if (!tagToAmmo.ContainsKey(tag))
        {
            Debug.LogError("Unrecognized gun type passed: " + tag);
        }

        return tagToAmmo[tag] > 0;         //Checks ammo within tag is more 0 or not
    }

    public int GetAmmo(string tag)
    {
        if (!tagToAmmo.ContainsKey(tag))
        {
            Debug.LogError("Unrecognized gun type passed: " + tag);
        }

        return tagToAmmo[tag];          //Returns number of ammo remaining for tag
    }

    public void ConsumeAmmo(string tag)
    {
        if (!tagToAmmo.ContainsKey(tag))
        {
            Debug.LogError("Unrecognized gun type passed: " + tag);
        }

        tagToAmmo[tag]--;
        gameUI.SetAmmoText(tagToAmmo[tag]);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
