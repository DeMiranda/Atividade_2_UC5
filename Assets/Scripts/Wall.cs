using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Wall : MonoBehaviour
{
    
   


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (this.gameObject.tag == "quad")
        {

            
            GameObject myPlayer = GameObject.FindWithTag("Player");
            myPlayer.GetComponent<Player>().qtdMuros++;
            Destroy(this.gameObject);
            // Código CORRETO para controle de versão Atividade 2 



        }
    }
}
 