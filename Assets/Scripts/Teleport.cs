using UnityEngine;

public class Teleport : MonoBehaviour
{
    [SerializeField] private Renderer _renderer;

    private InteractableObjectController _interactableObjectController;

    private void Awake()
    {
        _interactableObjectController = gameObject.GetComponentInParent<InteractableObjectController>();
    }

    public void OnPointerClick()
    {
        TeleportCharacter();
    }

    public void OnPointerExit()
    {
        _renderer.material.color = Color.white;
    }

    public void OnPointerEnter()
    {
        _renderer.material.color = Color.blue;
    }

    private void TeleportCharacter()
    {
        _interactableObjectController.TeleportCharacter(transform.position + new Vector3(0, 1, 0));
    }
}