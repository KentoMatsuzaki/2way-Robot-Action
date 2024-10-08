using UnityEngine;

/// <summary>追跡カメラ</summary>

public class FollowCamera : MonoBehaviour
{
    /// <summary>プレイヤーの位置</summary>
    [SerializeField, Header("プレイヤーの位置")] private Transform _player;

    /// <summary>カメラのオフセット</summary>
    [SerializeField, Header("カメラのオフセット")] private Vector3 _offset;

    /// <summary>マウスの操作感度</summary>
    private float _mouseSensitivity;

    /// <summary>マウスの入力を受け取る変数</summary>
    private float _mouseX;

    private void Start()
    {
        // マウスの操作感度を取得する
        _mouseSensitivity = _player.gameObject.GetComponent<PlayerRotateHandler>().MouseSensitivity;
    }

    private void Update()
    {
        // マウスの入力を受け取る
        _mouseX += Input.GetAxis("Mouse X") * _mouseSensitivity;
    }

    private void LateUpdate()
    {
        // 回転を計算する
        Quaternion rotation = Quaternion.Euler(0, _mouseX, 0);

        // カメラの新しい位置を計算する
        Vector3 newPos = _player.position + rotation * _offset;

        // カメラを新しい位置に移動させる
        transform.position = newPos;

        // カメラが常にプレイヤーの背面を向くようにする
        transform.LookAt(new Vector3(_player.position.x, _player.position.y + 1.25f, _player.position.z));
    }
}
