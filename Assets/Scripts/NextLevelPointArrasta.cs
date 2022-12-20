using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextLevelPointArrasta : MonoBehaviour
{
    public Text yourText;
    public GameObject target;
    public Canvas myCanvas;
    

    void Start()
    {
        yourText.enabled = false;
    }

    void Update() {
        if(yourText.enabled && target.tag == "PortalArrasta"){
            if(Input.GetKeyDown(KeyCode.E)){
                SceneManager.LoadScene("MathCombinationMENU");
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Player"){
            if(target.tag == "PortalArrasta"){
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

