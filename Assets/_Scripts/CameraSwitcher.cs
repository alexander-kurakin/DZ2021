using Cinemachine;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera[] _cinemachineCameras;

    public void RandomSwitchCamera()
    {
        int activeCameraIndex = Random.Range(0, _cinemachineCameras.Length);

        for (int i = 0; i < _cinemachineCameras.Length; i++)
        {
            if (i == activeCameraIndex)
                _cinemachineCameras[i].Priority = 10;
            else
                _cinemachineCameras[i].Priority = 0;
        }
    }
}
