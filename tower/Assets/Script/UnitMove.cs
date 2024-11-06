using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.CompareTag("frendly"))
        {
            FrendliUnitMove();
        }

        if (this.gameObject.CompareTag("enemy"))
        {
            EnemyUnitMove();
        }
    }

    void FrendliUnitMove()
    {
        Vector2 pos = transform.position;
        pos.x += 0.005f;
        this.transform.position = pos;
    }

    void EnemyUnitMove()
    {
        Vector2 pos = transform.position;
        pos.x -= 0.005f;
        this.transform.position = pos;
    }
}
