using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendScore : MonoBehaviour
{
    public int EnemyScore = 1;
    
    private void OnCollisionEnter(Collision collision)
    {
        print(collision.gameObject.tag);
        if(collision.gameObject.CompareTag("Enemy"))
        {
            print(collision.gameObject.tag);
            Score scrobj = FindObjectOfType<Score>();
            scrobj.ScoreCalculator(EnemyScore);
            Destroy(collision.gameObject, 2.0f);
        }
        
    }
}
