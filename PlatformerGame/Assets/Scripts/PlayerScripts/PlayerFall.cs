using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFall : MonoBehaviour
{

	public float threshold;
	// Use this for initialization
	void Start () {
		
	}
	
	void FixedUpdate () {
		if (transform.position.y < threshold)
		{
			//player fell to death ... respawn
			transform.position = new Vector2(0,0);
			print("You fell to your DEATH!");
		}
	}
}
