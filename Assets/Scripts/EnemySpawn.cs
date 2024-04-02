using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] List<Transform> enemySpawn;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(enemySpawner());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator enemySpawner()
    {
        while (true)
        {
            Vector3 spawnPos = enemySpawn[Random.Range(0, enemySpawn.Count)].position;
            GameObject.Instantiate(enemyPrefab, spawnPos, Quaternion.identity);


            yield return new WaitForSeconds(1f);
        }
    }


}