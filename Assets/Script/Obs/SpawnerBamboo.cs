using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBamboo : MonoBehaviour
{

    [SerializeField]
    private GameObject Obs;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawner());
    }

    IEnumerator Spawner()
    {
        yield return new WaitForSeconds(2.5f);
        Vector3 temp = Obs.transform.position;
        temp.y = Random.Range(-1, 2.5f);
        Instantiate(Obs, temp, Quaternion.identity);
        StartCoroutine(Spawner());
    }
}
