using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class karakterAnim : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R)){
            animator.SetBool("sarjorDegistir",true);
        }
        else{
            animator.SetBool("sarjorDegistir",false);
        }

    }
}
