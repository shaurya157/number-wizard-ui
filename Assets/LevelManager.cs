﻿using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name){
		Debug.Log("Level lod requested" + name);
		Application.LoadLevel(name);
	}
	
	public void QuitRequest(){
		Debug.Log ("Level quit requested");
//		Application.Quit();
	}
}
