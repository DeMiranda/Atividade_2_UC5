using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class Player : MonoBehaviour {

    private Animator anim;
    public Text Count;
    public int qtdMuros;




    // Use this for initialization
    void Start () {

        anim = GetComponent<Animator>(); 
       
    }
	
	// Update is called once per frame
	void Update () {

     

        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("shot");
           



        }

        Count.text = qtdMuros + " walls";
        Debug.Log(qtdMuros);

    }
}
