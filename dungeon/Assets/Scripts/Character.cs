using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    // Start is called before the first frame update
    public int kecepatan;
    public bool balik;
    public int pindah;
    public bool Tkiri;
    public bool Tkanan;
    public bool Tatas;
    public bool Tbawah;
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {

        //Animasi Gerakan
        if(Tkanan==true || Tkiri==true){
            anim.SetBool("MSamping",true);

        }
        else{
            anim.SetBool("MSamping", false);
        }
        if(Tbawah==true){
            anim.SetBool("MDepan",true);

        }
        else{
            anim.SetBool("MDepan", false);
        }
        if(Tatas==true||Input.GetKey(KeyCode.W)){
            anim.SetBool("MBelakang",true);

        }
        else{
            anim.SetBool("MBelakang", false);
        }
        //Akhir Animasi Gerakan

        if(Input.GetKey(KeyCode.D)||(Tkanan==true)){
            transform.Translate(Vector2.right*kecepatan*Time.deltaTime);
            pindah=-1;
        }
        else if(Input.GetKey(KeyCode.A) || (Tkiri==true)){
            transform.Translate(Vector2.right*-kecepatan*Time.deltaTime);
            pindah=1;
        }
        if(Input.GetKey(KeyCode.W)||(Tatas==true)){
            transform.Translate(Vector2.up*kecepatan*Time.deltaTime);
            pindah=-1;
        }
        else if(Input.GetKey(KeyCode.S)||(Tbawah==true)){
            transform.Translate(Vector2.up*-kecepatan*Time.deltaTime);
            pindah=1;
        }
        
        if(pindah> 0 && !balik){
            balikbadan();
        }
        else if(pindah< 0 && balik){
            balikbadan();
        }
    }

    void balikbadan(){
        balik = !balik;
        Vector3 karakter = transform.localScale;
        karakter.x *= -1;
        transform.localScale = karakter;
    }
    public void TeKiri(){
        Tkiri = true;
    }
    public void LeKiri(){
        Tkiri = false;
    }
    public void TeKanan(){
        Tkanan = true;
    }
    public void LeKanan(){
        Tkanan = false;
    }
    public void TeAtas(){
        Tatas = true;
    }
    public void LeAtas(){
        Tatas = false;
    }
    public void TeBawah(){
        Tbawah = true;
    }
    public void LeBawah(){
        Tbawah = false;
    }
}
