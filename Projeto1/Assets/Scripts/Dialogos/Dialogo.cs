using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
[Serializable]
public class Dialogo 
{
   [SerializeField]
   private TextoDialogo[] frases;
   [SerializeField]
   private string nomeNPC;

   public TextoDialogo[] GetFrases()
   { 
       return frases;
   }
   public string GetNomeNPC()
   { 
       return nomeNPC;
   }
}
