using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject enemyOnePrefab;
    public GameObject enemyTwoPrefab;
    public GameObject enemyThreePrefab;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateEnemyOne", 1.0f, 3.0f);
        InvokeRepeating("CreateEnemyTwo", 2.0f, 2.0f);
        InvokeRepeating("CreateEnemyThree", 3.0f, Random.Range(1.0f, 5.0f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateEnemyOne()
    {
        Instantiate(enemyOnePrefab, new Vector3(Random.Range(-8, 8), 7, 0), Quaternion.identity);
    }

    void CreateEnemyTwo()
    {
        Instantiate(enemyTwoPrefab, new Vector3(10, Random.Range(2, 5), 0), Quaternion.identity);
    }

    void CreateEnemyThree()
    {
        Instantiate(enemyThreePrefab, new Vector3(8, Random.Range(-8, 6), 0), Quaternion.identity);
    }
}
