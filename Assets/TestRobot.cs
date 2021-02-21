using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lapis.Utilities;

public class TestRobot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        CameraFadeIn();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlaySoundEffect()
    {
        AudioManager.Instance.PlaySFX(ESoundEffectType.Success);
    }

    public void CameraFadeIn(float time = 1f)
    {
        CameraEffectController.Instance.StartFadeIn(time);
    }

    public void SetFadeInColor(Color color)
    {
        CameraEffectController.Instance.SetFadeInColor(color);        
    }

    public void SetFadeOutColor(Color color)
    {
        CameraEffectController.Instance.SetFadeOutColor(color);
    }

    public void CameraFadeOut(float time = 1f)
    {
        CameraEffectController.Instance.StartFadeOut(time);
    }
}
