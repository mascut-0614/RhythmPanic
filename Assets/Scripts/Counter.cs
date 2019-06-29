using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Counter : MonoBehaviour
{
    public float correct_time;
    public int Check(float time){
        if(time>=correct_time-3&&time<=correct_time+3){
            gameObject.GetComponent<Image>().color=Color.yellow;
            return 1;
        }else{
            gameObject.GetComponent<Image>().color=Color.black;
            return 0;
        }
    }
}
