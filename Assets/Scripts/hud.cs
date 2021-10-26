using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hud : MonoBehaviour
{
    private float amount = 500.0f;
    private bool mensaje = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            if (mensaje == false)
                mensaje = true;
            else
                mensaje = false;
        }
        if (mensaje == true)
        {
            vibrar();
        }
    }

    void vibrar()
    {
        Vector3 newPos = Random.insideUnitSphere * (Time.deltaTime * amount);
        newPos.y = transform.position.y;
        newPos.z = transform.position.z;
        transform.position = newPos;
    }
}
