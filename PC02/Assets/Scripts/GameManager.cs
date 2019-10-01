﻿using UnityEngine;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
	int N = 10;	
	public static List<GameObject> agents = new List<GameObject>();


	void Start()
	{
		for (int i = 0; i < N; i++)
		{
			GameObject agent = Resources.Load<GameObject>("Agent");
			GameObject instance = Instantiate(agent);

			instance.GetComponent<Agent>().target = GameObject.Find("Target").transform;
			
			instance.transform.position = new Vector3(Random.Range(-5, 5), Random.Range(-5, 5), 0);
			instance.name = "Agent" + i.ToString();			
			agents.Add(instance);
		}

		agents.Add(GameObject.Find("Target"));
	}
}
