﻿using UnityEngine;

public class moveCar : MonoBehaviour {

  public float speed = 100;
  public Rigidbody2D rb;
void Start () {
  }
 void Update()
{
    float h = Input.GetAxis("Horizontal");
    float v = Input.GetAxis("Vertical");

    Vector3 tempVect = new Vector3(h, v, 0);
    tempVect = tempVect.normalized * speed * Time.deltaTime;
    rb.MovePosition(rb.transform.position + tempVect);
}
}