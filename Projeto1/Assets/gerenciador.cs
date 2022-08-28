using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gerenciador : MonoBehaviour
{
   public int i = 0;
   [SerializeField] private GameObject atv, prox;
    public GameObject[] objetos;
   
    void Start(){
        objetos = GameObject.FindGameObjectsWithTag("Slot");
   }
    void Update()
    { 
        if(i == objetos.Length){
         MudarCena();
        }
    }

    public void MudarCena(){
   
     atv.SetActive(false);
     prox.SetActive(true);
    }
     
}
