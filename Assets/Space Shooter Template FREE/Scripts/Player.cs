using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// This script defines which sprite the 'Player" uses and its health.
/// </summary>

public class Player : MonoBehaviour
{
    public GameObject destructionFX;

    public static Player instance;

    public TMP_Text healthText;

    private int maxHealth = 3;

    private int health;
    public int Health
    {
        get => health;
        set
        {
            health = value;
            healthText.text = health.ToString();
        }
    }

    private void Awake()
    {
        if (instance == null) 
            instance = this;
        instance.Health = maxHealth;
    }

    //method for damage proceccing by 'Player'
    public void GetDamage(int damage)   
    {
        instance.Health--;
        if(instance.Health == 0)
            Destruction();
    }    

    //'Player's' destruction procedure
    void Destruction()
    {
        Instantiate(destructionFX, transform.position, Quaternion.identity); //generating destruction visual effect and destroying the 'Player' object
        Destroy(gameObject);
    }
}
















