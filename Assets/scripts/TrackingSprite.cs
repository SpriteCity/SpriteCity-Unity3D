using UnityEngine;
using System.Collections;

public class TrackingSprite : Moveable {
	
	public GameObject objectToTrack;
	public int speed = 10;

	// FixedUpdate should be used instead of Update when dealing with Rigidbody
	new void FixedUpdate()
	{
		if (objectToTrack != null) {
			Vector2 direction = objectToTrack.transform.position - transform.position;
			direction.Normalize ();

			GetComponent<Rigidbody2D> ().velocity = direction * speed;
		}

		base.FixedUpdate ();
	}
}
