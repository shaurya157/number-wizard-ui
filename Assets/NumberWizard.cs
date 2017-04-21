using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {
	int max;
	int min;
	int guess;
	int MaxGuesses;
	public Text text;
	public Text GuessNumber;
	int NumGuesses;
	
	// Use this for initialization
	void Start () {
		StartGame();
		text.text = Random.Range(min, max + 1).ToString();
	}
	
	public void NextGuess(){
		NumGuesses += 1;
		GuessNumber.text = "Guesses made: " + NumGuesses.ToString() + "/10";
		
		guess = (max + min)/2;
		text.text = guess.ToString();
		
		MaxGuesses -= 1;
		if(MaxGuesses <= 0) {
			Application.LoadLevel("win");
		}
	}
	
	void StartGame(){
		max = 1000;
		min = 1;
		guess = 500;
		max += 1;
		MaxGuesses = 10;
		NumGuesses = 1;
	}
	
	public void GuessHigher(){
		min = guess;
		NextGuess();
	}
	
	public void GuessLower(){
		max = guess;
		NextGuess();
	}
		
}