using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NumberWizard : MonoBehaviour
{
	const int MinNumber = 1;
	const int MaxNumber = 1000000;

	int sessionMin, sessionMax, sessionGuess, sessionScore;

	public Text score;
	public Text guess;
	
	public void GuessHigher ()
	{
		if (sessionGuess == sessionMin && sessionGuess == sessionMax) {
			Application.LoadLevel ("Cheat");
		} else {
			SetMin ();
		}
	}
	
	public void GuessLower ()
	{
		if (sessionGuess == sessionMin && sessionGuess == sessionMax) {
			Application.LoadLevel ("Cheat");
		} else {
			SetMax ();
		}
	}
	
	// Use this for initialization
	void Start ()
	{
		StartGame ();
	}

	void StartGame ()
	{
		sessionMin = MinNumber;
		sessionMax = MaxNumber;
		sessionScore = 0;
		NextGuess ();
	}

	void NextGuess ()
	{
		sessionScore++;
		score.text = sessionScore.ToString ("#,#");
		sessionGuess = Random.Range (sessionMin, sessionMax + 1);
		guess.text = sessionGuess.ToString ("#,#");
	}

	void SetMin ()
	{
		int newMin = sessionGuess + 1;
		if (newMin > sessionMax)
		{
			Application.LoadLevel ("Cheat");
		}
		else
		{
			sessionMin = newMin;
			NextGuess ();
		}	
	}

	void SetMax ()
	{
		int newMax = sessionGuess - 1;
		if (newMax < sessionMin)
		{
			Application.LoadLevel ("Cheat");
		}
		else
		{
			sessionMax = newMax;
			NextGuess ();
		}
	}
}
