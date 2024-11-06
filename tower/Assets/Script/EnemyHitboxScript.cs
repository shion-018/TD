using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHitboxScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (this.gameObject.CompareTag("frendly"))
        {
            Debug.Log("onhit");
            Vector2 pos = transform.position;
            pos.x += 0.015f;
            this.transform.position = pos;
        }
    }
}
