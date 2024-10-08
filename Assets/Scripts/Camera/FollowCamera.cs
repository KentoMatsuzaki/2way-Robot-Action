using UnityEngine;

/// <summary>�ǐՃJ����</summary>

public class FollowCamera : MonoBehaviour
{
    /// <summary>�v���C���[�̈ʒu</summary>
    [SerializeField, Header("�v���C���[�̈ʒu")] private Transform _player;

    /// <summary>�J�����̃I�t�Z�b�g</summary>
    [SerializeField, Header("�J�����̃I�t�Z�b�g")] private Vector3 _offset;

    /// <summary>�}�E�X�̑��슴�x</summary>
    private float _mouseSensitivity;

    /// <summary>�}�E�X�̓��͂��󂯎��ϐ�</summary>
    private float _mouseX;

    private void Start()
    {
        // �}�E�X�̑��슴�x���擾����
        _mouseSensitivity = _player.gameObject.GetComponent<PlayerRotateHandler>().MouseSensitivity;
    }

    private void Update()
    {
        // �}�E�X�̓��͂��󂯎��
        _mouseX += Input.GetAxis("Mouse X") * _mouseSensitivity;
    }

    private void LateUpdate()
    {
        // ��]���v�Z����
        Quaternion rotation = Quaternion.Euler(0, _mouseX, 0);

        // �J�����̐V�����ʒu���v�Z����
        Vector3 newPos = _player.position + rotation * _offset;

        // �J������V�����ʒu�Ɉړ�������
        transform.position = newPos;

        // �J��������Ƀv���C���[�̔w�ʂ������悤�ɂ���
        transform.LookAt(new Vector3(_player.position.x, _player.position.y + 1.25f, _player.position.z));
    }
}
