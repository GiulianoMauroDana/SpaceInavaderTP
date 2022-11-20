using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject bullet;
    public Transform spawnpoint;

    public float shotForce;
    public float shotRate;
    public float shotRange;

    private float shotRateTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (Time.time>shotRateTime)
            {
                GameObject newBullet;

                newBullet = Instantiate(bullet, spawnpoint.position, spawnpoint.rotation);
                         
            }
        }
    }
}
