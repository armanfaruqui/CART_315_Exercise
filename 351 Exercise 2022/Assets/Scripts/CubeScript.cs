using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    public float rotationSpeed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
      
    }
    public void Rotate1()
    {
          if (Input.GetKeyDown(KeyCode.R))
        {
             this.GetComponent<Transform>().Rotate(0, rotationSpeed, 0);
        }
    }

    public void Rotate2()
    {
            if (Input.GetKeyDown(KeyCode.T))
        {
             this.GetComponent<Transform>().Rotate(0, -rotationSpeed, 0);
        }
    }
}
