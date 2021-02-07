using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

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

    [Button(Name = "測試音效")]
    public void PlaySoundEffect()
    {
        AudioManager.Instance.PlaySFX(ESoundEffectType.Success);
    }

    [Button]
    public void CameraFadeIn(float time = 1f)
    {
        CameraManager.Instance.StartFadeIn(time);
    }

    [Button]
    public void SetFadeInColor(Color color)
    {
        CameraManager.Instance.SetFadeInColor(color);        
    }

    [Button]
    public void SetFadeOutColor(Color color)
    {
        CameraManager.Instance.SetFadeOutColor(color);
    }

    [Button]
    public void CameraFadeOut(float time = 1f)
    {
        CameraManager.Instance.StartFadeOut(time);
    }
}
