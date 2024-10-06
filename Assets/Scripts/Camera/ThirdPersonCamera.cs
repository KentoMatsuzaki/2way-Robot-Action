using UnityEngine;

/// <summary>�O�l�̎��_�J����</summary>

public class ThirdPersonCamera : MonoBehaviour
{
    /// <summary>�v���C���[�̈ʒu</summary>
    [SerializeField, Header("�v���C���[�̈ʒu")] private Transform _playerPos;

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
}