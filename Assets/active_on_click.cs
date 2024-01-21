using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class active_on_click : MonoBehaviour
{

    Animator anim;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }
    void Update()
    {
    }

    public void ObjectWasClicked()
    {
        anim.SetTrigger("active");

    }
}
