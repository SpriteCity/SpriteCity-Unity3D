using UnityEngine;
using System.Collections;

public class ShootySprite : Moveable
{
	public int speed = 10;
	public int bulletSpeed = 15;
	public float shootInterval = 1;
	public AudioClip shootSound;
	public Rigidbody2D bulletPrefab;
	
	float lastShot;
	AudioSource audioSource;

	// Use this for initialization
	void Start()
	{
		audioSource = gameObject.AddComponent<AudioSource>();
		audioSource.clip = shootSound;
		audioSource.volume = 1;
	}
	
	// Update is called once per frame
	void Update()
	{
		
	}
	
	// FixedUpdate should be used instead of Update when dealing with Rigidbody
	void FixedUpdate()
	{
		Vector2 direction = new Vector2(Input.GetAxis("SD Horizontal Move"), Input.GetAxis("SD Vertical Move"));
		
		GetComponent<Rigidbody2D>().velocity = direction * speed;

		lastShot += Time.deltaTime;

		if (lastShot >= 1 / shootInterval) {
			Vector2 shootDirection = new Vector2 (Input.GetAxis ("SD Horizontal Shoot"), Input.GetAxis ("SD Vertical Shoot"));

			shootDirection.Normalize ();

			if (shootDirection != Vector2.zero) {
				Rigidbody2D bullet;
				bullet = Instantiate (bulletPrefab, transform.position, transform.rotation) as Rigidbody2D;
				bullet.velocity = shootDirection * bulletSpeed;
			
				audioSource.Play ();

				lastShot = 0;
			}
		}
	}

	public Rigidbody2D CreateNewProjectile(Object prefab, Vector3 position, Quaternion rotation, Vector3 velocity)
	{
		Rigidbody2D tempProjectile;
		tempProjectile = Instantiate(prefab, position, rotation) as Rigidbody2D;
		tempProjectile.velocity = velocity;
		
		return tempProjectile;

		audioSource.Play();
	}
}