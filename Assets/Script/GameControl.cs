using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameControl : MonoBehaviour {
    public Text scoreText;
    public Text endText;
    public int maxScore;
    // Use this for initialization
    void Start()
    {
        scoreText.text = "Очки 0/" + maxScore;
        endText.text = "";
    }
    public void ChangeScore(int score)
    {
        scoreText.text = "Очки " + score + "/" + maxScore;
        if (score == maxScore)
        {
            endText.text = "ТЫ КРУТ !!! :)";
        }

    }

       

}
