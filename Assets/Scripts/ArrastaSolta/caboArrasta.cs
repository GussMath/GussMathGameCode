using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class caboArrasta : MonoBehaviour
{
    public int scores;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Click()
    {
         SceneManager.LoadScene("MathCombinationMENU");
            scores = PlayerPrefs.GetInt("score");
            scores = 0;
            PlayerPrefs.SetInt("score",  scores);
    }
}
