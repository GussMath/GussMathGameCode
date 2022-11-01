using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class TemaAudio : MonoBehaviour
{
    public Button btnPlay;
    public Text txtNomeTema;
     public Text txtInfoTema;
    public GameObject infoTema;
    public GameObject estrela1;
    public GameObject estrela2;
    public GameObject estrela3;
    public int numeroQuestoes;

    public string[] NomeTema;

    private int idTema;

    // Start is called before the first frame update
    void Start()
    {
        idTema = 0;
        txtNomeTema.text = NomeTema[idTema];
        txtInfoTema.text = "";
        infoTema.SetActive(false);
        estrela1.SetActive(false);
        estrela2.SetActive(false);
        estrela3.SetActive(false);
        btnPlay.interactable = false;
      
    }

  public void selecioneTema(int i){
    idTema = i;
    txtNomeTema.text = NomeTema[i];
    infoTema.SetActive(true);
    btnPlay.interactable = true;
    int acertos = 0;
  }

  public void jogar(){
    Application.LoadLevel("voice_scene_pergunta");
  }

  public void sair(){
    Application.LoadLevel("lvl_1");
  }
}
