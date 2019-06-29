using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RhythmViewer : MonoBehaviour
{
    Slider view;
    RhythmChecker rc_red,rc_blue;
    int count_num;
    // Start is called before the first frame update
    void Start()
    {
        view=GetComponent<Slider>();
        view.value=0;
        rc_red=transform.GetChild(0).GetComponent<RhythmChecker>();
        rc_blue=transform.GetChild(1).GetComponent<RhythmChecker>();
    }

    // Update is called once per frame
    void Update()
    {
        view.value+=1;
        if(Input.GetKeyDown(KeyCode.Space)){
            rc_red.TimeCount(view.value);
        }
        if(Input.GetKeyDown(KeyCode.Return)){
            rc_blue.TimeCount(view.value);
        }
        if(view.value==view.maxValue){
            view.value=view.minValue;
            rc_red.ResetCount();
            rc_blue.ResetCount();
        }
    }
}
