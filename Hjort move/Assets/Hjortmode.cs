using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Hjortmode : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator anim;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Movement.Hjortmode == true) {
            anim.SetBool("Hjortmode", true);
            RunMyMovement();

        }
    }

    public void  RunMyMovement() {
        if (Input.GetAxis("Horizontal") > 0.1 || Input.GetAxis("Horizontal") < -0.1)
        {
            anim.SetBool("Run", true);
            

        }
        else
            anim.SetBool("Run", false);

    //
    }
}
