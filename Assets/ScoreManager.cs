using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    int score;
    public Text textScore;
   // public GameObject youWin;
   // public GameObject gameOver;
    //public bool isGameWin = false;
   // public bool isGameOver = false;
    public float time;
    private void Update()
    {
        time = time + Time.deltaTime;
        textScore.text = score.ToString();
       /* if (time > 10f)
        {
            gameOver.SetActive(true);
            isGameOver = true;
        }*/

    }

    public void ScoreCalculator(int scoreValue)
    {

        score = score + scoreValue;
        Debug.Log("Score : " + score);
        //if (score > 50)
        //{
        //    youWin.SetActive(true);
        //    isGameWin = true;
        //}

    }
}
