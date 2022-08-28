using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIController : MonoBehaviour
{
    ControleUsuario controleUsuario;
    private string Nome;
    private int idade;
    public GameObject inputNome, display1;
    public GameObject inputIdade;
    public GameObject canva;
    private int t = 1;
    public Text txtMoeda;
   void Start(){
    controleUsuario = ControleUsuario.controleUsuario;
    
   }
   public void Save(){
    controleUsuario.Save();
   }
    public void Load(){
    controleUsuario.Load();
   }
  public void Textos(){
      Nome = inputNome.GetComponent<Text>().text;
      display1.GetComponent<Text>().text = Nome;
      idade = int.Parse(inputIdade.GetComponent<Text>().text);
      controleUsuario.SetNome(Nome);
      controleUsuario.SetIdade(idade);
     // controleUsuario.Sett(t,canva);
      Save();
  }
  public void moeda(){
    txtMoeda.text = controleUsuario.GetPontos().ToString();
  }

  public void Verificar(){
    
  }

}
