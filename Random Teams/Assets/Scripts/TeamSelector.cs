using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TeamSelector : MonoBehaviour
{
    public Animator leftAnimator;
    public GameObject image;

    public void LeftButtons()
    {
       // leftAnimator.SetBool("isSelected", true);
        image.transform.DOMoveX(image.transform.position.x - 100, 3);
    }
}
