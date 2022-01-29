using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteController : MonoBehaviour
{
    [SerializeField] bool isWhiteCat;
    private SpriteRenderer spriteRenderer;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if(!isWhiteCat && !WorldState.Instance.isInUpperWorld) {
            spriteRenderer.enabled = true;
        } else {
            spriteRenderer.enabled = false;
        }

        if(isWhiteCat) {
            if(!WorldState.Instance.isInUpperWorld) {
                spriteRenderer.enabled = false;
            } else {
                spriteRenderer.enabled = true;
            }

            if(PlayerState.Instance.isFacingRight) {
                spriteRenderer.flipX = false;
            } else {
                spriteRenderer.flipX = true;
            }
        }
    }
}
