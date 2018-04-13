using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Healt : MonoBehaviour {

    public float CurrentHealt { get; set; }
    public float MaxHealt { get; set; }

    public Slider healthbar;

    // Use this for initialization
	void Start ()
	{
	    MaxHealt = 20f;
	    CurrentHealt = MaxHealt;

	    healthbar.value = CalculateHealth();
	}
	
	// Update is called once per frame
	void Update ()
	{
	    if (Input.GetKeyDown(KeyCode.X))
	        DealDamage(1);
	    if (Input.GetKeyDown(KeyCode.Z))
            Heal(1);

    }

    void DealDamage(float damageValue)
    {
        CurrentHealt -= damageValue;
        healthbar.value = CalculateHealth();

        if (CurrentHealt <= 0)
            Die();
    }
    void Heal(float healValue)
    {
        CurrentHealt += healValue;
        healthbar.value = CalculateHealth();

    }

    float CalculateHealth()
    {
        return CurrentHealt / MaxHealt;
    }

    void Die()
    {
        CurrentHealt = 0;
        
    }
}
