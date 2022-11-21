using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapSideways : MonoBehaviour
{
    [Header ("Movement and Damage")]
    [SerializeField] private float MovementDistance;
    [SerializeField] private float Speed;
    [SerializeField] private float Damage;

    //Edge
    private bool movingLeft;
    private float leftEdge;
    private float rightEdge;

    private void Awake()
    {
        leftEdge = transform.position.x - MovementDistance;
        rightEdge = transform.position.x + MovementDistance;
    }

    private void Update()
    {
        if (movingLeft)
        {
            if (transform.position.x > leftEdge)
            {
                transform.position = new Vector3(transform.position.x - Speed * Time.deltaTime, transform.position.y, transform.position.z);
            }
            else
                movingLeft = false;
        }
        else
        {
            if (transform.position.x < rightEdge)
            {
                transform.position = new Vector3(transform.position.x + Speed * Time.deltaTime, transform.position.y, transform.position.z);
            }
            else
                movingLeft = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            collision.GetComponent<Health>().TakeDame(Damage);
        }
    }
}
