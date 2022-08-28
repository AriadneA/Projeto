using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesativaCanva : MonoBehaviour
{
  private bool testeD = false; 
  public GameObject canva;
  void Awake()
    {
        if(testeD == false){
        }else{
          DontDestroyOnLoad(gameObject);
          Desativa();
        }
        
    }
  public void Desativa(){
    if(testeD == true){
    gameObject.SetActive(false);
   } else{
  }
}
}