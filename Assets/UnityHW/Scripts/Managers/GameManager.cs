using Assets.UnityHW.Scripts.Common.SignalBus;
using Assets.UnityHW.Scripts.Common.SignalBus.Signals;
using Assets.UnityHW.Scripts.Runtime.Location;
using Assets.UnityHW.Scripts.Runtime.Player;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.UnityHW.Scripts.Managers
{
    internal class GameManager : MonoBehaviour
    {
        [SerializeField] private List<Platform> _platforms;
        [SerializeField] private PlayerMovementHW2 _player;

        private void OnEnable()
        {
            SignalBus.Instance.Subscribe<JumpSignal>(ChangeColor);
        }

        private void OnDisable()
        {
            SignalBus.Instance.Unsubscribe<JumpSignal>(ChangeColor);
        }

        private void ChangeColor(JumpSignal signal)
        {
            for (int i = 0; i < _platforms.Count; i++)
            {
                _platforms[i].SpriteRenderer.color = Random.ColorHSV();
            }

            _player.SpriteRenderer.color = Random.ColorHSV();
        }
    }
}
