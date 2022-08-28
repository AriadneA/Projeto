using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{ 
   /* private int pointsToWin = 3;
    public GameObject Itens;
    private int currentPont;
    void Start(){
      
    }

    void Update(){
     if(currentPont >= pointsToWin){
       Itens.SetActive(true);
     }
    }
   public void AddPoints(){
     currentPont++;
   }

*/



   public GameObject levelCompleteUI;
    static GameController Instancia;
    public int maxPoints = 3;

    private int points = 0;

    void Start(){
        Instancia = this;
    }
    void UpdatePoints(){
        if(points == maxPoints){
        levelCompleteUI.SetActive(true);
        }
    }
    public static void AddPoint(){
        AddPoints(1);
    }

    public static void AddPoints(int points){
        Instancia.points += points;
        Instancia.UpdatePoints();
    }
}

