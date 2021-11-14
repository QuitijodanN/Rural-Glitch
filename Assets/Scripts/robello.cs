using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class robello : MonoBehaviour {


    [SerializeField]
    private Text pickUpText;

    private bool pickUpAllowed;
   
    private int contador;
    public Text ContadorRobello;


    // Use this for initialization
    private void Start()

    {
        
        pickUpText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    private void Update()
    {
        if (pickUpAllowed && Input.GetKeyDown(KeyCode.E))
            PickUp();
            
            
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Collectible")
        {
            pickUpText.gameObject.SetActive(true);
            pickUpAllowed = true;
            
            
        }
        

    }
    
    private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Collectible")
        { 
            pickUpText.gameObject.SetActive(false);
            pickUpAllowed = false;
            
        }
        

    }

    private void PickUp()
    {
        contador++;
        //Destroy(collision.gameObject);
        ContadorRobello.text = contador.ToString();
    }


}