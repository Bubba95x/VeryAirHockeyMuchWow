using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


public class EnemyManager : NetworkBehaviour {
	public PlayerHealth playerHealth;
	public GameObject enemy;
	public float spawnTime = 3f;
	public Transform spawnPoints;
	// Use this for initialization
	void Start () {
		InvokeRepeating ("CmdSpawn", spawnTime, spawnTime);
	}
	

	// Update is called once per frame
    [Command]
	void CmdSpawn () {
		if (playerHealth.currentHealth <= 0f) 
		{
			return;
		}

		Instantiate (enemy, spawnPoints.position, spawnPoints.rotation);
	}
}
