using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerBehavior : NetworkBehaviour {


	void FixedUpdate ()
    {
        //if you are not allowed to move the unit (it's not yours) don't move it
		if(hasAuthority == false)
		{
			return;
		}


		if(Input.GetKeyDown(KeyCode.D))
		{
			this.transform.Translate (1,0,0);
		}
		if(Input.GetKeyDown(KeyCode.A))
		{
			this.transform.Translate (-1,0,0);
		}
		if(Input.GetKeyDown(KeyCode.W))
		{
			this.transform.Translate (0,0,1);
		}
		if(Input.GetKeyDown(KeyCode.S))
		{
			this.transform.Translate (0,0,-1);
		}

	}
}
