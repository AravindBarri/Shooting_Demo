using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    int score = 0;
    public GameObject EnemyObject;
    private void Start()
    {
        //Invoke("EnemySpawn", 5.0f);
        EnemySpawn();
    }
    private void Update()
    {
        //Invoke("EnemySpawn", 5.0f);
    }

    private void EnemySpawn()
    {
        int xcount = Random.Range(-5, 6);
        int zcount = Random.Range(-5, 6);
        var position = new Vector3(xcount, 1.5f, zcount);
        Instantiate(EnemyObject, position, Quaternion.identity);
    }

    public void ScoreCalculator(int value)
    {
        score+=value;
        print("The Score is " + score);
    }
}
