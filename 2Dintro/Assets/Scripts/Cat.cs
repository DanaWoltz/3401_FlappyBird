using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cat : MonoBehaviour
{
    public float catSpeed;
    public Rigidbody2D catRigid;
    public GameObject gameOverUI;
    public int score;
    public AudioSource point;
    public AudioSource flap;
    public AudioSource die;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            catRigid.AddForce(Vector2.up * catSpeed);
            flap.Play();

            Debug.Log("cat really do be flying tho");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Score")
        {
            score += 1;
            Debug.Log(score);
            point.Play();
        }
        else
        {
            //Debug.Log("dead :/");
            gameOverUI.SetActive(true);
            die.Play();
            Time.timeScale = 0;
        }
        
    }
}
