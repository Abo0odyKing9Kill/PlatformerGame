using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

	public float PlayerSpeed = 5.0f;
	public float playerJumpHeight = 15f;
	private SpriteRenderer _spriteRenderer;

	private Rigidbody2D _rigidbody2D;
//	private BoxCollider2D BoxCollider2D;

	// Use this for initialization
	void Start () {
		//print("Abdullah is Making Video Game\nCalled in Start() Function");
		_rigidbody2D = GetComponent<Rigidbody2D>();
//		BoxCollider2D = GetComponent<BoxCollider2D>();
		_spriteRenderer = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
//		//print("Abdullah is Playing Video Game\n\tCalled in Uodate() Function");
		float moveLeftRight = Input.GetAxis("Horizontal"); // A OR D -> or <-
		float moveUpDown = Input.GetAxis("Vertical"); // W OR S ^ or v
		
		Vector2 movements = new Vector2(moveLeftRight, 0);
		_rigidbody2D.AddForce(movements * PlayerSpeed);
		print(Input.GetAxis("Horizontal"));
		
		if (Input.GetAxis("Horizontal") < 0)
		{
			
			_spriteRenderer.flipX = true;
		}
		else
		{
			_spriteRenderer.flipX = false;
		}

		movePlayer();
		
	}

	void movePlayer()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			//Make the player JUMP
			print("SPACE Pressed");
			//new Vector2(0, 10), ForceMode2D.Impulse);
			_rigidbody2D.AddForce(new Vector2(0, playerJumpHeight), ForceMode2D.Impulse);
		}
		if(Input.GetKeyDown(KeyCode.S))
		{
			//Make the player crotch or climb down
			print("S Pressed");
		}

//		if (Input.GetKeyDown(KeyCode.D))
//		{
//			float moveLeftRight = Input.GetAxis("Horizontal");
//			//Make the player move Right
//			print("D Pressed");
//			
//			Vector2 movements = new Vector2(moveLeftRight, 0);
////			_rigidbody2D.AddForce(movements * PlayerSpeed);
////			_rigidbody2D.AddForce(new Vector2(moveLeftRight, 0) * PlayerSpeed);
//		}
//
//		if (Input.GetKeyDown(KeyCode.A))
//		{
//			float moveLeftRight = Input.GetAxis("Horizontal");
//			//Make the player move LEFT
//			print("A Pressed");
//			_rigidbody2D.AddForce(new Vector2(moveLeftRight, 0) * PlayerSpeed);
//		}

		if (Input.GetKeyDown(KeyCode.W))
		{
			//Make the player climb up 
			print("W Pressed");
		}
	}
}
