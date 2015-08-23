using UnityEngine;
using System.Collections;

public class BulletSprite : Moveable
{
    int directionX = 0;
    int directionY = 0;

    // Use this for initialization
    void Start()
    {

    }

	void OnCollisionEnter2D(Collision2D collision2D) {
		Moveable moveable = collision2D.collider.GetComponent<Moveable> ();
		
		if (moveable != null) 
		{			
			Destroy(moveable.gameObject);
			Destroy(gameObject);
		}
	}
}