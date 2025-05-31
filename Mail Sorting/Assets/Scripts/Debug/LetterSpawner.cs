using UnityEngine;
using mailsorting.items;

namespace mailsorting.debug
{
    public class LetterSpawner : MonoBehaviour
    {
        [SerializeField] private Mail mailPrefab;

        [Header("Settings")]
        [SerializeField] private InputReader inputReader;

        private void OnEnable() {
            inputReader.test1Event += OnTest1;
        }

        private void OnDisable() {
            inputReader.test1Event -= OnTest1;
        }

        private void OnTest1() {
            Instantiate(mailPrefab, Vector3.zero, Quaternion.identity);
        }
    }
}
