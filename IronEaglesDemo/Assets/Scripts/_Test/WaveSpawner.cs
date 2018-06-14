using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
	public GameObject spawner1;
	public GameObject spawner2;
	public GameObject spawner3;
	public GameObject spawner4;
	public GameObject spawner5;
	public GameObject spawner6;
	public static float wave = 1f;
	public static float shipsLeft;
	public float enemiesRemaining;
	public float countdown = 0f;
	public float maxCountdown = 50f;
	
	void Update ()
	{

		enemiesRemaining = shipsLeft;
		
		if (shipsLeft == 0)
		{
				spawner1.SendMessage("Spawn", wave);
				spawner2.SendMessage("Spawn", wave);
				spawner3.SendMessage("Spawn", wave);
				spawner4.SendMessage("Spawn", wave);
				spawner5.SendMessage("Spawn", wave);
				spawner6.SendMessage("Spawn", wave);

				countdown = maxCountdown;
				wave = wave + 1;
			
		}
	}
}
