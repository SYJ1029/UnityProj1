using System;
using UnityEngine;
using UnityEngine.Animations;

public class LookAtManager : MonoBehaviour
{
    Camera maincamera;
    LookAtConstraint LookAtConstraint;
    public GameObject[] targetObject;

    int activeIndex = 0;
    public Vector3 cameraOffset = new Vector3(0, 5, -10);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        maincamera = GetComponent<Camera>();
        LookAtConstraint = GetComponent<LookAtConstraint>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad2))
        {

            activeIndex = 0;

            targetObject[0].SetActive(true);
            targetObject[1].SetActive(false);
            // Source 갱신
            if (LookAtConstraint != null)
            {
                LookAtConstraint.locked = false;

                // 기존 소스 제거
                for (int i = LookAtConstraint.sourceCount - 1; i >= 0; i--)
                {
                    LookAtConstraint.RemoveSource(i);
                }

                // 새로운 소스 추가
                ConstraintSource source = new ConstraintSource
                {
                    sourceTransform = targetObject[0].transform,
                    weight = 1f
                };
                LookAtConstraint.AddSource(source);

                LookAtConstraint.constraintActive = true;
                LookAtConstraint.locked = true;
            }
        }
    }
}
