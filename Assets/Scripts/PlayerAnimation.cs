using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerAnimation : MonoBehaviour
{
    Shooting shooting;
    ActivateMirrors activateMirrors;
    [SerializeField] Image playerUI;
    [SerializeField] SpriteRenderer playerSprite;
    [SerializeField] Sprite spellSpriteUI;
    [SerializeField] Sprite idleSpriteUI;
    [SerializeField] Sprite spellSprite;
    [SerializeField] Sprite idleSprite;
    // Start is called before the first frame update
    void Start()
    {
        shooting = GetComponent<Shooting>();
        activateMirrors = GetComponent<ActivateMirrors>();
    }

    // Update is called once per frame
    void Update()
    {
        if (shooting.enabled || activateMirrors.enabled)
        {
            playerSprite.sprite = spellSprite;
            playerUI.sprite = spellSpriteUI;
        }
        else
        {
            playerSprite.sprite = idleSprite;
            playerUI.sprite = idleSpriteUI;
        }
    }
}
