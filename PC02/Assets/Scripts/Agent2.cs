using UnityEngine;

public class Agent2 : SBAgent
{
    private int Radio = 2;
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

       /*  for (int i = 0; i < target.Length; i++) {
			float angle = 360 * i ;
			float posX = transform.position.x + Mathf.Sin (angle * Mathf.Deg2Rad) * Radio;
			float posY = transform.position.y + Mathf.Cos (angle * Mathf.Deg2Rad) * Radio;
			target [i].position = new Vector3 (posX, posY);
       }*/
	}
}
