using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerManager : NetworkBehaviour {

	public GameObject playerunit;

    private IEnumerator coroutine;

    void Awake()
    {
        /*/don't spawn a unit for someone else when they connect
        if (isLocalPlayer == false)
        {
            return;
        }
        //spawn your own unit when you connect
        Cmdspawn();*/
        
    }


	// Use this for initialization
	void Start () {

        //don't spawn a unit for someone else when they connect
        
        //spawn your own unit when you connect
        if (isLocalPlayer == true)
        {
            Cmdspawn();

            StartCoroutine(Wait());

            GameObject[] playerList;
            playerList = GameObject.FindGameObjectsWithTag("Player");
            foreach (GameObject player in playerList)
            {
                if (player.GetComponent<NetworkIdentity>().hasAuthority == false)
                {
                    player.transform.Find("Head").gameObject.SetActive(false);
                }
            }
        }

    }

    private IEnumerator Wait()
    {
        yield return new WaitForSeconds(5f);
    }

	
	
	//comands, These are called on the server and communicated to the client
	[Command]
	void Cmdspawn()
	{
		ClientScene.Ready (connectionToClient);
        //spawns the Player over the network
        GameObject go = Instantiate (playerunit);
		playerunit = go;
		NetworkServer.SpawnWithClientAuthority (go , connectionToClient);
	}
}
