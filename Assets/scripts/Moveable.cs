using UnityEngine;
using System.Collections;

public class Moveable : MonoBehaviour
{
	public int health = 1;

	//Whats called when a drawable is created
	public Moveable()
	{

	}
	
	// Use this for initialization
	protected void Start()
	{

	}
	
	// Update is called once per frame
	protected void Update()
	{
		if (health <= 0) {
			Destroy(gameObject);
		}
	}

	// FixedUpdate should be used instead of Update when dealing with Rigidbody
	protected void FixedUpdate() 
	{

	}

	protected void OnCollisionEnter2D(Collision2D collision2D)
	{
		
	}
}
