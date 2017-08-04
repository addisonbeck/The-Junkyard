using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {	
	int max;
	int min;
	int guess;

	// Use this for initialization
	void Start () {
		StartGame();
	}
	void StartGame() {
		//Sets variables for start
		max = 1000;
		min = 1;
		guess = Random.Range(min, max);
	
		//Welcome
		print("=========================");
		print("Welcome to Number Wizard");
		
		print("Pick a number in your head, but don't tell me!");
		print("The highest number you can pick is 1000");
		print("The lowest number you can pick is 1");
		
		print("Is the number higher or lower than " + guess + "?");
		print("Press the up arrow if your number is higher, the down arrow if it is higher, or enter if equal");
		
		max += 1;
		}
		
	// Update is called once per frame
	void Update () {	
		if (Input.GetKeyDown(KeyCode.UpArrow)){
			print("Up Arrow Pressed");
			min = guess;
			NextGuess();
		} else if (Input.GetKeyDown(KeyCode.DownArrow)){
			print("Down Arrow Pressed");
			max = guess;
			NextGuess();
		}else if (Input.GetKeyDown(KeyCode.Return)){
			print("I Won!");
			StartGame();}
	}
	
	
	void NextGuess() {
		guess = Random.Range(min, max);
		print("Higher or lower than " + guess);
		print("Press the up arrow if your number is higher, the down arrow if it is higher, or enter if equal");
	}
}

