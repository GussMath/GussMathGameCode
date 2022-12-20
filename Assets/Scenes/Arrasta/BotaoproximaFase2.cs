using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class BotaoproximaFase2 : MonoBehaviour
{
    public List <GameObject> respostas = new List<GameObject>();
    public int valor = 29;
    public int resposta = 60;
    public string operacaoAntes = "+";
    public string operacaoDepois = "-";
    public int score;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Click()
    {
        string numeroFinal = operacaoAntes;
        foreach(GameObject checado in respostas){
            string possivelResposta = checado.GetComponent<EspacoItem>().numeroNoEspaco;
        numeroFinal += possivelResposta;
        }
        int numeroFinalInteiro =  Convert.ToInt32(numeroFinal);

        int soma = numeroFinalInteiro - valor;
        if (soma == resposta){
            Debug.Log("Acertoooou");
            score = PlayerPrefs.GetInt("score");
            score += 1;
            PlayerPrefs.SetInt("score",  score);
            Debug.Log(score);
            SceneManager.LoadScene("ArrastaTerceiraFase");
        } else {
            SceneManager.LoadScene("ArrastaTerceiraFase");
        }
    }
}
