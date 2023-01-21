using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

namespace TMPro.Examples
{
    
    public class ButtonBehavior : MonoBehaviour
    {

        private TextMeshPro m_textMeshPro;
        //private TMP_FontAsset m_FontAsset;

        private const string label = "The <#0050FF>count is: </color>{0:2}";
        private float m_frame;

        public TMP_Text scoreText;

        public void OnButtonPressed()
        {
            //if(scoreText.text.Equals("Button Pressed"))
            //{
            //    scoreText.text = "Button pressed again";
            //}
            //else
            //{
            //    scoreText.text = "Button Pressed";
            //}


            if(SceneManager.GetActiveScene().name.Equals("SampleScene"))
            {
                SceneManager.LoadScene("Level 1");
                return;
            }
            if (SceneManager.GetActiveScene().name.Equals("Level 1"))
            {
                SceneManager.LoadScene("SampleScene");
                return;
            }

        }

        //void Start()
        //{
        //    // Add new TextMesh Pro Component
        //    m_textMeshPro = gameObject.AddComponent<TextMeshPro>();

        //    m_textMeshPro.autoSizeTextContainer = true;

        //    // Load the Font Asset to be used.
        //    //m_FontAsset = Resources.Load("Fonts & Materials/LiberationSans SDF", typeof(TMP_FontAsset)) as TMP_FontAsset;
        //    //m_textMeshPro.font = m_FontAsset;

        //    // Assign Material to TextMesh Pro Component
        //    //m_textMeshPro.fontSharedMaterial = Resources.Load("Fonts & Materials/LiberationSans SDF - Bevel", typeof(Material)) as Material;
        //    //m_textMeshPro.fontSharedMaterial.EnableKeyword("BEVEL_ON");

        //    // Set various font settings.
        //    m_textMeshPro.fontSize = 48;

        //    m_textMeshPro.alignment = TextAlignmentOptions.Center;

        //    //m_textMeshPro.anchorDampening = true; // Has been deprecated but under consideration for re-implementation.
        //    //m_textMeshPro.enableAutoSizing = true;

        //    //m_textMeshPro.characterSpacing = 0.2f;
        //    //m_textMeshPro.wordSpacing = 0.1f;

        //    //m_textMeshPro.enableCulling = true;
        //    m_textMeshPro.enableWordWrapping = false;

        //    //textMeshPro.fontColor = new Color32(255, 255, 255, 255);
        //}


        //void Update()
        //{
        //    m_textMeshPro.SetText(label, m_frame % 1000);
        //    m_frame += 1 * Time.deltaTime;
        //}

    }
}
