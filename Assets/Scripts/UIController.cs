using UnityEngine;
using UnityEngine.UIElements;

public class UIController : MonoBehaviour
{
    VisualElement root;

    
    void Start()
    {
        
        root = GetComponent<UIDocument>().rootVisualElement;
        Button startButton = root.Q<Button>("continueButton");
        startButton.clickable.clicked += OnContinueButtonClick;
    }

     
    void OnContinueButtonClick()
    {
        
        gameObject.SetActive(false);
    }
}
