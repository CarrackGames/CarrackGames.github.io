using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public float waveCount;
	public GameObject spawn;
	public Vector3 pos;
	public Quaternion rot;
	
	void Spawn (float wave)
	{

		waveCount = wave;

	}

	void FixedUpdate()
	{
		pos = transform.position;
		rot = transform.rotation;
		if (waveCount >= 0)
		{
			Instantiate(spawn, pos, rot);
			waveCount = waveCount - 1;
			WaveSpawner.shipsLeft = WaveSpawner.shipsLeft + 1;
		}
		
	}
}
