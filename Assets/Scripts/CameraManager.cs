using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class CameraManager : MonoBehaviour
{
    public  float speedCamera = 5;

    //map
    TileMap map;

    //Restrictions
    public float rMax;
    public float lMax;
    public float uMax;
    public float dMax;

    private void Start()
    {
        map = GameObject.FindObjectOfType<TileMap>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveH = Input.GetAxis("Horizontal");
        float moveV = Input.GetAxis("Vertical");

        Vector3 mvmtD = new Vector3(moveH, moveV, 0);

        if (transform.position.x > rMax)
        {
            transform.position = new Vector3(rMax, transform.position.y, -2);
        }
        if (transform.position.x < lMax)
        {
            transform.position = new Vector3(lMax, transform.position.y, -2);
        }
        if (transform.position.y > uMax)
        {
            transform.position = new Vector3(transform.position.x, uMax, -2);
        }
        if (transform.position.y < dMax)
            transform.position = new Vector3(transform.position.x, dMax, -2);

        transform.position = transform.position + mvmtD * speedCamera * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Restrictions")
        {
            Debug.Log("ola");
            speedCamera = .00000000000000000000000000000000000001f;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Restrictions")
        {
            speedCamera = 5;
        }
    }
}
