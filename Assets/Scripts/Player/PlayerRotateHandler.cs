using UnityEngine;

/// <summary>プレイヤーの回転を制御するクラス</summary>
public class PlayerRotateHandler : MonoBehaviour
{
    /// <summary>マウスの操作感度</summary>
    [SerializeField, Header("マウスの操作感度")] private float _mouseSensitivity;

    public float MouseSensitivity => _mouseSensitivity;

    /// <summary>マウスの入力を保存する変数</summary>
    private float _mouseX;

    private void Update()
    {
        // マウスの入力を受け取る
        _mouseX += Input.GetAxis("Mouse X") * _mouseSensitivity;

        // プレイヤーを回転させる
        transform.rotation = Quaternion.Euler(0, _mouseX, 0);
    }
}
