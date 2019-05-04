using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteoroSpawner : MonoBehaviour
{
    public GameObject enemy, point, Life;

    public float spawnRate = 0.5f;

    float nextSpawn = 0f;
    Vector2 whereToSpawn;

    int whatToSpawn;
    int rand;



    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            whatToSpawn = Random.Range(1, 3);
            rand = Random.Range(1,7);
            //Instansiate the enemy
            if (rand < 4)
            {
                if (whatToSpawn == 1)
                {
                    whereToSpawn = new Vector2(8.86f, 2.56f);
                }
                else
                {
                    whereToSpawn = new Vector2(8.86f, -2.56f);
                }

                Game.instance.Enemy(enemy, whereToSpawn, Quaternion.identity);

            }
            //Instanciate the flower
            else if (rand == 4 || rand == 6)
            {
                if (whatToSpawn == 1)
                {
                    whereToSpawn = new Vector2(8.86f, 2.56f);
                }
                else
                {
                    whereToSpawn = new Vector2(8.86f, -2.56f);
                }

                Game.instance.Flower(point, whereToSpawn, Quaternion.identity);
            }
            //Instanciate the bean
            else
            {
                if (whatToSpawn == 1)
                {
                    whereToSpawn = new Vector2(8.86f, 2.56f);
                }
                else
                {
                    whereToSpawn = new Vector2(8.86f, -2.56f);
                }
            
                Game.instance.Bean(Life, whereToSpawn, Quaternion.identity);
            }

        }


    }



}
