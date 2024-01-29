using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb2d;
    public static bool Hjortmode = false
    speed = 10
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

  
    void Update()
    {
        if(Hjortmode = false)
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetKeyDown(KeyCode.Space);
            rb2d.transform.position += new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);
        }

        if (Input.GetKeyDown(KeyCode.f){
            Hjortmode = true;
        }
    
    }
}
