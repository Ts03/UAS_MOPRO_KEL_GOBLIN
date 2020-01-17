using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
   public void Ganti(){
       SceneManager.LoadScene("GamePlay");
   }
   public void Quitgame(){
       Application.Quit();
   }
}
