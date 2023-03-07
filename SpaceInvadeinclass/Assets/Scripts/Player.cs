using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
  private Rigidbody2D rb;
  private Vector2 direction;
  public GameObject bullet;
  public float speed = 10f;

  public Transform shottingOffset;
    // Update is called once per frame
    private void Awake()
    {
      rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Space))
      {
        GameObject shot = Instantiate(bullet, shottingOffset.position, Quaternion.identity);
        //Debug.Log("Bang!");

        Destroy(shot, 10f);

      }
      
      float horizontalVal = Input.GetAxis("Horizontal");
      direction = Vector2.right * horizontalVal;

    }
    private void FixedUpdate()
    {
      if (direction.sqrMagnitude != 0)
      {
        rb.AddForce(direction * speed);
      }
    }
    
}
