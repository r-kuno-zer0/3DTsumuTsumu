using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchManager : MonoBehaviour
{
    [SerializeField]
    List<GameObject> touchBallList;
    [SerializeField]
    GameObject cube;
    [SerializeField]
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var mousePos = Input.mousePosition;
        if(Input.GetMouseButtonDown(0)){
           //text.text = "タッチした";
            
                touchBallList = new List<GameObject>();
                Ray ray = Camera.main.ScreenPointToRay(mousePos);
                var h = Physics.RaycastAll(ray,100f);
                if(h.Length > 0){
                    if(h[1].collider.CompareTag("Ball") && !h[1].collider.GetComponent<BallObject>().isTouch)
                    {
                        touchBallList.Add(h[1].collider.gameObject);
                    }
                }
            }
    

        if(Input.GetMouseButton(0)){
            //text.text = "長押し";
            if(touchBallList.Count != 0)
            {
                //text.text = "デバック1";
                Ray ray = Camera.main.ScreenPointToRay(mousePos);
                var h = Physics.RaycastAll(ray,100f);
                if(h.Length > 0)
                {
                    for(int i = 0;i<h.Length;i++){
                        text.text += h[i].collider.gameObject;
                    }
                    //text.text = h[0].collider.gameObject.ToString();
                    if(h[1].collider.tag == "Ball" && !h[1].collider.GetComponent<BallObject>().isTouch &&
                    touchBallList[0].GetComponent<BallObject>().color == h[1].collider.GetComponent<BallObject>().color)
                    {

                        h[1].collider.GetComponent<BallObject>().isTouch = true;
                        touchBallList.Add(h[1].collider.gameObject);
                    }
                    else if(h[1].collider.tag == "Ball" && touchBallList[0].GetComponent<BallObject>().color != h[1].collider.GetComponent<BallObject>().color){
                        ReleaseObject();
                    }
                }
                else{
                    ReleaseObject();
                }
            }
        }

        if(Input.GetMouseButtonUp(0)){
            //text.text = "離した";
            text.text = "";
            ReleaseObject();
        }
    }
    public void ReleaseObject(){
        var cnt = touchBallList.Count;

        foreach(GameObject go in touchBallList){
            go.GetComponent<BallObject>().isTouch = false;
            if(cnt > 3){
                //ここで消すときのSE鳴らす
                Destroy(go);
            }
        }
        touchBallList.Clear();
    }
}
