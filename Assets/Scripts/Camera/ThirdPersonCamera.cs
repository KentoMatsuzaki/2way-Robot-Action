using UnityEngine;

/// <summary>三人称視点カメラ</summary>

public class ThirdPersonCamera : MonoBehaviour
{
    /// <summary>プレイヤーの位置</summary>
    [SerializeField, Header("プレイヤーの位置")] private Transform _playerPos;

    /// <summary>プレイヤーとの距離</summary>
    [SerializeField, Header("プレイヤーとの距離")] private float _distance;

    /// <summary>カメラ感度</summary>
    [SerializeField, Header("カメラ感度")] private float _sensitivity;

    /// <summary>Y軸の最小回転角度</summary>
    [SerializeField, Header("Y軸の最小回転角度")] private float _minAngleY;

    /// <summary>Y軸の最大回転角度</summary>
    [SerializeField, Header("Y軸の最大回転角度")] private float _maxAngleY;

    /// <summary>現在のX軸方向のマウス移動量</summary>
    private float _currentX;

    /// <summary>現在のY軸方向のマウス移動量</summary>
    private float _currentY;

    /// <summary>カメラのオフセット</summary>
    private Vector3 _offset;

    private void Start()
    {
        // カメラの位置を初期設定する
        _offset = new Vector3(0, 3f, -_distance);
    }
}