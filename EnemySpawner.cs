using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Enemy enemyPefab;

    Enemy enemy;

    public void Spawn()
    {
        if(enemy==null)
        {
            enemy = Instantiate(enemyPefab, transform.position, transform.rotation);
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
