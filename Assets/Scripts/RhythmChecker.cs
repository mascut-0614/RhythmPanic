using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RhythmChecker : MonoBehaviour
{
    public KeyCode tap_command;
    public Color mycolor;
    public string player;
    public GameObject ball;
    Counter[] counter=new Counter[4];
    int all_check;
    int tap_num=0;
    // Start is called before the first frame update
    void Start()
    {
        for(int i=0;i<4;i++){
            counter[i]=transform.GetChild(i).GetComponent<Counter>();
        }
    }

    public void TimeCount(float time){
        if(tap_num<4){
            all_check+=counter[tap_num].Check(time);
            tap_num++;
        }
        if(all_check==4){
            if(player=="Red"){
                Instantiate (ball, new Vector3(0.0f,2.0f,0.0f), Quaternion.identity);
            }else if(player=="Blue"){
                Instantiate (ball, new Vector3(0.0f,-3.0f,0.0f), Quaternion.identity);
            }
        }
    }
    public void ResetCount(){
        tap_num=0;
        all_check=0;
        foreach (Transform child in transform){
            child.GetComponent<Image>().color=mycolor;
        }
    }
}
