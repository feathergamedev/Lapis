using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestRobot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
            AudioManager.Instance.Init();

        if (Input.GetKeyDown(KeyCode.S))
            AudioManager.Instance.PlaySFX(ESoundEffectType.Success);

        if (Input.GetKeyDown(KeyCode.N))
            AudioManager.Instance.PlaySFX(ESoundEffectType.None);
    }
}
