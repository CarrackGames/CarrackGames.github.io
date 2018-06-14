using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveShipCounter : MonoBehaviour {
	
	void DestroyedCounter ()
	{
		WaveSpawner.shipsLeft = WaveSpawner.shipsLeft - 1;
	}
}
