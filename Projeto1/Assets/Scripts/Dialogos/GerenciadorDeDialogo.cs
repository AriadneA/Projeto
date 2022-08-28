using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
public class GerenciadorDeDialogo : MonoBehaviour
{
   [SerializeField]
   private TextMeshProUGUI NomeNPC;
   [SerializeField]
   private TextMeshProUGUI Texto;
   [SerializeField]
   private TextMeshProUGUI BtContinuar;
   [SerializeField]
   private GameObject caixaDialogo;

   private int contador = 0;
   private Dialogo dialogoAtual;

   public void Incializar(Dialogo dialogo)
   {
     contador = 0;
     dialogoAtual = dialogo;
     ProximaFrase();
   }
   public void ProximaFrase()
   {
      if(dialogoAtual == null)
      return;
      if(contador == dialogoAtual.GetFrases().Length){
         caixaDialogo.gameObject.SetActive(false);
         dialogoAtual = null;
         contador = 0;
         return;
      }

      NomeNPC.text = dialogoAtual.GetNomeNPC();
      Texto.text = dialogoAtual.GetFrases()[contador].GetFrase();
      BtContinuar.text = dialogoAtual.GetFrases()[contador].GetBotaoContinuar();
      caixaDialogo.gameObject.SetActive(true);
      contador++;
   }
}
