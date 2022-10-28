using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextLevelPoint : MonoBehaviour
{
    public string lvlName;
    public Text yourText;
    public GameObject target;
    public Canvas myCanvas;
    

    void Start()
    {
        yourText.enabled = false;
    }

    void Update() {
        if(yourText.enabled && target.tag == "Portal"){
            if(Input.GetKeyDown(KeyCode.E)){
                SceneManager.LoadScene("quiz_scene");
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Player"){
            if(target.tag == "Portal"){
                yourText.enabled = true;
                myCanvas.enabled = true;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        yourText.enabled = false;
        myCanvas.enabled = false;
}
}
