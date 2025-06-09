using System;
using UnityEngine;
using UnityEngine.Animations;

public class GameManager : MonoBehaviour
{
    Camera maincamera;
    PositionConstraint positionConstraint;
    public GameObject[] targetObject;

    int activeIndex = 0;
    public Vector3 cameraOffset = new Vector3(0, 5, -10);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        maincamera = GetComponent<Camera>();
        positionConstraint = GetComponent<PositionConstraint>();
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
            if (positionConstraint != null)
            {
                positionConstraint.locked = false;

                // 기존 소스 제거
                for (int i = positionConstraint.sourceCount - 1; i >= 0; i--)
                {
                    positionConstraint.RemoveSource(i);
                }

                // 새로운 소스 추가
                ConstraintSource source = new ConstraintSource
                {
                    sourceTransform = targetObject[0].transform,
                    weight = 1f
                };
                positionConstraint.AddSource(source);

                positionConstraint.constraintActive = true;
                positionConstraint.locked = true;
            }
        }
    }
}
