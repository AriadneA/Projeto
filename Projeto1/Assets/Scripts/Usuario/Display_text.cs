using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Display_text : MonoBehaviour
{
    public string theName; 
    public GameObject display;
    public GameObject input;
 
    ControleUsuario controleUsuario;
    
    public void Create()
    {
        //obj_text.text = PlayerPrefs.GetString("nome");
       // 
       //controleUsuario.Save();
        theName = input.GetComponent<Text>().text;
        display.GetComponent<Text>().text = theName;
        //obj_text.text = controleUsuario.GetNome().ToString();
       //obj_text.text = display.text;
    }
}
