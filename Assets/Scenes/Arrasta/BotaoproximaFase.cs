using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class BotaoproximaFase : MonoBehaviour
{
    public List <GameObject> respostas = new List<GameObject>();
    public int valor = 14;
    public int resposta = 9;
    public string operacaoAntes = "-";
    public string operacaoDepois = "+";
    public int score = 0;

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

        int soma = numeroFinalInteiro + valor;
        if (soma == resposta){
            Debug.Log("Acertoooou");
            score += 1;
            Debug.Log(score);
            PlayerPrefs.SetInt("score",  score);
            SceneManager.LoadScene("ArrastaSegundaFase");
        } else {
            SceneManager.LoadScene("ArrastaSegundaFase");
        }
    }
}
