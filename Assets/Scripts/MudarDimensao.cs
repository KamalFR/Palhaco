using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MudarDimensao : MonoBehaviour
{
    [SerializeField] GameObject Mundo1;
    [SerializeField] GameObject Mundo2;
    [SerializeField] GameObject Player;
    [SerializeField] private Sprite feliz;
    [SerializeField] private Sprite triste;
    private bool estaFeliz;
    void Start()
    {
        estaFeliz = true;
        Mundo1.SetActive(true);
        Mundo2.SetActive(false);
        Player.GetComponent<SpriteRenderer>().sprite = feliz;  
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            if (estaFeliz)
            {
                Mundo1.SetActive(false);
                Mundo2.SetActive(true);
                Player.GetComponent<SpriteRenderer>().sprite = triste;
                estaFeliz = false;
            }
            else
            {
                Mundo1.SetActive(true);
                Mundo2.SetActive(false);
                Player.GetComponent<SpriteRenderer>().sprite = feliz;
                estaFeliz = true;
            }
        }
    }
}
