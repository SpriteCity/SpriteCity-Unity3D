using UnityEngine;
using System.Collections;

public class ShootySprite : Moveable
{
	public int speed = 10;
	public int bulletSpeed = 15;
	public float shootInterval = 1;
	public AudioClip shootSound;
	public BulletSprite bulletPrefab;
	
	float lastShot;
	AudioSource audioSource;

	// Use this for initialization
	new void Start()
	{
		audioSource = gameObject.AddComponent<AudioSource>();
		audioSource.clip = shootSound;
		audioSource.volume = 1;

		base.Start();
	}
	
	// FixedUpdate should be used instead of Update when dealing with Rigidbody
	new void FixedUpdate()
	{
		Vector2 direction = new Vector2(Input.GetAxis("SD Horizontal Move"), Input.GetAxis("SD Vertical Move"));
		
		GetComponent<Rigidbody2D>().velocity = direction * speed;

		lastShot += Time.deltaTime;

		if (lastShot >= 1 / shootInterval) {
			shoot ();
		}

		base.FixedUpdate ();
	}

	public void shoot()
	{
		Vector2 shootDirection = new Vector2 (Input.GetAxis ("SD Horizontal Shoot"), Input.GetAxis ("SD Vertical Shoot"));

		shootDirection.Normalize ();

		if (shootDirection != Vector2.zero) {
			BulletSprite bullet = Instantiate<BulletSprite>(bulletPrefab);
			bullet.Initialize(transform.position, shootDirection, bulletSpeed);

			audioSource.Play ();

			lastShot = 0;
		}
	}
}