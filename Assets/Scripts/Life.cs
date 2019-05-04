using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    public float initialVelocity = -0.6f;
    public int count;


    private Rigidbody2D rigb;

    void Awake()
    {

        rigb = GetComponent<Rigidbody2D>();

    }

    void Update()
    {
        transform.parent = null;
        transform.Translate(new Vector2(initialVelocity, 0));
        //StartCoroutine(live());


    }


    /*IEnumerator live()
    {
        yield return new WaitForSeconds(4.0f);
        Destroy(this.gameObject);
    }*/

}
