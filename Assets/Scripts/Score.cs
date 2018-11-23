using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//using statement for the unity UI code 
using UnityEngine.UI;
public class Score : MonoBehaviour {

    //variable to track visible text score
    //public to let us drang & drop in the editor 
    public Text scoreText;
    //variable to track numerical score
    // Deafault to 0 since we should not have any score when starting

    private int numericalScore = 0;
    
	// Use this for initialization
	void Start () {
        // get the score from the prefs database
        //Use a default of 0 no score was saved
        numericalScore = PlayerPrefs.GetInt("score", 0);

        //Update the visual score
        scoreText.text = numericalScore.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    //Function to increase the score
    // Public so other scrips can use it(like the coin)
    public void AddScore(int _toAdd)
    {
        //Add the amount to the numerical score
        numericalScore = numericalScore + _toAdd;

        //Update the visual score
        scoreText.text = numericalScore.ToString();
    }
     
    //Function to save the score to the player preferences
    // public so it can be triggeed from another script K door)
    public void SaveScore()
    {
        PlayerPrefs.SetInt("score", numericalScore);

    }
}
