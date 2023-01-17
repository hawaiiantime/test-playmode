using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleUpdateScript : MonoBehaviour
{
    /// <summary>
    /// 経過時間の保持
    /// </summary>
    private float timeElapsed;

    /// <summary>
    /// 移動先座標
    /// </summary>
    private Vector3 toPosition;

    void Start()
    {
    }

    void Update()
    {
        if (this.transform.position != toPosition)
        {
            // 徐々に移動先へと向かう
            timeElapsed += Time.deltaTime / 100.0f;
            this.transform.position = Vector3.Lerp(this.transform.position, toPosition, timeElapsed);
        }
    }

    /// <summary>
    /// 移動先座標を設定して移動開始する
    /// </summary>
    public void MoveToPosition(Vector3 a_ToPosition)
    {
        timeElapsed = 0.0f;
        toPosition = a_ToPosition;
    }
}
