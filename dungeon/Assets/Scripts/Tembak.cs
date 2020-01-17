using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tembak : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject peluru;
    public GameObject kpeluru;
    
    void OnMouseDown()
    {
        Instantiate(peluru, kpeluru.transform.position, kpeluru.transform.rotation);
        
    }

}
