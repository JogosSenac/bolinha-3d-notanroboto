using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class naoauentomUA : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveH = Input.GetAxis("Horizontal");
        moveV = Input.GetAxis("Vertical");

        transform.position += new Vector3(
                                          moveV * velocidade * Time.deltaTime, 0,
                                           -1, moveH * velocidadwe * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(transform.up * forcaPaulo, ForceMode.Impulse);
        }
    }
}
