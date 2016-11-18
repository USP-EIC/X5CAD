using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class TextScript : MonoBehaviour {

    public Text texto;
    public string nome;
    private bool TorF= false;
    public float wait = 0f;
    void Start()
    {
        texto.guitext = nome; 
    }
    void Update()
    {

        wait += Time.deltaTime;

        if (TorF == true && wait < 5.0f )
        {
            texto.enabled = true;
        }
        else
        {
            texto.enabled = false;
        }
    
    }
    void OnTriggerEnter(Collider other)  
    {
        if(other.gameObject.tag == "Player")
        {
            TorF = true;
            wait = 0f; 
        }
    }


	
}
