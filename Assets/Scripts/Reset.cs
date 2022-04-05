using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    private bool reset;
    private Rigidbody2D player;
    // Start is called before the first frame update
    void Start()
    {

        reset = false;
        player = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player.transform.position.y <-10)
        {
            reset=true;
        }
    }

    private void FixedUpdate()
    {
        if(reset==true)
        {
            player.transform.position = new Vector3(0, 1, 0);

            reset = false;
        }
    }
}
