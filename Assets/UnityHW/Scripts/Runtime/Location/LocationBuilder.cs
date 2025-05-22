using Assets.UnityHW.Scripts.Runtime.Player;
using UnityEngine;

namespace Assets.UnityHW.Scripts.Runtime.Location
{
    public class LocationBuilder : MonoBehaviour
    {
        [SerializeField] private GameObject _prefab;

        private void Start()
        {
            GameObject testObject = Instantiate(_prefab, transform);
            testObject.name = "NewName";
            Rigidbody rigidbody = testObject.AddComponent<Rigidbody>();
            PlayerMovement movement = testObject.AddComponent<PlayerMovement>();
            
            movement.SetRigidbody(rigidbody);
            rigidbody.mass = 1000;
        }
    }
}