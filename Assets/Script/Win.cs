using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Win : MonoBehaviour
{
    [SerializeField]
    public TextMeshProUGUI collect;
    public int collecting = 12;
    public GameObject winz;
    public GameObject ingamez;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.name.Equals("Coin"))
        {
            Debug.Log("Hit");
            collecting = collecting - 1;
            collect.text = collecting.ToString();
            //gameObject.SetActive(false);

        }
        if (collecting <= 0)
        {
            Debug.Log("Win");
            winz.SetActive(true);
            winz.SetActive(true);
            ingamez.SetActive(false);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    
}
