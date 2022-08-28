using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class TextoDialogo
{
 [SerializeField]
 [TextArea(1,4)]
 private string frase;
 [SerializeField]
 private string BtContinuar;
 
 public string GetFrase()
 {
    return frase;
 }
 public string GetBotaoContinuar()
 {
    return BtContinuar;
 }
 
}
