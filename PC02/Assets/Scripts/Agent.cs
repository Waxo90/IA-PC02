using UnityEngine;

public class Agent : SBAgent
{
	public Transform target;	

	void Start()
	{
		maxSpeed = 10f;
		maxSteer = 0.5f;		
	}

	void Update()
	{
		velocity += SB.Arrive(this, target, 3);
		velocity += SB.Flee(this, target, 1);
		velocity += SB.Separate(this, GameManager.agents, 2f);
		transform.position += velocity * Time.deltaTime;

        if (transform.position.y < -2 || transform.position.y > 2) {
            velocity.y *= 0;
        }

        if (transform.position.x < -2 || transform.position.x > 2) {
            velocity.x *= 0;
        }
	}
}
