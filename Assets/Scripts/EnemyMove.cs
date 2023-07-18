using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] private GameObject enemy;
    [SerializeField] private float speed;
    private void Update()
    {
        Move();
    }
    private void Move()
    {
        enemy.transform.Translate(speed * Time.deltaTime, 0, 0);
    }
}
