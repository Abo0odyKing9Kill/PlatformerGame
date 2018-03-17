using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

	public float playerSpeed = 5.0f;

	private Rigidbody2D _rigidbody2D;
//	private BoxCollider2D BoxCollider2D;

	// Use this for initialization
	void Start () {
		//print("Abdullah is Making Video Game\nCalled in Start() Function");
		_rigidbody2D = GetComponent<Rigidbody2D>();
//		BoxCollider2D = GetComponent<BoxCollider2D>();
	}
	
	// Update is called once per frame
	void Update () {
		//print("Abdullah is Playing Video Game\n\tCalled in Uodate() Function");
		float moveLEFT_RIGHT = Input.GetAxis("Horizontal"); // A OR D -> or <-
		float moveUP_DOWN = Input.GetAxis("Vertical"); // W OR S ^ or v
		
		Vector2 movements = new Vector2(moveLEFT_RIGHT, moveUP_DOWN);
		_rigidbody2D.AddForce(movements * playerSpeed);
		
	}
}
