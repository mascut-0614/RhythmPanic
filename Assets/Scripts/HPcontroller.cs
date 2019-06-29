using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPcontroller : MonoBehaviour
{
    public int status;
    public GameObject gc;
    Slider hp;
    // Start is called before the first frame update
    void Start()
    {
        hp=gameObject.GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        if(hp.value==0&&!gc.GetComponent<GameController>().gameend){
            gc.GetComponent<GameController>().GameSet(status);
        }
    }
    public void Restart(){
        hp.value=hp.maxValue;
    }
}
