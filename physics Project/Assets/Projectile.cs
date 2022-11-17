using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public Rigidbody rb;

    public float startingForce;
    public float theta;
    public float gravity;

    private float deltaY;
    private float deltaX;


    public void GetDeltaY()
    {
        deltaY = startingForce * Mathf.Cos(theta) * Time.deltaTime;
    }

    public void GetDeltaX()
    {
        deltaX = startingForce * Mathf.Sin(theta) - gravity * Time.deltaTime;
    }

    public void luanch()
    {
        GetDeltaX();
        GetDeltaY();

        rb.AddForce(new Vector3(deltaX, deltaY, 0));

        Debug.Log(deltaY);
        Debug.Log(deltaX);

    }
}
