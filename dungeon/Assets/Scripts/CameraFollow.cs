using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    void FixedUpdate (){
        transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);
    }
    public void Ganti(){
       SceneManager.LoadScene("MainMenu");
   }
}
