using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class ObsBamBoo : MonoBehaviour
{
    [SerializeField] private float speedObs;
    private GameObject Obs;

    private void Start()
    {
        //StartCoroutine(speedUp());
    }
    // Update is called once per frame
    void Update()
    {
        if (BirdControl.Instance != null) { 
            if(BirdControl.Instance.flag == 1)
            {
                Destroy(GetComponent<ObsBamBoo>());
            }
        }
        ObsMove();
    }
    void ObsMove()
    {
        Vector3 temp= transform.position;
        temp.x -= speedObs * Time.deltaTime;
        transform.position = temp;
    }
    /*IEnumerator speedUp()
    {
        yield return new WaitForSeconds(8f);
        Time.timeScale += 0.3f;
        StartCoroutine(speedUp());
    }*/

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Destroy")
        {
            Destroy(gameObject);
        }
    }

}
