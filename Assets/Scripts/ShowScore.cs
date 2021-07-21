using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowScore : MonoBehaviour
{
    [SerializeField]
    Text scoretext;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        score = PlayerPrefs.GetInt("SCORE",0);
        scoretext.text = " "+score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
