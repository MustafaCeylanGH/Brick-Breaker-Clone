using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterController : MonoBehaviour
{
    private Vector3 mousePos;
    private float boundaryX = 7.85f;
       

    private void Update()
    {
        ShooterMove();
    }
    private void ShooterMove()
    {
        mousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, transform.position.y, transform.position.z));

        mousePos.x= Mathf.Clamp(mousePos.x, -boundaryX, boundaryX);

        transform.position = new Vector3(mousePos.x, transform.position.y, transform.position.z);
    }

  
}
