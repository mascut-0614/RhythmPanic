using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipperMove : MonoBehaviour
{
    float spring=40000;
    float openAngle = 40;
    float closeAngle = -40;
    HingeJoint hj;
    // Start is called before the first frame update
    void Start()
    {
        hj = gameObject.GetComponent<HingeJoint>();
        closeFlipper();
    }

    public void openFlipper(){
        JointSpring spr = hj.spring;
        spr.spring = spring;
        spr.targetPosition = openAngle;
        hj.spring = spr;
    }
    public void closeFlipper(){
        JointSpring spr = hj.spring;
        spr.spring = spring;
        spr.targetPosition = closeAngle;
        hj.spring = spr;
    }
}
