using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour
{
    [SerializeField]
    Text textObj;
    // Start is called before the first frame update
    int score = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddScore(int point){
        score += point;
        textObj.text = " " + score;
        PlayerPrefs.SetInt("SCORE",score);
        PlayerPrefs.Save();
    }
}
