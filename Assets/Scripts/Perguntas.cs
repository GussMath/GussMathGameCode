using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Perguntas : MonoBehaviour
{
    public Text pergunta;
    public Text InputResposta;
    public Text qtdPerguntas;
    public Text erros;
    public Text acertos;

    public string[] perguntas;
    public string[] respostasCorretas;

    private int nAcertos;
    private int nErros;
    private int idPerguntas;

    // Start is called before the first frame update
    void Start()
    {
        erros.text = "erros = 0";
        acertos.text = "acertos = 0";
        idPerguntas = 0;
        int questoes = perguntas.Length;
        print(questoes);
        pergunta.text = perguntas[idPerguntas];
    }

    public void responder(){
       
        if(idPerguntas < perguntas.Length){
            string resposta = InputResposta.text;
            if(resposta == respostasCorretas[idPerguntas]){
                nAcertos += 1;
                acertos.text = "acertos = "+ nAcertos;
            }else{
                nErros += 1;
                erros.text = "erros = "+ nErros;
            }
            InputResposta.text = "";
            print(idPerguntas);
            proximaPergunta();
        }
        else{
            PlayerPrefs.SetInt("acertos",  nAcertos);
            Application.LoadLevel("quiz_scene_nota");
        }
    }
    // Update is called once per frame
    public void proximaPergunta(){
        int questoes = perguntas.Length;
        idPerguntas +=1 ;
        pergunta.text = perguntas[idPerguntas];
        
    }
    
}
