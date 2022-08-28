using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PontosMove : MonoBehaviour
{
    static PontosMove Instancia;
    public int maxPoints = 8;
    public Text pointsText;
    public GameObject levelCompleteUI;
    private int points = 0;

    void Start(){
        Instancia = this;
    }
    void UpdatePointsText(){
        pointsText.text = points + "/" + maxPoints;
        if(points == maxPoints){
           levelCompleteUI.SetActive(true);
        }
    }
    public static void AddPoint(){
        AddPoints(1);
    }

    public static void AddPoints(int points){
        Instancia.points += points;
        Instancia.UpdatePointsText();
    }
}
