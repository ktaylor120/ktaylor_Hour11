using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    public GameObject prefab;

    private void Start()
    {
        for (var i = 0; i < 10; i++)
        Instantiate(prefab, new Vector3(i * 2.0f, 0, 0), Quaternion.identity);

    }
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(prefab);
        }
       if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }
}
