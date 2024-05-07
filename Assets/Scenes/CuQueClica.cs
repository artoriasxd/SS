using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class CuQueClica : MonoBehaviour
{
    [SerializeField] TMP_Text dialogMessage;
    [SerializeField] int i;
    [SerializeField] AudioSource fezes;
    // Start is called before the first frame update
    void Start()    
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       


        if (Input.GetMouseButtonDown(0))
        {
            i++;
            print(i);

            fezes.Play();










        }
        dialogMessage.text = i.ToString();  
    }
}
