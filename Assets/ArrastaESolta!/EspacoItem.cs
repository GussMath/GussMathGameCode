using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class EspacoItem : MonoBehaviour, IDropHandler {

    public void OnDrop(PointerEventData eventData) {
        Debug.Log("OnDrop");
        if (eventData.pointerDrag != null) {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;

            //if(Number5.gameObject.tag == "Resposta1"){
            //Debug.Log("entrou");
            //}
        }
        }

        void OnTriggerEnter(Collider other)
     {
         if (other.transform.tag == "Resposta1")
            Debug.Log("entrou");
     }
    }


