using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SimpleUiContllor : MonoBehaviour
{
   [SerializeField] private Button RedButton;
   [SerializeField] private Button BlueButton;
   [SerializeField] private TextMeshProUGUI text;

    private void OnEnable()
    {
        RedButton.onClick.AddListener(SetRedText);
        BlueButton.onClick.AddListener(SetBlueText);
    }
    private void OnDisable()
    {
        RedButton.onClick.RemoveListener(SetRedText);
        BlueButton.onClick.RemoveListener(SetBlueText);
    }
    //테스트용 임시구현해보는목적으로만 쓰는방식public
    public void SetRedText()
    {

        if (this.text != null)
        {
            this.text.text = "RED"; 
        }
    }
    public void SetBlueText()
    {

        if (this.text != null)
        {
            this.text.text = "BLUE";
        }
    }
}
