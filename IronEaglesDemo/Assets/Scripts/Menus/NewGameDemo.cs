using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGameDemo : MonoBehaviour {
	
	public void OnNew () {
		
		SceneManager.LoadSceneAsync ("sceneTest");
	}
}
