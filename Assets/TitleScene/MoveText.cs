using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveText : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    GameObject text;
    void Start()
    {
        text.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(){
        Debug.Log("hit");
        text.SetActive(true);
    }
}
