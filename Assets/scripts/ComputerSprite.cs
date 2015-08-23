using UnityEngine;
using System.Collections;

public class ComputerSprite : Moveable
{
	public int damage = 1;
	public int speed = 10;
	public float decisionInterval = 1; 

	float lastDecision;
	
	// Use this for initialization
	void Start()
	{

	}
	
	// Update is called once per frame
	void Update()
	{
		
	}
	
	// FixedUpdate should be used instead of Update when dealing with Rigidbody
	void FixedUpdate()
	{
		lastDecision += Time.deltaTime;

		if (lastDecision > decisionInterval) {
			Vector2 direction = Random.rotation * Vector2.up;

			direction.Normalize();
		
			GetComponent<Rigidbody2D>().velocity = direction * speed;

			lastDecision = 0;
		}
	}
	
	void OnCollisionEnter2D(Collision2D collision2D) {
		KeyMoveSprite keyMoveSprite = collision2D.collider.GetComponent<KeyMoveSprite> ();
		
		if (keyMoveSprite != null) 
		{			
			keyMoveSprite.health -= damage;
		}
	}
}