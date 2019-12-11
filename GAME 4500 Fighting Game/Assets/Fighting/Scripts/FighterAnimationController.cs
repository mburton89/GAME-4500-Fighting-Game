using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class FighterAnimationController : MonoBehaviour
{
    public SpriteRenderer currentFrame;

    public List<Sprite> idleSprites;
    public List<Sprite> lightPunchSprites;
    public List<Sprite> lightKickSprites;
    //public List<Sprite> strongPunchSprites;
    //public List<Sprite> strongKickSprites;
    public List<Sprite> jumpSprites;
    public Sprite blockSprite;

    public float idleFrameDuration = 0.25f;
    public float punchFrameDuration = 0.15f;
    public float blockFrameDuration = 0.25f;
    public float jumpDurationMultiplier = 2.5f;
    public float jumpHeight = 3.5f;

    public Ease jumpUpEase = Ease.OutCirc;
    public Ease jumpDownEase = Ease.InCirc;

    private Coroutine _currentCoroutine = null;
    private bool _canAttack;
    private bool _isBlocking;

    public void Start()
    {
        PlayIdleAnimation();
    }

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1) && _canAttack)
        {
            StopCoroutine(_currentCoroutine);
            PlayLightPunchAnimation();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2) && _canAttack)
        {
            StopCoroutine(_currentCoroutine);
            PlayLightKickAnimation();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3) && _canAttack)
        {
            StopCoroutine(_currentCoroutine);
            PlayBlockAnimation();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4) && _canAttack)
        {
            StopCoroutine(_currentCoroutine);
            PlayJumpAnimation();
        }
    }

    public void PlayIdleAnimation()
    {
        _currentCoroutine = StartCoroutine(IdleAnimation());
    }

    public void PlayLightPunchAnimation()
    {
        StartCoroutine(LightPunchAnimation());
    }

    public void PlayLightKickAnimation()
    {
        StartCoroutine(LightKickAnimation());
    }

    public void PlayBlockAnimation()
    {
        StartCoroutine(Block());
    }

    public void PlayJumpAnimation()
    {
        StartCoroutine(JumpAnimation());
    }

    private IEnumerator IdleAnimation()
    {
        _canAttack = true;
        currentFrame.sprite = idleSprites[0];
        yield return new WaitForSeconds(idleFrameDuration);
        currentFrame.sprite = idleSprites[1];
        yield return new WaitForSeconds(idleFrameDuration);
        currentFrame.sprite = idleSprites[2];
        yield return new WaitForSeconds(idleFrameDuration);
        PlayIdleAnimation();
    }

    private IEnumerator LightPunchAnimation()
    {
        _canAttack = false;
        currentFrame.sprite = lightPunchSprites[0];
        yield return new WaitForSeconds(punchFrameDuration);
        currentFrame.sprite = lightPunchSprites[1];
        yield return new WaitForSeconds(punchFrameDuration);
        currentFrame.sprite = lightPunchSprites[2];
        yield return new WaitForSeconds(punchFrameDuration);
        currentFrame.sprite = lightPunchSprites[3];
        yield return new WaitForSeconds(punchFrameDuration);
        PlayIdleAnimation();
    }

    private IEnumerator LightKickAnimation()
    {
        _canAttack = false;
        currentFrame.sprite = lightKickSprites[0];
        yield return new WaitForSeconds(punchFrameDuration);
        currentFrame.sprite = lightKickSprites[1];
        yield return new WaitForSeconds(punchFrameDuration);
        currentFrame.sprite = lightKickSprites[2];
        yield return new WaitForSeconds(punchFrameDuration);
        currentFrame.sprite = lightKickSprites[3];
        yield return new WaitForSeconds(punchFrameDuration);
        PlayIdleAnimation();
    }

    //private IEnumerator PlayPunchHeavy()
    //{
    //    _canAttack = false;
    //    currentFrame.sprite = strongPunchSprites[0];
    //    yield return new WaitForSeconds(punchFrameDuration);
    //    currentFrame.sprite = strongPunchSprites[1];
    //    yield return new WaitForSeconds(punchFrameDuration);
    //    currentFrame.sprite = strongPunchSprites[2];
    //    yield return new WaitForSeconds(punchFrameDuration);
    //    currentFrame.sprite = strongPunchSprites[3];
    //    yield return new WaitForSeconds(punchFrameDuration);
    //    currentFrame.sprite = strongPunchSprites[4];
    //    yield return new WaitForSeconds(punchFrameDuration);
    //    currentFrame.sprite = strongPunchSprites[5];
    //    yield return new WaitForSeconds(punchFrameDuration);
    //    PlayIdleAnimation();
    //}

    private IEnumerator JumpAnimation()
    {
        _canAttack = false;
        currentFrame.sprite = jumpSprites[0];
        yield return new WaitForSeconds(punchFrameDuration);
        currentFrame.sprite = jumpSprites[1];
        currentFrame.transform.DOMoveY(currentFrame.transform.position.y + jumpHeight, (punchFrameDuration * jumpDurationMultiplier), false).SetEase(jumpUpEase);
        yield return new WaitForSeconds(punchFrameDuration * jumpDurationMultiplier);
        currentFrame.transform.DOMoveY(currentFrame.transform.position.y - jumpHeight, (punchFrameDuration * jumpDurationMultiplier) / 2, false).SetEase(jumpDownEase);
        yield return new WaitForSeconds(punchFrameDuration * jumpDurationMultiplier);
        PlayIdleAnimation();
    }

    private IEnumerator Block()
    {
        _canAttack = false;
        _isBlocking = true;
        currentFrame.sprite = blockSprite;
        yield return new WaitForSeconds(blockFrameDuration);
        _isBlocking = false;
        PlayIdleAnimation();
    }
}
