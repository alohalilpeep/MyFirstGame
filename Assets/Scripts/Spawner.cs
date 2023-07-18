using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] Vector2 range;
    [SerializeField] GameObject enemy;
    [SerializeField] float timeForSpawn;
    [SerializeField] private AudioSource EnemySpawn;
    public Transform spawnPos;
    
    private void Start()
    {
        StartCoroutine(Spawn());
    }
    
    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(timeForSpawn);
        Vector2 pos = spawnPos.position + new Vector3(0, Random.Range(-range.y, range.y));
        Instantiate(enemy, pos, Quaternion.identity);
        EnemySpawn.Play();
        Repeat();
    }
    private void Repeat()
    {
        StartCoroutine(Spawn());
    }
}
