using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    [SerializeField]
    Text _highScoreText;
    int _highScore;
    // Start is called before the first frame update
    void Start()
    {
        int score;
        _highScore = PlayerPrefs.GetInt("HIGHSCORE",0);
        score = PlayerPrefs.GetInt("SCORE",0);
        if(_highScore < score){
            PlayerPrefs.SetInt("HIGHSCORE",score);
        }
        _highScoreText.text = _highScore.ToString(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
