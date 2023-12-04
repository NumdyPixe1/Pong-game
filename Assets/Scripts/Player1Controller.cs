using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Controller : MonoBehaviour
{
    public Vector2 direction;
    Rigidbody2D rigidbody2D;
    [SerializeField] private float playerSpeed = 20f;
    //   [SerializeField] private GameObject p1, p2;
    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        float moveMent = Input.GetAxisRaw("Vertical1");
        rigidbody2D.velocity = new Vector2(0f, moveMent) * playerSpeed;
    }
}
