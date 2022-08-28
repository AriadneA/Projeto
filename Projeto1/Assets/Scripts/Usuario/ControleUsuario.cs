using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

[Serializable]
class Data{
public string Nome;
public int idade;
public int pont;
//public bool testeD = false;
public float volume;
public int t;
}
public class ControleUsuario : MonoBehaviour
{
    public static ControleUsuario controleUsuario;
    private string Nome;
    private int pont;
    private int idade;
    private int t;
    private string filePath;

    void Awake()
    {
        if(controleUsuario == null){
            controleUsuario = this;
        }else{
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
        filePath = Application.persistentDataPath + "/players"+Nome;
        Debug.Log(filePath);
    }
     public void Save(){
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(filePath);
        Data data = new Data();
        data.Nome = Nome;
        data.pont = 10;
        data.idade = idade;
        bf.Serialize(file,data);
        Debug.Log("salvouuu");
        file.Close();
     }
     public void Load(){
        if(File.Exists(filePath + "/players"+Nome)){
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Open(filePath , FileMode.Open);
        Data data = (Data)bf.Deserialize(file);
        Nome = data.Nome;
        pont = data.pont;
        idade = data.idade;
        Debug.Log("Load");
        }
     }
   public void SetNome(string valor){
       Nome = valor;
   }
   public void SetIdade(int valor){
       idade = valor;
   }
   public void Setpont(int valor){
       idade += valor;
   }
   public void Sett(int valor, GameObject canva){
       t += valor;
       if(t>0){
       canva.SetActive(false);
       }
   }
    public string GetNome(){
       return Nome;
    }
     public int GetPontos(){
       return pont;
    }
}
