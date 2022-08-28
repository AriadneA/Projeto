using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Move: MonoBehaviour, IPointerDownHandler, IDragHandler , IPointerEnterHandler, IPointerUpHandler{ 
static Move houverItem;

public GameObject linePrefab;
public string itemName;

private GameObject line;

public void OnPointerDown(PointerEventData eventData){
  line = Instantiate(linePrefab, transform.position, Quaternion.identity, transform.parent.parent);
  UpdateLine(eventData.position);
}
  public void OnDrag(PointerEventData eventData){
   UpdateLine(eventData.position);
  }

  public void OnPointerUp(PointerEventData eventData){
     if(!this.Equals(houverItem) && itemName.Equals(houverItem.itemName)){
        UpdateLine(houverItem.transform.position);
        Destroy(houverItem);
        Destroy(this);
        PontosMove.AddPoint();
     }else{
       Destroy(line);
     }
  }
  public void OnPointerEnter(PointerEventData eventData){
    houverItem = this;
  }
  void UpdateLine(Vector3 position){
     Vector3 direction = position - transform.position;
     line.transform.right = direction;
     line.transform.localScale = new Vector3(direction.magnitude, 1, 1);
  }
}


   