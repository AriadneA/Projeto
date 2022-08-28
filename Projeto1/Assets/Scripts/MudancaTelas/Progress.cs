using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Progress : MonoBehaviour
{
  public string cenaACarregar;
  public Slider slider;
  public float TempoFixoSeg;
  private float progresso;

 void Start () 
 {
   StartCoroutine (TempoFixo (cenaACarregar));
  
 }
  IEnumerator TempoFixo(string cena)
  {
  yield return new WaitForSeconds (TempoFixoSeg);
  SceneManager.LoadScene (cena);
 }

 void Update () {
  
  progresso = Mathf.Clamp((Time.time / TempoFixoSeg),0.0f,1.0f)* 10.0f;
  slider.value = progresso;

 }
}
