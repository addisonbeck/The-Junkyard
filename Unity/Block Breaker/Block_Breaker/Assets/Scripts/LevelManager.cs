using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string n){
		Debug.Log("Level Load Requested For: " + n);
		Application.LoadLevel(n);
	}
	
	public void QuitRequest(){
		Debug.Log ("Quit Request Made");
		Application.Quit();
	}
}