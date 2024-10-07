using UnityEngine;

/// <summary>追跡カメラ</summary>

public class FollowCamera : MonoBehaviour
{
    /// <summary>プレイヤーの位置</summary>
    [SerializeField, Header("プレイヤーの位置")] private Transform _player;

    /// <summary>プレイヤーとの距離</summary>
    [SerializeField, Header("プレイヤーとの距離")] private float _distance;

    /// <summary>カメラのオフセット</summary>
    private Vector3 _offset;

    private void Start()
    {
        // カメラの位置を初期設定する
        _offset = new Vector3(0, 1.25f, -_distance);
    }

    private void LateUpdate()
    {
        // カメラの位置をプレイヤーの背後に設定
        transform.position = _player.position + _offset;

        // カメラが常にプレイヤーの背面を向くようにする
        transform.LookAt(new Vector3(_player.position.x, _player.position.y + 1.25f, _player.position.z));
    }
}
