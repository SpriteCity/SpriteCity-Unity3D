using UnityEngine;
using System.Collections;

public class KeyMoveSprite : Moveable
{
    public int speed = 10;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
		if (health <= 0) {
			Destroy(gameObject);
		}
    }

	// FixedUpdate should be used instead of Update when dealing with Rigidbody
    void FixedUpdate()
    {
        Vector2 direction = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

		GetComponent<Rigidbody2D>().velocity = direction * speed;
    }
}
