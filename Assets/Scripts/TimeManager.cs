using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class TimeManager : MonoBehaviour
{
    [SerializeField]
    Text text;
    float time = 0;
    // Start is called before the first frame update
    void Start()

    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        text.text = " " + Mathf.Ceil(time);
        if(time > 60.0f){
            SceneManager.LoadScene("Clear");
        }
    }
}
