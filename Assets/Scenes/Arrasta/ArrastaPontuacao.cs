using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrastaPontuacao : MonoBehaviour
{
    public Text textScore;
    public int score;

    void Start()
    {
        score = PlayerPrefs.GetInt("score");
        textScore.text = "Você acertou "+score.ToString()+" de 7 perguntas";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
