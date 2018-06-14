using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemiesandWaveCounter : MonoBehaviour
{
	public Text wave;
	public Text enemies;
	
	void Update ()
	{

		wave.text = "Wave: " + WaveSpawner.wave;
		enemies.text = "Enemies Remaining: " + WaveSpawner.shipsLeft;
	}
}
