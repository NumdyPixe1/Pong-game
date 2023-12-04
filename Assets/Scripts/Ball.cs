using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private float ballSpeed = 5f;
    [SerializeField] private Rigidbody2D rigidbody2D;
    // Start is called before the first frame update
    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        Launch();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Launch()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;

        rigidbody2D.velocity = new Vector2(x, y) * ballSpeed;
    }
}
