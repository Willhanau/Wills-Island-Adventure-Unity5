using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Reloader : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    
    void ReloadMenu()
    {
        SceneManager.LoadScene("Menu");
    }

}
