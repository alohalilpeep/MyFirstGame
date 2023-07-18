using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRotation : MonoBehaviour
{
    [SerializeField] private GameObject circle;
    [SerializeField] private float speed;
    private bool rightDirection;
    private void Rotation()
    {
        if (rightDirection)
        {
            circle.transform.Rotate(0, 0, speed * Time.deltaTime);
        }
        else
        {
            circle.transform.Rotate(0, 0, speed * Time.deltaTime * -1);
        }
    }
    void Update()
    {
        Rotation();
    }
    public void changeDirection()
    {
        rightDirection = !rightDirection;
    }
}
