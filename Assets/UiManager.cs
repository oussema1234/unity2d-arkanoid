using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class UiManager : MonoBehaviour {

    int score = 0;
    int live = 3;
    public Text liveText;
    public Text scoreText;
   
   

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
   

    public  void LoseLife()
    {
        if (live > 0)
        {



            SceneManager.LoadScene("leve1");

            live--;
            liveText.text = "LIVES : " + live;

        }
        else
        {
           
            SceneManager.LoadScene("GameOver");
        }
    }

   

    public void Declive() {

        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        // SceneManager.LoadScene("leve1") ;
    
        live--;
        liveText.text = "LIVES : " + live;
        
    }
   
    public void IncrementScore()
    {
        score++;
        scoreText.text = "SCORE: " + score;
    }
    

    
}
