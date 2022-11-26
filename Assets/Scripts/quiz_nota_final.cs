using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class quiz_nota_final : MonoBehaviour
{
    public Text txtAcertos;
    public int acertos;
    // Start is called before the first frame update
    void Start()
    {
        acertos = PlayerPrefs.GetInt("acertos");
        txtAcertos.text = "Você acertou "+acertos.ToString()+" de 10 perguntas";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
