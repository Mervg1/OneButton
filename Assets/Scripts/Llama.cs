using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Llama : MonoBehaviour
{
    public bool llamaDown;
    public int lives;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            if (llamaDown == false)
            {
                Vector3 pos1 = new Vector3(-9.54f, -2.61f, 0);
                llamaDown = true;
                transform.position = pos1;

            }
            else
            {
                Vector3 pos2 = new Vector3(-9.54f, 2.61f, 0);
                llamaDown = false;
                transform.position = pos2;
            }
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Bean")
        {
            Game.instance.UpLife();
        }
        else if(collision.tag == "Flower"){
            Game.instance.UpScore();
        }
        else
        {
            Game.instance.LoseLife();
        }
    }
}
