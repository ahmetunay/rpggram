using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealBar : MonoBehaviour
{
    public GameObject HealtBar;
    public float Hp = 100;


    void Start()
    {

    }
        void Update()
        {
                HealtBar.transform.GetChild(0).transform.GetChild(0).transform.localScale = new Vector3(Hp / 100, 1, 1);
           
        if (Hp >= 100)
            {
                Hp = 100;
            }
            if (Hp <= 0)
            {
                Hp = 0;
            }
        }
}



