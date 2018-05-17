using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelectButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void LoadSceneSelect()
    {
        SceneManager.LoadSceneAsync(1);
    }
}
