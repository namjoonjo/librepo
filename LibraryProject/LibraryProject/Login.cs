using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject
{
    public partial class Login : Form
    {
        #region [1. 생성자 및 변수]

        public Login()
        {
            InitializeComponent();

            initControl();
        }

        #endregion

        #region [2. 이벤트 함수]
        #endregion

        #region [3. 함수]
        private void initControl()
        {
            try
            {
                this.FormBorderStyle = FormBorderStyle.FixedSingle;

                this.StartPosition = FormStartPosition.CenterScreen;

                this.MaximizeBox = false;

                lb_Name.Text = "도 서 관 리 시 스 템";

                lb_forgetID.Text = "아이디/비밀번호를 잊어버리셨나요?";


                Login_picBox.Image = Properties.Resources.Login_lib;

                hopePictureBox1.Image = Bitmap.FromHicon(Properties.Resources.bookIcon.Handle);

            }
            catch (Exception ex)
            {

            }

        }

        #endregion

        
    }
}
    