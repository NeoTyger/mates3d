using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BichoMovement : MonoBehaviour
{

//Hacer que el bicho se mueva y los brazos suban y bajen


    private GameObject brazo1;

    // Start is called before the first frame update
    void Start()
    {
        brazo1 = GameObject.Find("Braç 1");
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            brazo1.transform.Translate(new Vector3(1,0,0) * Time.deltaTime);
        }
        
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime);
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime);
        }
       
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime);
        }
       
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime);
        }
    }
}
