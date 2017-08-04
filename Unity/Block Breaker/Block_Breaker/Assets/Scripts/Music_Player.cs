using UnityEngine;
using System.Collections;

public class Music_Player : MonoBehaviour {

	public static Music_Player instance = null;
	
	// Use this for initialization
	void Start () {
		if (instance != null) {
			Destroy(gameObject);
			print("duplicate music player removed");}
		else {instance = this;
		GameObject.DontDestroyOnLoad(gameObject);}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
