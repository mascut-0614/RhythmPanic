using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float time=60;
    public GameObject gc;
    public GameObject redhp,bluehp;

    // Update is called once per frame
    void Update()
    {
        time-=Time.deltaTime;
        gameObject.GetComponent<Text>().text=time.ToString();
        if(time<0&&!gc.GetComponent<GameController>().gameend){
            time=0;
            float red=redhp.GetComponent<Slider>().value;
            float blue=bluehp.GetComponent<Slider>().value;
            if(red>blue){
                gc.GetComponent<GameController>().GameSet(1);
            }else if(blue>red){
                gc.GetComponent<GameController>().GameSet(0);
            }else{
                gc.GetComponent<GameController>().GameSet(2);
            }
        }
    }
}
