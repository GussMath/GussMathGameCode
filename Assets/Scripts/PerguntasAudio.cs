using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PerguntasAudio : MonoBehaviour
{
    public Text InputResposta;
    public Text qtdPerguntas;
    
    public AudioSource[] bgmAudios;
    public string[] perguntas;
    public string[] respostasCorretas;

    private int nAcertos;
    private int nErros;
    private int idPerguntas;
    private int indice;

    // Start is called before the first frame update
    void Start()
    {
        indice = 0;
        idPerguntas = 0;
    }

    public void responder(){
       
        if(indice < bgmAudios.Length){
            string resposta = InputResposta.text;
            if(resposta == respostasCorretas[indice]){
                nAcertos += 1;
            }else{
                nErros += 1;
            }
            InputResposta.text = " ";
            print(indice);
            proximaPergunta();
        }
        else{
            PlayerPrefs.SetInt("acertos",  nAcertos);
            Application.LoadLevel("quiz_scene_nota");
        }
    }
    // Update is called once per frame
    public void proximaPergunta(){
        indice +=1 ;
    }

    public void clicarBotao(){
        bgmAudios[indice].Play();
    }
    
}
