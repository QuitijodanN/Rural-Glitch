using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InteraccionTienda : MonoBehaviour
{
    public GameObject Texto;
    public bool cerca = false;



    void Update()
    {
        if (cerca)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene("Tienda");
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Texto.SetActive(true);
        cerca = true;

    }

    void OnTriggerExit2D(Collider2D other)
    {
        Texto.SetActive(false);
        cerca = false;
    }
}