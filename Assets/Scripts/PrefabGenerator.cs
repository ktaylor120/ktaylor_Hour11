using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    public GameObject prefab;

    private void Start()
    {
        Instantiate(prefab, new Vector3(1, 1, 1), Quaternion.identity);
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
