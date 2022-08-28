using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class peca : MonoBehaviour, IPointerDownHandler, IBeginDragHandler,  IEndDragHandler,  IDragHandler
{
   [SerializeField] private RectTransform pos;
   private Vector2 posInicial, posSlot;
    public gerenciador g;
    private bool noSlot = false;
    private int i=0;
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioClip _grab;
    [SerializeField] private AudioClip _drop;

   public void OnPointerDown(PointerEventData eventData){
      posInicial = pos.anchoredPosition;
      Debug.Log("Apertou!");
   }
   public void OnDrag(PointerEventData eventData){
      pos.anchoredPosition += eventData.delta;
   }
   public void OnBeginDrag(PointerEventData eventData){
      _audioSource.clip = _grab;
      _audioSource.Play();
      Debug.Log("Inicio drag");
   }
   public void OnEndDrag(PointerEventData eventData){
      if(noSlot == true){
         pos.anchoredPosition = posSlot;
         gameObject.GetComponent<Image>().raycastTarget = false;//bloqueia a interação do mouse
         g.i += 1;
         GameController.AddPoint();
      }else if(noSlot == false){
         pos.anchoredPosition = posInicial;
      }
      _audioSource.clip = _drop;
       _audioSource.Play();
      Debug.Log("Fim drag");
   }
    private void OnTriggerEnter2D(Collider2D col){
       if(gameObject.name == col.gameObject.name){
        posSlot = col.GetComponent<RectTransform>().anchoredPosition;
        noSlot = true;
       } else if(gameObject.name != col.gameObject.name){
         i += 1;
        Debug.Log("Slot errado");
       }
      
    }
}
