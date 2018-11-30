using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//allows us to usethe scene loading function
using UnityEngine.SceneManagement;
public class StartButton : MonoBehaviour {
    //this will be called by the button componenet when clicked
   public void StartGame()
    {
        //reset the score
        PlayerPrefs.DeleteKey("score");

        SceneManager.LoadScene("SampleScene");

    }
	
}
