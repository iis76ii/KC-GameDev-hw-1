using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string hero = "Hussein";
        int health = 100;
        int damaged = health - 20;
        int newhealth = damaged;
        int boost = 10;
        print("the hero’s name is " + hero + " he got into a figth with a villain and his health was " + health + " he got damaged that makes his health " + newhealth);
        int finalhealth = newhealth + boost;
        print("then a healer gave him a boost and healed him to make his health " + finalhealth + " then he won against the villain");
    }
}