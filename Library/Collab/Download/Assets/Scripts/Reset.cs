using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    float x, y;
    private bool reset;
    private Rigidbody2D player;
    // Start is called before the first frame update
    void Start()
    {
        x = transform.eulerAngles.x;
        y = transform.eulerAngles.y;
        Vector3 v3;
        v3.x = 0;
        v3.y = 0;
        transform.eulerAngles = v3;
        reset = false;
        player = GetComponent<Rigidbody2D>();
        GetComponent<Rotation>().transform.parent = transform;
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
