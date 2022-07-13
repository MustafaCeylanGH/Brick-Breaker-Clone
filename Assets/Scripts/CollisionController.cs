using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionController : MonoBehaviour
{
    [SerializeField] private Sprite brokeBrick;

   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Reset"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if(collision.gameObject.CompareTag("Red Brick"))
        {
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("Blue Brick") && collision.gameObject.GetComponent<SpriteRenderer>().sprite == brokeBrick)
        {
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("Blue Brick"))
        {
            collision.gameObject.GetComponent<SpriteRenderer>().sprite = brokeBrick;          
        }
    }
}
