using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public GameObject death;
    public GameObject game;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Respawn"))
        {
            Debug.Log("Bam");
            death.SetActive(true);
            game.SetActive(false);
            Time.timeScale = 0;
            
        }
        
    }
}
