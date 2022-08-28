using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Name : MonoBehaviour
{
    public Text NomeText;
    ControleUsuario controleUsuario;
    Display_text Display;
    void Start()
    {   
        controleUsuario = ControleUsuario.controleUsuario;
        NomeText.text = controleUsuario.GetNome();
    }   
}
       // controleUsuario = ControleUsuario.controleUsuario;
      //  controleUsuario.Load();
        //NomeText.text = controleUsuario.GetNome().ToString();
       // NomeText.text = Display.obj_text.ToString();