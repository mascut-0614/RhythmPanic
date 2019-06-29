using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    Rigidbody rb;
    string enemy;
    public GameObject enemy_hp;
    
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody>();
        if(gameObject.CompareTag("Ball_red")){
            enemy="blue";
            rb.AddForce(-5,-7,0,ForceMode.Impulse);
        }else{
            enemy="red";
            rb.AddForce(5,7,0,ForceMode.Impulse);
        }
    }

    void OnCollisionEnter(Collision other){
        if(other.gameObject.CompareTag("Ball_"+enemy)){
            Destroy(gameObject);
            Debug.Log("Ball is banished");
        }
    }
    void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("Goal_"+enemy)){
            Debug.Log("nice shoot");
            enemy_hp.GetComponent<Slider>().value-=1;
            Destroy(gameObject);
        }
    }
}
