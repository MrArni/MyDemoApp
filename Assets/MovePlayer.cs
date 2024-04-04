using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float 
        moveSpeed = 5f;

    void Update()
    {
        float 
            horizontalInput = Input.GetAxis("Horizontal"),
            verticalInput = Input.GetAxis("Vertical");
        Vector3 
            direction = new Vector3(horizontalInput, 0.0f, verticalInput);

        transform.Translate(direction * moveSpeed * Time.deltaTime);
    }
}
