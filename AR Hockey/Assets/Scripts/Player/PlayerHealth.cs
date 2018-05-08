using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {
	public int startingHealth = 100;
	public int currentHealth;
	public Slider healthSlider;

	Animator anim;
	// Use this for initialization
	void Awake () {
		currentHealth = startingHealth;
	}
	
	// Update is called once per frame
	public void TakeDamage (int amount) {
		currentHealth -= amount;
		healthSlider.value = currentHealth;
		if (currentHealth <= 0) 
		{
			Destroy (this);
		}
	}
}
