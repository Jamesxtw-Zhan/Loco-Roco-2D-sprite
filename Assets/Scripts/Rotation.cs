using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rotation>().transform.parent = transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
            transform.RotateAround(transform.position, Vector3.forward , 2);

        if (Input.GetKeyDown(KeyCode.RightArrow))
            transform.RotateAround(transform.position, Vector3.forward ,-2);
        
        
    }
}
