using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Dialogo1 : MonoBehaviour
{
    public TextAsset dialogo;
    public TextMeshProUGUI texto;
    public float sec;
    private Animator anim;
    private int selecionado;
    private string src;

    private void Start()
    {
      anim = GetComponent<Animator>();
    }
    public void showDialog(){
        anim.SetTrigger("open");
        selecionado = 0;
        src = dialogo.text.Split('\n')[selecionado];
        loadLetters();
    }
    public void loadLetters(){
      texto.text = "";
      char[] chars = src.ToCharArray();
      for(int i = 0; i< chars.Length; i++){
        StartCoroutine(getLetter(chars[i],i));
      }
    }
    public void nextDialog()
    { 
      if(dialogo.text.Split('\n')[selecionado].Length == selecionado)
      {

        endDialog();

      }else{
        selecionado++;
        src = dialogo.text.Split('\n')[selecionado];
        loadLetters();
        }
    }
    public void endDialog(){
      anim.SetTrigger("close");
      src = "";
      texto.text = "";
    }

    IEnumerator getLetter(char l, int x){
        yield return new WaitForSeconds(sec * x);
        texto.text += l.ToString();
    }
 }
