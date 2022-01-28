using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPlayer : MonoBehaviour
{
    private int spawnPoint = 1;
    private Vector3 spawnPoint1 = new Vector3(0, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnPoint == 1){
            if (transform.position.y < -14){
                Debug.Log("fallen");
                gameObject.transform.localPosition = spawnPoint1;
            }
        }
    }
}
