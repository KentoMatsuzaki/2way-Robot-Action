using UnityEngine;

/// <summary>�ǐՃJ����</summary>

public class FollowCamera : MonoBehaviour
{
    /// <summary>�v���C���[�̈ʒu</summary>
    [SerializeField, Header("�v���C���[�̈ʒu")] private Transform _player;

    /// <summary>�v���C���[�Ƃ̋���</summary>
    [SerializeField, Header("�v���C���[�Ƃ̋���")] private float _distance;

    /// <summary>�J�����̃I�t�Z�b�g</summary>
    private Vector3 _offset;

    private void Start()
    {
        // �J�����̈ʒu�������ݒ肷��
        _offset = new Vector3(0, 1.25f, -_distance);
    }

    private void LateUpdate()
    {
        // �J�����̈ʒu���v���C���[�̔w��ɐݒ�
        transform.position = _player.position + _offset;

        // �J��������Ƀv���C���[�̔w�ʂ������悤�ɂ���
        transform.LookAt(new Vector3(_player.position.x, _player.position.y + 1.25f, _player.position.z));
    }
}
