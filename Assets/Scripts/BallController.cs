using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float forceSpeed;        
    [SerializeField] private GameObject ballPoint;
    private bool ballOnShooter = true;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        BallStayControl();
        MouseDownControl();
    }


    private void MouseDownControl()
    {
        if (ballOnShooter)
        {
            if (Input.GetMouseButtonDown(0))
            {
                ballOnShooter = false;
                rb.velocity = Vector2.up * forceSpeed;
            }
        }
      
    }

    private void BallStayControl()
    {
        if (ballOnShooter)
        {
            transform.position = ballPoint.transform.position;
        }        
    }
    
}
