using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class BallGenerator : MonoBehaviour
{
    [SerializeField]
    GameObject ballObj;
    int cnt = 0;
    const int MAXCNT = 60;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cnt+=2;
        cnt = cnt % MAXCNT;
        if(cnt == 0){
            GameObject gameObject = Instantiate(ballObj);
            gameObject.transform.parent = this.transform;
            gameObject.transform.localPosition = Vector3.zero;
            gameObject.GetComponent<Rigidbody>().AddForce(Quaternion.Euler(0,0,Random.Range(-60f,60f))*Vector3.down*10f,ForceMode.Impulse);
            gameObject.GetComponent<BallObject>().color = GameResources.BallColor.GetValues(typeof(GameResources.BallColor)).Cast<GameResources.BallColor>().ToList()[Random.Range(0,4)];
        }
    }
}
