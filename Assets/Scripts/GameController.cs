using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour
{
    public Text GameText;
    public bool gameend=false;
    // Update is called once per frame
    void Update()
    {
        if(gameend){
            if(Input.GetKeyDown(KeyCode.Return)){
                SceneManager.LoadScene("Main");
            }
        }
    }
    public void GameSet(int status){
        GameText.gameObject.SetActive(true);
        gameend=true;
        switch(status){
            case 0:
            GameText.color=Color.blue;
            GameText.text="Blue Win!";
            break;
            case 1:
            GameText.color=Color.red;
            GameText.text="Red Win!";
            break;
            case 2:
            GameText.color=Color.yellow;
            GameText.text="Draw!?";
            break;
            default:
            break;
        }
    }
}
