using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnd : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void start()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
