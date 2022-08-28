using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Itens : MonoBehaviour
{
  private LineRenderer lineRend;
  private Vector2 mousePos;
  private Vector2 startMousePos;
  void Start(){
    lineRend = GetComponent<LineRenderer>();
    lineRend.positionCount = 2;
  }
    void Update(){
        if(Input.GetMouseButtonDown(0)){
           startMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        if(Input.GetMouseButton(0)){
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
    }
}
