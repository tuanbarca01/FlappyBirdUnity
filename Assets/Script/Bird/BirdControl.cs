using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BirdControl : MonoBehaviour
{

    public float speed;
    public float force;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip flyBird, scoreBird, dieBird;
    public static BirdControl Instance;
    private GameObject spawner;
    public float flag = 0;
    private int score;
    public Text scoreText;

    private void Awake()
    {
        MakeInstance();
        spawner = GameObject.Find("SpawnerBamboo");
        score = 0;
    }
    void MakeInstance()
    {
        if(Instance == null)
        {
            Instance = this;
        }
    }
    /*void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }*/

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * force);
            
    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
        score += 1;
        scoreText.text = score.ToString();
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Bamboo")
        {
            Destroy(spawner);
            flag= 1;
            Destroy(GetComponent<Rigidbody2D>());
            audioSource.PlayOneShot(dieBird);
        }
    }

}
