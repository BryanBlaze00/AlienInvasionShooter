using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{

    void Start()
    {

    }

    void Update()
    {
        float horizontalMove = Input.GetAxis("Horizontal");
        float verticalalMove = Input.GetAxis("Vertical");

        Debug.Log(horizontalMove);
        Debug.Log(verticalalMove);
    }
}
