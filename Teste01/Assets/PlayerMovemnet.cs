  using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovemnet : MonoBehaviour
{
    Rigidbody2D rb;

    [SerializeField] float speed = 5f;
    public float reductionRadius = 1.0f;

    float mx;
    float my;
    Vector2 movimento;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {

        Vector3 mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        movimento = new Vector2(mousePos.x - transform.position.x, mousePos.y - transform.position.y);
        transform.up = movimento;
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(mx, my).normalized * speed;
    }
}
