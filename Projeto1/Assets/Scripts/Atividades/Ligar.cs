using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Ligar : MonoBehaviour
{
    private LineRenderer lr;
    public List<Transform> pontos = new List<Transform>();
    public Transform ultimoPonto;
    private string itemName;
    
    void Awake()
    {
     lr = GetComponent<LineRenderer>();
     lr.positionCount = 3;
    }
   private void fazerLinha(Transform Ponto1, Transform Ponto2){
       if(Ponto1.name == Ponto2.name){
         pontos.Add(Ponto1);
         lr.enabled = true;
         SetupLine();
        
      }else{
        
      } 
   }
   private void SetupLine(){
    int pontoTamanho = lr.positionCount;
    for(int i = 0; 1 < pontoTamanho; i++){
      lr.SetPosition(i,pontos[i].position);
    }
   }
    //int pontoTamanho = pontos.Count;
    //lr.positionCount = 2;
    //for(int i = 0; 1 < pontoTamanho; i++){
    //lr.SetPosition(i,pontos[i].position);
    //}

    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(worldPoint, Vector2.zero);
            if(Input.GetMouseButton(0)){
             Vector2 Point = Camera.main.ScreenToWorldPoint(Input.mousePosition);
             RaycastHit2D hite = Physics2D.Raycast(Point, Vector2.zero);
              itemName = hite.collider.name;
            if (hit.collider && hite.collider != null){
              fazerLinha(hit.collider.transform, hite.collider.transform);
              print(hit.collider.name);
            }
        }
        
    }
   
}
}