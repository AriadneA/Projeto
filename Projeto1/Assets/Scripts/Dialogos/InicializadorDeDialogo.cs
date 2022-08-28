using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class InicializadorDeDialogo : MonoBehaviour
{
   [SerializeField]
   private GerenciadorDeDialogo gerenciador;
   [SerializeField]
   private Dialogo dialogo;
   public void Incializar()
   {
     if(gerenciador == null)
        return;
        gerenciador.Incializar(dialogo);
   }
}
