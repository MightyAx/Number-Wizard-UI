﻿using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void LoadLevel (string name)
	{
		Debug.Log (string.Format ("Level load requested: {0}", name));
		Application.LoadLevel (name);
	}

	public void UserQuit ()
	{
		Debug.Log ("Quit requested.");
		Application.Quit();
	}
}
