using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletmovement : MonoBehaviour
{
    public float velocidad;
    private Rigidbody2D rb2d;
    public float distancia; 

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = 0;

        for (int i = 0; i < distancia; i++)
        {

            Vector2 movimiento = new Vector2(inputX, 0);
            inputX++;
            rb2d.transform.Translate(movimiento * velocidad * Time.deltaTime);
                        
        }
    }
}
