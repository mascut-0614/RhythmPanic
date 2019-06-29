using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YellowBall : MonoBehaviour
{
    Rigidbody rb;
    public GameObject redhp,bluehp;
    // Start is called before the first frame update
    void Start()
    {
        rb=gameObject.GetComponent<Rigidbody>();
        rb.AddForce(0,10,0,ForceMode.Impulse);
    }
    void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("Goal_red")){
            redhp.GetComponent<Slider>().value-=10;
            Destroy(this.gameObject);
        }
        if(other.gameObject.CompareTag("Goal_blue")){
            bluehp.GetComponent<Slider>().value-=10;
            Destroy(this.gameObject);
        }
    }
}
