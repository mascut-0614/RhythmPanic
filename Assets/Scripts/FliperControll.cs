using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FliperControll : MonoBehaviour
{
    public KeyCode kc;
    public int keynum;
    GameObject parent;
    GameObject left,right;
    // Start is called before the first frame update
    void Start()
    {
        left=gameObject.transform.GetChild(0).gameObject;
        right=gameObject.transform.GetChild(1).gameObject;
        parent=gameObject.transform.root.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(kc)&&parent.GetComponent<FlipFlag>().flag==0){
            parent.GetComponent<FlipFlag>().flag=keynum;
            left.GetComponent<FlipperMove>().openFlipper();
            right.GetComponent<FlipperMove>().openFlipper();
        }
        if(Input.GetKeyUp(kc)&&parent.GetComponent<FlipFlag>().flag==keynum){
            parent.GetComponent<FlipFlag>().flag=0;
            left.GetComponent<FlipperMove>().closeFlipper();
            right.GetComponent<FlipperMove>().closeFlipper();
        }
    }
}
