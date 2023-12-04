using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour
{
    Rigidbody2D rigidbody2D;
    [SerializeField] private float playerSpeed = 20f;
    //   [SerializeField] private GameObject p1, p2;
    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        float moveMent = Input.GetAxisRaw("Vertical2");
        rigidbody2D.velocity = new Vector2(0f, moveMent) * playerSpeed;
    }
}
