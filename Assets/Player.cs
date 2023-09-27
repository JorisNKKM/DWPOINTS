using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tra : MonoBehaviour
{

    private void Update()
    {
        if (Input.GetKey(KeyCode.D)) 
        {
            transform.Translate(0.1f, 0, 0);
        }

    }
}
