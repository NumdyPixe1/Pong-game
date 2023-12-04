using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    [SerializeField] private bool resetBall;
    public Goal goal;
    public Ball ball;
    public TextMeshProUGUI scoreP1Text, scoreP2Text;
    [SerializeField] private int scoreP1, scoreP2 = 0;
    void Start()
    {
        scoreP2Text.text = scoreP2.ToString();



    }

    void Update()
    {
        if (goal.isGoalP1)
        {
            scoreP1 += 1;
            goal.isGoalP1 = false; scoreP1Text.text = scoreP1.ToString();
            resetBall = true;
        }
        else if (goal.isGoalP2)
        {
            scoreP2 += 1;
            goal.isGoalP2 = false; scoreP2Text.text = scoreP2.ToString();
            resetBall = true;
        }
        if (resetBall)
        {
            ball.transform.position = new Vector2(0, 0);
            StartCoroutine(delay(0.5f));
        }
    }
    IEnumerator delay(float time)
    {
        while (resetBall == true)
        {
            yield return new WaitForSeconds(0.8f);
            resetBall = false;
        }
    }
}
