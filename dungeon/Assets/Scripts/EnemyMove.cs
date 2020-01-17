using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    // Start is called before the first frame update
    
    public float speed;
    public float sd;
    public float rd;
    private Transform player;
    public GameObject gameOver;

    void Start()
    {
        gameOver.SetActive(false);
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance(transform.position,player.position)>sd){
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }
        else if(Vector2.Distance(transform.position, player.position)<sd && Vector2.Distance(transform.position, player.position)>rd){
            transform.position = this.transform.position;
        }
        else if(Vector2.Distance(transform.position, player.position)<rd){
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed*Time.deltaTime);
        }
        
    }

    void OnTriggerEnter2D(Collider2D other){
        if (other.transform.tag=="Player"){
            Destroy(player.gameObject);
            gameOver.SetActive(true);
        }
    }
}
