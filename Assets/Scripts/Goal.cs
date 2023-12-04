using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public bool isGoalP1, isGoalP2;
    public GameObject goalP1;
    public GameObject goalP2;
    void Start()
    {

    }

    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D ballCol)
    {
        if (ballCol.gameObject.CompareTag("GoalP1"))
        {
            isGoalP1 = true;
        }
        if (ballCol.gameObject.CompareTag("GoalP2"))
        {
            isGoalP2 = true;
        }

    }
}
