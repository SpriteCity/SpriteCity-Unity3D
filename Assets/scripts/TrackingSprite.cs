using UnityEngine;
using System.Collections;

public class TrackingSprite : Moveable {
	
	public GameObject objectToTrack;
	public int speed = 10;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	// FixedUpdate should be used instead of Update when dealing with Rigidbody
	void FixedUpdate()
	{
		Vector2 direction = objectToTrack.transform.position - transform.position;
		direction.Normalize();

		GetComponent<Rigidbody2D>().velocity = direction * speed;
	}
}
