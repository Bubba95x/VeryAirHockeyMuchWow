using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour 
{
	Transform player;

	NavMeshAgent nav;

	// Use this for initialization
	void Awake ()
	{
		player = GameObject.FindGameObjectWithTag("Player").transform;

		nav = GetComponent<navMeshAgent>();

	}

	// Update is called once per frame
	void Update () 
	{
		nav.SetDestination (player.position);
	}
}
