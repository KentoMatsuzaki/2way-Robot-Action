using UnityEngine;

/// <summary>�O�l�̎��_�J����</summary>

public class ThirdPersonCamera : MonoBehaviour
{
    /// <summary>�v���C���[�̈ʒu</summary>
    [SerializeField, Header("�v���C���[�̈ʒu")] private Transform _player;

    /// <summary>�v���C���[�Ƃ̋���</summary>
    [SerializeField, Header("�v���C���[�Ƃ̋���")] private float _distance;

    /// <summary>�J�������x</summary>
    [SerializeField, Header("�J�������x")] private float _sensitivity;

    /// <summary>Y���̍ŏ���]�p�x</summary>
    [SerializeField, Header("Y���̍ŏ���]�p�x")] private float _minAngleY;

    /// <summary>Y���̍ő��]�p�x</summary>
    [SerializeField, Header("Y���̍ő��]�p�x")] private float _maxAngleY;

    /// <summary>���݂�X�������̃}�E�X�ړ���</summary>
    private float _currentX;

    /// <summary>���݂�Y�������̃}�E�X�ړ���</summary>
    private float _currentY;

    /// <summary>�J�����̃I�t�Z�b�g</summary>
    private Vector3 _offset;

    private void Start()
    {
        // �J�����̈ʒu�������ݒ肷��
        _offset = new Vector3(0, 2.5f, -_distance);
    }

    private void Update()
    {
        // �}�E�X�̓��͂��󂯎��
        _currentX -= Input.GetAxis("Mouse X") * _sensitivity;
        _currentY -= Input.GetAxis("Mouse Y") * _sensitivity;

        // Y���̉�]�p�x�𐧌�����
        _currentY = Mathf.Clamp(_currentY, _minAngleY, _maxAngleY);
    }

    private void LateUpdate()
    {
        Quaternion rotation = Quaternion.Euler(_currentY, _currentX, 0);
        Vector3 targetPosition = _player.position + rotation * _offset;

        transform.position = targetPosition;
        transform.LookAt(new Vector3(_player.position.x, _player.position.y + 1f, _player.position.z));
    }
}