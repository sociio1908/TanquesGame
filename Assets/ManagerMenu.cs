using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Diagnostics;


public class ManagerMenu : MonoBehaviour
{
 
    public void ScenaJuego(){
        
        SceneManager.LoadScene("Principal");
    } 
    
    public void VolverMenu(){
        
        SceneManager.LoadScene("MenuInicial");
    }

   public void SalirJuego(){
        
    System.Diagnostics.Debug.Write("ENTRO AL METODO");
    Application.Quit();
    }


}
