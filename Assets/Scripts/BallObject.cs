using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallObject : MonoBehaviour
{
    [SerializeField]
    public Renderer renderer2;
    [SerializeField]
    public bool isTouch = false;
    [SerializeField]
    public GameResources.BallColor color;

    // Start is called before the first frame update
    void Start()
    {
        ChangeColor();
    }

    // Update is called once per frame
    void Update()
    {
        if(isTouch){
            GetComponent<BallObject>().renderer2.material.SetColor("_EmissionColor",new Color(0.5f,0.5f,0f));
            //GetComponent<BallObject>().renderer2.material.SetColor("_EmissionColor",Color.white);        
        }
        else{
            GetComponent<BallObject>().renderer2.material.SetColor("_EmissionColor",new Color(0.0f,0.0f,0f));
            // GetComponent<BallObject>().renderer2.material.SetColor("_EmissionColor",new Color(0.0f,0.0f,0f));
        }
    }
    public void ChangeColor()
    {
        switch(color){
            case GameResources.BallColor.red:
                GetComponent<BallObject>().renderer2.material.SetColor("_Color", Color.red);
                //gameObject.GetComponent<Renderer>().material.color = Color.red;
                break;
            case GameResources.BallColor.blue:
                GetComponent<BallObject>().renderer2.material.SetColor("_Color", Color.blue);
                //gameObject.GetComponent<Renderer>().material.color = Color.blue;
                break;
            case GameResources.BallColor.green:
                GetComponent<BallObject>().renderer2.material.SetColor("_Color", Color.green);
                //gameObject.GetComponent<Renderer>().material.color = Color.green;
                break;
            case GameResources.BallColor.purple:
                GetComponent<BallObject>().renderer2.material.SetColor("_Color", new Color(1, 0, 1));
                //gameObject.GetComponent<Renderer>().material.color = new Color(1,0,1);
                break;
            case GameResources.BallColor.bomb:
                GetComponent<BallObject>().renderer2.material.SetColor("_Color", new Color(0,0,0));
                break;
        }
    }

    public void Explosion(GameObject deleteObject)
    {
        var h = Physics.SphereCastAll(transform.position,5.0f,Vector3.forward);
        Debug.Log(h.Length);
        foreach(var hit in h){
            if(hit.collider.tag == "Ball"){
                GameObject delObj = Instantiate(deleteObject);
                delObj.transform.position = hit.collider.gameObject.transform.position;
                Destroy(hit.collider.gameObject);
            }
        }
    }

    public void ShuffleBall(){
        Debug.Log("CallMethod");
        Rigidbody rb = GetComponent<Rigidbody>();
        Debug.Log(rb);
        rb.AddForce(0f,-100f,0f,ForceMode.Impulse);
    }
}
