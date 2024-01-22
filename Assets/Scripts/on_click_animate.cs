using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class on_click_animate : MonoBehaviour
{

    Animator anim;
    bool a_Active;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        a_Active = false;
    }
    void Update()
    {
    }

    public void ObjectWasClicked()
    {

        if (a_Active)
        {
            anim.ResetTrigger("active");
            a_Active = false;
        }
        else
        {
            anim.SetTrigger("active");
            a_Active = true;
        }
    }
}
