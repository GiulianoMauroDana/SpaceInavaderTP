using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientobala : MonoBehaviour
{
    Rigidbody2D bala;
    float velocidad = 10f;

    // Start is called before the first frame update
    void Start()
    {
        bala = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        bala.MovePosition(bala.position + Vector2.up *velocidad* Time.fixedDeltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("pared"))
        {           
            this.gameObject.SetActive(false);
        }
    }
}
