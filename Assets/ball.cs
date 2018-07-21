using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
public class ball : MonoBehaviour
{
    public Rigidbody2D rb;
    public float ballForce;
    bool gameStarted = false;
    // Use this for initialization
    public UiManager ui;
    
    void Start()
    {
        ui = GameObject.FindWithTag("ui").GetComponent<UiManager>();
       
           
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space) && gameStarted == false)
        {

            transform.SetParent(null);
            rb.isKinematic = false;

            rb.AddForce(new Vector2(ballForce, ballForce));
            gameStarted = true;

        }

        



    }
    void OnCollisionEnter2D(Collision2D col)
    {
       
        if (col.gameObject.tag == "dl")
        {
       

           // ui.LoseLife();
            ui.Declive();
           // Destroy(gameObject);



            //  Instantiate(gameObject);

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
          

            // SceneManager.LoadScene("leve1");






        }





    }
}
