using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shuffle : MonoBehaviour
{
    [SerializeField]
    GameObject ball;
    // Start is called before the first frame update
    BallObject _ballScript;
    void Start()
    {
        _ballScript = ball.GetComponent<BallObject>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClick(){
        Debug.Log("click");
        _ballScript.ShuffleBall();
    }
}
