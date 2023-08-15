using TMPro;
using UnityEngine;

namespace DefaultNamespace
{
    public class Disappears : MonoBehaviour
    {
        [SerializeField] private float _maxDistance;
    
        private InteractableObjectController _interactableObjectController;

        private void Awake()
        {
            _interactableObjectController = gameObject.GetComponentInParent<InteractableObjectController>();
        }
        
        public void OnPointerEnter()
        {
            if (Vector3.Distance(_interactableObjectController.Character.position, transform.position) < _maxDistance)
            {
                // Destroy(gameObject);
                gameObject.SetActive(false);
            }
        }
    }
}