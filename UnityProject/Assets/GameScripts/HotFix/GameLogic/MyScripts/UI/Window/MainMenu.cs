using UnityEngine;
using UnityEngine.UI;
using TEngine;

namespace GameLogic
{
    [Window(UILayer.UI,location:"MainMenu")]
    class MainMenu : UIWindow
    {
        #region �ű��������ɵĴ���
        private Image m_img_bg;
        private Button m_btn_start;
        public override void ScriptGenerator()
        {
            m_img_bg = FindChildComponent<Image>("m_img_bg");
            m_btn_start = FindChildComponent<Button>("m_img_bg/m_btn_start");
            m_btn_start.onClick.AddListener(OnClick_startBtn);
        }
        #endregion

        #region �¼�
        private void OnClick_startBtn()
        {
            GameModule.Scene.LoadScene("level_1");
        }
        #endregion

    }
}
